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
    
    public partial class clttrust
    {
        public string CLT_ID { get; set; }
        public string PERIOD { get; set; }
        public short SUB_PERIOD { get; set; }
        public Nullable<decimal> PRIOR_CREDIT { get; set; }
        public Nullable<decimal> CREDIT_APPLY_AMT { get; set; }
        public Nullable<decimal> CREDIT_REFUND_AMT { get; set; }
        public Nullable<decimal> PRIOR_BALANCE { get; set; }
        public Nullable<decimal> BALANCE_DEDUCT_AMT { get; set; }
        public Nullable<decimal> CHECK_AMT { get; set; }
        public Nullable<decimal> REMIT_AMT { get; set; }
        public string FILENAME { get; set; }
        public string TIME_STAMP { get; set; }
        public string USER_ID_STAMP { get; set; }
    }
}
