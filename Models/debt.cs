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
    
    public partial class debt
    {
        public int DEBT_ID { get; set; }
        public short DEBT_NO { get; set; }
        public string CLT_ID { get; set; }
        public string CLT_REF_NO { get; set; }
        public string ORIG_CLT { get; set; }
        public string ENTERED_DATE { get; set; }
        public string LIST_DATE { get; set; }
        public string SERV_DATE { get; set; }
        public string LAST_CHARGE_DATE { get; set; }
        public string STATUTE_DATE { get; set; }
        public string DEBT_TYPE { get; set; }
        public string DEBT_DESCR { get; set; }
        public string COMMENTS { get; set; }
        public string STATUS_CODE { get; set; }
        public string STATUS_DATE { get; set; }
        public string SALES_REP { get; set; }
        public string BUREAU_REPORT { get; set; }
        public Nullable<decimal> ORIG_PRINC_AMT { get; set; }
        public Nullable<decimal> PRINC_PAID { get; set; }
        public Nullable<decimal> ADJUST_PRINC { get; set; }
        public Nullable<decimal> ORIG_INT_AMT { get; set; }
        public Nullable<decimal> INT_PAID { get; set; }
        public Nullable<decimal> ADJUST_INT { get; set; }
        public Nullable<double> INT_RATE { get; set; }
        public string INT_CALC_DATE { get; set; }
        public Nullable<decimal> UNPAID_INT_ACCRUED { get; set; }
        public Nullable<double> DAILY_INT_AMT { get; set; }
        public string COLLPLAN_ID { get; set; }
        public string FEEPLAN_ID { get; set; }
        public string CONTPLAN_ID { get; set; }
        public Nullable<int> PRIMARY_DEBTOR_ID { get; set; }
        public string DELQ_DATE { get; set; }
        public string REFERENCE_NO { get; set; }
        public string TIME_STAMP { get; set; }
        public string USER_ID_STAMP { get; set; }
        public string POS_CLERK { get; set; }
        public string SECOND_DEPOSIT { get; set; }
        public string UPDATE_FEES { get; set; }
        public string UDFPLAN_ID { get; set; }
        public string DBTRUDFPLAN_ID { get; set; }
        public string CHARGEOFF_DATE { get; set; }
        public Nullable<decimal> LAST_ORIG_PMT_AMT { get; set; }
        public string LAST_ORIG_PMT_DATE { get; set; }
    }
}
