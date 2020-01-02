using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMR.GP.SMSAlertSystem
{
    public enum DocType { INVOICE = 1, Finance_Charge = 2, Misc_Charge = 3, Return = 4, Credit_Memo = 5, Payment = 6  };
    public enum MSGStatus { ALL = 1, SENT = 2, NOTSENT = 3, ERROR = 4 };
    public enum MSGType { Invoice = 1, Payment = 2, Aging30 = 3, Aging45 = 4, Aging55 = 5, Aging60andOver = 6 };
    public enum QueueItemType
    {
        pmInvoice,
        pmFinanceCharge,
        pmMiscCharge,
        pmReturn,
        pmCreditMemo,
        pmPayment,
        rmReserved,
        rmSaleInvoice,
        rmReservedScheduledPayment,
        rmDebitMemo,
        rmFinanceCharge,
        rmServiceRepair,
        rmWarranty,
        rmCreditMemo,
        rmReturn,
        rmPayment
    }
    public class QueueItem
    {
        public QueueItemType queueItemType { get; set; }
        public int ID { get; set; }

    }
}
