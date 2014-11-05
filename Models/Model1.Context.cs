//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mlaMVC2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Model1Entities : DbContext
    {
        public Model1Entities()
            : base("name=Model1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<accurint_batch_setup> accurint_batch_setup { get; set; }
        public virtual DbSet<actcode> actcode { get; set; }
        public virtual DbSet<actcode_ltr> actcode_ltr { get; set; }
        public virtual DbSet<action_sched> action_sched { get; set; }
        public virtual DbSet<action_setup> action_setup { get; set; }
        public virtual DbSet<aic_code> aic_code { get; set; }
        public virtual DbSet<aic_request> aic_request { get; set; }
        public virtual DbSet<aj> aj { get; set; }
        public virtual DbSet<ajdet> ajdet { get; set; }
        public virtual DbSet<ap> ap { get; set; }
        public virtual DbSet<apdet> apdet { get; set; }
        public virtual DbSet<apidesc> apidesc { get; set; }
        public virtual DbSet<ar> ar { get; set; }
        public virtual DbSet<ardet> ardet { get; set; }
        public virtual DbSet<assign> assign { get; set; }
        public virtual DbSet<att> att { get; set; }
        public virtual DbSet<bank> bank { get; set; }
        public virtual DbSet<bankdups> bankdups { get; set; }
        public virtual DbSet<bnchmrk> bnchmrk { get; set; }
        public virtual DbSet<bureau_options> bureau_options { get; set; }
        public virtual DbSet<cbinqdepts> cbinqdepts { get; set; }
        public virtual DbSet<cbinqfields> cbinqfields { get; set; }
        public virtual DbSet<chart> chart { get; set; }
        public virtual DbSet<checkver> checkver { get; set; }
        public virtual DbSet<chkverreason> chkverreason { get; set; }
        public virtual DbSet<clt> clt { get; set; }
        public virtual DbSet<clt_online> clt_online { get; set; }
        public virtual DbSet<clt230_view> clt230_view { get; set; }
        public virtual DbSet<cltact> cltact { get; set; }
        public virtual DbSet<cltapprovedltr> cltapprovedltr { get; set; }
        public virtual DbSet<cltltr> cltltr { get; set; }
        public virtual DbSet<cltphon> cltphon { get; set; }
        public virtual DbSet<cltrcvr> cltrcvr { get; set; }
        public virtual DbSet<clttrust> clttrust { get; set; }
        public virtual DbSet<clttrust_historical> clttrust_historical { get; set; }
        public virtual DbSet<clttype> clttype { get; set; }
        public virtual DbSet<cltudf> cltudf { get; set; }
        public virtual DbSet<cltxref> cltxref { get; set; }
        public virtual DbSet<coa> coa { get; set; }
        public virtual DbSet<coadet> coadet { get; set; }
        public virtual DbSet<collpdet> collpdet { get; set; }
        public virtual DbSet<collplan> collplan { get; set; }
        public virtual DbSet<contpdet> contpdet { get; set; }
        public virtual DbSet<contplan> contplan { get; set; }
        public virtual DbSet<costs> costs { get; set; }
        public virtual DbSet<courtcod> courtcod { get; set; }
        public virtual DbSet<credit_bureau> credit_bureau { get; set; }
        public virtual DbSet<dbtr> dbtr { get; set; }
        public virtual DbSet<dbtract> dbtract { get; set; }
        public virtual DbSet<dbtraddr> dbtraddr { get; set; }
        public virtual DbSet<dbtraic> dbtraic { get; set; }
        public virtual DbSet<dbtraka> dbtraka { get; set; }
        public virtual DbSet<dbtrapi> dbtrapi { get; set; }
        public virtual DbSet<dbtrbank> dbtrbank { get; set; }
        public virtual DbSet<dbtrcbinq> dbtrcbinq { get; set; }
        public virtual DbSet<dbtrctc> dbtrctc { get; set; }
        public virtual DbSet<dbtrdial> dbtrdial { get; set; }
        public virtual DbSet<dbtrdup> dbtrdup { get; set; }
        public virtual DbSet<dbtremp> dbtremp { get; set; }
        public virtual DbSet<dbtrltr> dbtrltr { get; set; }
        public virtual DbSet<dbtrold> dbtrold { get; set; }
        public virtual DbSet<dbtrpaym> dbtrpaym { get; set; }
        public virtual DbSet<dbtrphon> dbtrphon { get; set; }
        public virtual DbSet<dbtrpost> dbtrpost { get; set; }
        public virtual DbSet<dbtrprom> dbtrprom { get; set; }
        public virtual DbSet<dbtrrms> dbtrrms { get; set; }
        public virtual DbSet<dbtrsent> dbtrsent { get; set; }
        public virtual DbSet<dbtrudf> dbtrudf { get; set; }
        public virtual DbSet<dbtrxdbt> dbtrxdbt { get; set; }
        public virtual DbSet<dbtrxref> dbtrxref { get; set; }
        public virtual DbSet<debt> debt { get; set; }
        public virtual DbSet<debt_bureau> debt_bureau { get; set; }
        public virtual DbSet<debt2yy_view> debt2yy_view { get; set; }
        public virtual DbSet<debtadj> debtadj { get; set; }
        public virtual DbSet<debtfee> debtfee { get; set; }
        public virtual DbSet<debtfwd> debtfwd { get; set; }
        public virtual DbSet<debtlgl> debtlgl { get; set; }
        public virtual DbSet<debttype> debttype { get; set; }
        public virtual DbSet<debtudf> debtudf { get; set; }
        public virtual DbSet<dialer_actions> dialer_actions { get; set; }
        public virtual DbSet<dst> dst { get; set; }
        public virtual DbSet<dsttype> dsttype { get; set; }
        public virtual DbSet<eodlog> eodlog { get; set; }
        public virtual DbSet<eodproc> eodproc { get; set; }
        public virtual DbSet<eodrep> eodrep { get; set; }
        public virtual DbSet<feecode> feecode { get; set; }
        public virtual DbSet<feepdet> feepdet { get; set; }
        public virtual DbSet<feeplan> feeplan { get; set; }
        public virtual DbSet<holiday> holiday { get; set; }
        public virtual DbSet<ic_request> ic_request { get; set; }
        public virtual DbSet<impfield> impfield { get; set; }
        public virtual DbSet<impgroup> impgroup { get; set; }
        public virtual DbSet<import> import { get; set; }
        public virtual DbSet<indexing> indexing { get; set; }
        public virtual DbSet<language> language { get; set; }
        public virtual DbSet<letter> letter { get; set; }
        public virtual DbSet<letter_state_sub> letter_state_sub { get; set; }
        public virtual DbSet<list_option> list_option { get; set; }
        public virtual DbSet<listoptxwrk> listoptxwrk { get; set; }
        public virtual DbSet<locktable> locktable { get; set; }
        public virtual DbSet<ltrfield> ltrfield { get; set; }
        public virtual DbSet<matchprm> matchprm { get; set; }
        public virtual DbSet<micrchk> micrchk { get; set; }
        public virtual DbSet<period> period { get; set; }
        public virtual DbSet<peryear> peryear { get; set; }
        public virtual DbSet<pmt> pmt { get; set; }
        public virtual DbSet<pmt_post_session> pmt_post_session { get; set; }
        public virtual DbSet<pmtb> pmtb { get; set; }
        public virtual DbSet<pmtbdebt> pmtbdebt { get; set; }
        public virtual DbSet<pmtbfee> pmtbfee { get; set; }
        public virtual DbSet<pmtcode> pmtcode { get; set; }
        public virtual DbSet<pmtfee> pmtfee { get; set; }
        public virtual DbSet<pmtuser> pmtuser { get; set; }
        public virtual DbSet<rms_archive> rms_archive { get; set; }
        public virtual DbSet<rms_code> rms_code { get; set; }
        public virtual DbSet<rmsbank> rmsbank { get; set; }
        public virtual DbSet<salesrep> salesrep { get; set; }
        public virtual DbSet<scanout> scanout { get; set; }
        public virtual DbSet<sentltr> sentltr { get; set; }
        public virtual DbSet<sk> sk { get; set; }
        public virtual DbSet<st_options> st_options { get; set; }
        public virtual DbSet<statcode> statcode { get; set; }
        public virtual DbSet<storegrp> storegrp { get; set; }
        public virtual DbSet<stuser> stuser { get; set; }
        public virtual DbSet<template> template { get; set; }
        public virtual DbSet<test> test { get; set; }
        public virtual DbSet<tz> tz { get; set; }
        public virtual DbSet<tzdet> tzdet { get; set; }
        public virtual DbSet<udfcode> udfcode { get; set; }
        public virtual DbSet<udfpdet> udfpdet { get; set; }
        public virtual DbSet<udfplan> udfplan { get; set; }
        public virtual DbSet<udftype> udftype { get; set; }
        public virtual DbSet<ul_connection_script> ul_connection_script { get; set; }
        public virtual DbSet<ul_script> ul_script { get; set; }
        public virtual DbSet<ul_scripts_modified> ul_scripts_modified { get; set; }
        public virtual DbSet<ul_table> ul_table { get; set; }
        public virtual DbSet<ul_table_script> ul_table_script { get; set; }
        public virtual DbSet<ul_user> ul_user { get; set; }
        public virtual DbSet<userstat> userstat { get; set; }
        public virtual DbSet<userxsales> userxsales { get; set; }
        public virtual DbSet<userxwrk> userxwrk { get; set; }
        public virtual DbSet<vend> vend { get; set; }
        public virtual DbSet<vendamt> vendamt { get; set; }
        public virtual DbSet<worklist> worklist { get; set; }
        public virtual DbSet<zip> zip { get; set; }
    }
}
