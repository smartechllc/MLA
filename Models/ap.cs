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
    
    public partial class ap
    {
        public int AP_ID { get; set; }
        public string AP_DATE { get; set; }
        public string CLT_ID { get; set; }
        public string VEND_ID { get; set; }
        public string NAME { get; set; }
        public string ADDR1 { get; set; }
        public string ADDR2 { get; set; }
        public string CITY { get; set; }
        public string ZIP { get; set; }
        public Nullable<short> STATUS { get; set; }
        public Nullable<short> RECUR_FREQ { get; set; }
        public Nullable<short> RECUR_TIMES { get; set; }
        public string INVOICE_NO { get; set; }
        public string DUE_DATE { get; set; }
        public Nullable<decimal> OUTSTANDING { get; set; }
        public string TIME_STAMP { get; set; }
        public string USER_ID_STAMP { get; set; }
    }
}