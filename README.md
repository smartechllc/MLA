MLA
===
### Website - Frontend Development

A number of tools & dependencies must be present before script and css resources can be compiled and deployed.  They are:

1. Node.js - runtime for other tools.
2. Ruby - runtime for other tools.
3. Bower - package manager (Node).
4. Grunt - build system with capabilities such as bundling, minification, etc. (Node).
5. Compass - SASS (Ruby).

(see [Development Environment Setup](#development-environment-setup) below)

Only during development is the above toolset required. All of the above simply get the front end resources prepared to be served natively from a webserver or CDN. A live server running the AboutTime software should not have any of these installed. The build server is an exception; it not only builds the software (requiring this toolset), it also hosts a running installation of AboutTime.

The workhorse of the frontend development is Grunt. During a build, Grunt executes the commands and tasks described in the gruntfile.js file. The root of all the resource files is src/ControlCenter/Content and is where you'll find gruntfile.js. To execute a build:
    
    $src/ControlCenter/Content > grunt build
 
 This will package up all the necessary resource files, edit the main ASP.Net MVC view `$src/ControlCenter/Content/src/main.cshtml` to reference the appropriate CSS and JS files, and copy everything into the deployment directory.

However, under normal development circumstances, you want Grunt to constantly monitor your work and keep the browser sync'd with your changes. Doing:

    $src/ControlCenter/Content > grunt dev

will run a continuous and non-terminating Grunt build.

Grunt does some tasks natively, has plug-ins for other tasks, and works in concert with Bower and Compass to build and deploy. Customizing the build is a matter of modifying gruntfile.js.

### Website - Backend Development

ASP.Net MVC serves the various HTML, CSS, and JS files - many of which are generated or pulled in by Grunt - to a web browser. AboutTime is an AngularJS / SPA and required a customized ASP.Net MVC site to accommodate this fact. An "out of the box" ASP.Net MVC site will place controllers into `~/Controllers` and views into `~/Views`. For AboutTime, controllers & views are grouped together into a subdirectory for its particular module where each module is essentially a product offering under the AboutTime umbrella. As of this writing there are:

- Assets
- Forms
- Insight
- Platform (a special module for base-level platform functionality and services)
- Reports
- Time

with an accompanying directory for each under `$src/ControlCenter/Modules`
***
Routing took great care to get right in order to satisfy the particular needs of AngularJS. Default routes are satisified by the catch-all route in the PlatformController controller class. If a file exists on disk that satisfies the URL convention then it's served. Additionally there are particular cases where routing has been expressly set using ASP.Net MVC's attribute routing.

### Devart Licensing

AboutTime uses PostgreSQL and the for-pay Devart EntityFramework driver. Devart ships with an installer that can only be installed once per purchased license. The install should be performed on the build server. The build server will then produce a distributable license for use in all other developer installations.

> A build on a Devart-licensed machine produces a license.licx file so that the Devart assemblies can be deployed on non-Devart-installed machines (which is within the allowance of the Devart EULA). Any project that interacts with the database must have a valid license. The license.licx file may only be used on machines that have a valid install of the Devart dotConnect tools. Ultimately a project-assembly-name.dll.licenses file must be generated and linked into a given project as an embedded resource. Visual Studio will automatically generate a .licenses file during compilation if the license.licx file is added to the root of the project and then compiled; find the generated .licenses file in the /obj dir. Generation of a .licenses file may also be done using lc.exe for a more formal build process (indeed Visual Studio uses lc.exe). Finally, the .licenses file should be committed to source control so that they're distributed to other developers on the team. Note that license.licx is simply plain text with its contents pointing to the component / assembly that requires licensing. Once the .licenses file is produced the license.licx file should be removed before committing to source control; if the license.licx is part of the project when compiled on a non-Devart-installed machine it will fail.

The above setup has already been done (see: `$src/misc/license.licx`) but may need to be redone in the future when the Devart installation gets moved to the build server. The above process must be done once per project whose compilation output is a running process (i.e. either an .exe or an IIS ASP.Net-hosted process). IIS-hosted processes, however, are a special case - all separate processes (ControlCenter, DataService, and MessageDispatcher as of this writing) require only the singled-license DataAccess project.

### Development Environment Setup

- Visual Studio 2013 - a vanilla install should suffice.
- Install git command line for Windows (e.g. [msysgit](http://msysgit.github.io/)).
- Set PATH environment variable to point to git.exe if it wasn't set by the installer in the above step.
- Install [Node.js](http://nodejs.org/download/) for Windows.
- Install [Ruby](http://rubyinstaller.org/downloads/) for Windows using the recommended version (not the newer, bleeding-edge, beta versions). Be sure to tick the option for setting the PATH environment variable.
- Install Compass:
```
    gem install compass
```
- Install Grunt + Bower, update, and build:
```
    cd $src/ControlCenter/Content
    npm install -g grunt-cli
    npm install -g bower
    npm install
    bower update
    grunt build
```
- Install [PostgreSQL](http://www.postgresql.org/download/) for Windows.
- Using pgAdmin III, create a new login role `abt_user` with password `abc123`.
- Using pgAdmin III, create a new database `about_time` with its owner set to `abt_user`.
- Generate the default language resource file (repeat until it succeeds). From Visual Studio:
```
    right-click AutoGen\Languages.tt > Run Custom Tool
```
- Run the EF migrations to achieve a functioning database: from within Visual Studio right-click the "ControlCenter" project > Set as StartUp Project, then within the Package Manager Console set the Default project: dropdown to "Migrations" and run the command:
```
    update-database -verbose
```
*Entity Framework may need reinstallation via Nuget on the Migrations project (and bouncing Visual Studio) if there is an error where the update-database command is not found.*

*Trouble shooting failing migrations can be a bit tricky on non-Devart-installed machines because the error that's reported is erroneous due to migration.exe not finding the Devart assemblies. Therefore there is a $src/Migrations/migrate-manually.bat script file that, when run, should perform the migrations and report proper error messages.*
