using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMR.GP.SMSAlertSystem
{
    public class TMRAgingInvoice
    {
        public string AccountNUM { get; set; }
        public Nullable<System.DateTime> TRANSDATE { get; set; }
        public Nullable<decimal> AMOUNTCUR { get; set; }
        public string INVOICE { get; set; }
        public Nullable<int> IntervalDays { get; set; }
        public Nullable<int> DaysBucket { get; set; }
        public string DATAAREAID { get; set; }
        public Nullable<int> MSGSTATUS { get; set; }
        public Nullable<System.DateTime> MSGSENTDATE { get; set; }
        public string ERRORMSG { get; set; }
        public int ID { get; set; }
        public Nullable<System.DateTime> RecordDateTime { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        public string PhoneNo3 { get; set; }
    }
}
