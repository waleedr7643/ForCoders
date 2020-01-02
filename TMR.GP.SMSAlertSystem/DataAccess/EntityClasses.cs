using System;

namespace TMR.GP.SMSAlertSystem
{   
    public class TMRMESSAGETABLE
    {
        public int ID { get; set; }
        public string VENDORID { get; set; }
        public string CUSTNMBR { get; set; }
        public string DOCNUMBR { get; set; }
        public int DOCTYPE { get; set; }
        public DateTime DOCDATE { get; set; }
        public DateTime DUEDATE { get; set; }
        public decimal DOCAMNT { get; set; }
        public string VCHRNMBR { get; set; }
        public string SERIES { get; set; }
        public int Status { get; set; }
        public string ErrorMsg { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        public string PhoneNo3 { get; set; }
        public DateTime AttemptDate { get; set; }
    }
    public class TMRDOCTYPE
    {
        public int id { get; set; }
        public int DOCTYPE { get; set; }
        public string SERIES { get; set; }
        public string DESCRIPTION { get; set; }
        public string Message { get; set; }
    }
    public class TMRMESSAGESTATUS
    {
        public int id { get; set; }
        public int StatusId { get; set; }
        public string DESCRIPTION { get; set; }
    }
}