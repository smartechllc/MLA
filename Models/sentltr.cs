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
    
    public partial class sentltr
    {
        public int SENT_LTR_ID { get; set; }
        public string LETTER_DATE { get; set; }
        public string DEBTOR_ID { get; set; }
        public string LETTER_ID { get; set; }
        public Nullable<int> DEBT_ID { get; set; }
        public Nullable<short> DEBT_NO { get; set; }
        public string LETTER_ADDR { get; set; }
        public string ADDR1 { get; set; }
        public string ADDR2 { get; set; }
        public string CITY { get; set; }
        public string ZIP { get; set; }
        public string FORM_TYPE { get; set; }
        public string TIME_STAMP { get; set; }
        public string USER_ID_STAMP { get; set; }
    }
}