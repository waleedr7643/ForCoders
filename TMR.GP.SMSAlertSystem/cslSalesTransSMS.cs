using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMR.GP.SMSAlertSystem
{
    public class clsSalesTransSMS
    {
        static List<TMRDOCTYPE> MessageTexts;
        DataAccess dAccess = new DataAccess();

        public bool updateMSGSTATUS = true;
        public clsSalesTransSMS()
        {
            if (MessageTexts == null)
                MessageTexts = dAccess.ViewUnsentMessagesfordoctype();

            //lstdoctype = dt.ViewUnsentMessagesfordoctype();
        }

        List<string> lstIncorrectNbrs = new List<string>();

        public void PopulateList(List<TMRMESSAGETABLE> lst)
        {
            InitiateSending(lst);
        }
        public bool InitiateSending(List<TMRMESSAGETABLE> lstTransactions)
        {

            foreach (var item in lstTransactions)
            {
                if (item.PhoneNo3 == null || item.PhoneNo3.Length != 11)
                {
                    lstIncorrectNbrs.Add(item.PhoneNo3);
                    item.ErrorMsg = "INCORRECTNBR";
                    //item.MSGSTATUS = 4; //ERROR
                    continue;
                }
                string msg = "TEST SMS";
                bool done = clsSendSMS.SendSMS(item.PhoneNo3, msg);
                if (done)
                {
                    //item.MSGSTATUS = 2; //SENT
                    item.ErrorMsg = "Send Successfully";
                }

                else
                {
                    if (updateMSGSTATUS == true)
                    {
                        //item.MSGSTATUS = 4; //ERROR
                    }
                    else return false;
                }

            }
            //new Controller().UpdateSalesTransTable(lstTransactions);
            return true;
        }

        public bool InitiateSendingDocument(TMRMESSAGETABLE item)
        {
            string phoneNumber = "";
            string phoneNumber2 = "";
            string phoneNumber3 = "";

            bool result1 = CheckPhoneValidity(item.PhoneNo1, out phoneNumber);
            bool result2 = CheckPhoneValidity(item.PhoneNo2, out phoneNumber2);
            bool result3 = CheckPhoneValidity(item.PhoneNo3, out phoneNumber3);

            if (result1 == false)
            {
                lstIncorrectNbrs.Add(item.PhoneNo1);
                item.ErrorMsg = "INCORRECTNBR";
                item.Status = 4; //ERROR  
            }

            if (result2 == false)
            {
                lstIncorrectNbrs.Add(item.PhoneNo2);
                item.ErrorMsg = "INCORRECTNBR";
                item.Status = 4; //ERROR                  
            }

            if (result3 == false)
            {
                lstIncorrectNbrs.Add(item.PhoneNo3);
                item.ErrorMsg = "INCORRECTNBR";
                item.Status = 4; //ERROR                  
            }

            var v = MessageTexts.Where(x => x.SERIES == item.SERIES && x.DOCTYPE == item.DOCTYPE).FirstOrDefault();
            string MessageText = v.Message;


            MessageText = MessageText.Replace("<DOCNUMBR>", string.Format("{0:F2}", item.DOCNUMBR).Trim());
            MessageText = MessageText.Replace("<DOCAMNT>", item.DOCAMNT.ToString("N2"));
            MessageText = MessageText.Replace("<DOCDATE>", ((DateTime)item.DOCDATE).ToString("dd-MM-yyyy"));
            MessageText = MessageText.Replace("<DUEDATE>", ((DateTime)item.DOCDATE).ToString("dd-MM-yyyy"));
            bool done = false, done2 = false, done3 = false;
            try
            {

                if (result1)
                {                   
                    done = clsSendSMS.SendSMS(phoneNumber, MessageText);                   
                }
                if (result2)
                    done2 = clsSendSMS.SendSMS(phoneNumber2, MessageText);
                if (result3)
                    done3 = clsSendSMS.SendSMS(phoneNumber3, MessageText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ ex);
            }

            if (done == true || done2 == true || done3 == true)
            {
                item.Status = 2; //SENT 

                if (done && done2 && done3)
                {
                    item.ErrorMsg = "Sent to all numbers.";
                }
                else if (!(done && done2 && done3))
                {
                    item.ErrorMsg = "Not sent to all numbers.";
                }
            }
            else if (done != true || done2 != true || done3 != true)
            {
                item.Status = 1; //SENT 
                item.ErrorMsg = "Failed to send to all numbers";
            }

            dAccess.UpdateTMRMessageTable(item);
            return true;
        }    

        private bool CheckPhoneValidity(string phone, out string phoneNumber)
        {
            if (phone == null)
            {
                phoneNumber = "0";
                return false;
            }

            phone = phone.Replace("-", "").Trim();

            if (phone.Length != 11)
            {
                phoneNumber = "0";
                return false;
            }

            Int64 phoneNo = 0;
            bool result = Int64.TryParse(phone, out phoneNo);

            if (result == false)
            {
                phoneNumber = "0";
                return false;
            }

            phoneNumber = phone;

            return result;
        }        
    }
}
