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
    
    public partial class dbtrprom
    {
        public int DEBTOR_ID { get; set; }
        public int ITEM_NO { get; set; }
        public string PROM_DATE { get; set; }
        public Nullable<decimal> PROM_AMT { get; set; }
        public Nullable<decimal> PAID_AMT { get; set; }
        public string TIME_STAMP { get; set; }
        public string USER_ID_STAMP { get; set; }
    }
}
