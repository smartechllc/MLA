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
    using System.Collections.Generic;
    
    public partial class actcode
    {
        public int ACTCODE_ID { get; set; }
        public string DESCR { get; set; }
        public byte[] ACT_COMMENT { get; set; }
        public string STATUS_CODE { get; set; }
        public Nullable<short> NEXT_CONTACT_DATE_ADV { get; set; }
        public string WORKLIST_ID { get; set; }
        public string DIALER { get; set; }
        public string TIME_STAMP { get; set; }
        public string USER_ID_STAMP { get; set; }
        public short TYPE { get; set; }
        public byte[] TEXT { get; set; }
        public string CB_DEPT { get; set; }
    }
}