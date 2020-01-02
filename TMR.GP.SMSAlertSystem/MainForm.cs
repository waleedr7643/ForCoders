using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TMR.GP.SMSAlertSystem
{
    public partial class MainForm : Form
    {
        DataAccess db = new DataAccess();
        List<TMRMESSAGETABLE> lstMessages;
        //static frmAgingList AgingList;
        //static frmDataList DataList;
        //static ParametersView ParmView;
        static MessageDetailList MsgList;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            MyTimer_Tick(null, null);

            Timer MyTimer = new Timer();

            MyTimer.Interval = 600000; // 10 mins
            //MyTimer.Interval = 3600000; // 60 mins            
            //MyTimer.Interval = (2000); // 2sec 
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void ms_Main_PaymentsInvoices_Click(object sender, EventArgs e)
        {
            //if (DataList == null || DataList.IsDisposed)
            //{
            //    DataList = new frmDataList();
            //    DataList.StartPosition = FormStartPosition.CenterScreen;
            //    //DataList.MdiParent = this;
            //    DataList.Show();
            //}
            //DataList.BringToFront();

            if (MsgList == null || MsgList.IsDisposed)
            {
                MsgList = new MessageDetailList();
                MsgList.StartPosition = FormStartPosition.CenterScreen;
                //DataList.MdiParent = this;
                MsgList.Show();
            }
            MsgList.BringToFront();

        }

        private void ms_Main_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ms_Main_AgedInvoices_Click(object sender, EventArgs e)
        {
            //if (AgingList == null || AgingList.IsDisposed)
            //{
            //    AgingList = new frmAgingList();
            //    AgingList.StartPosition = FormStartPosition.CenterScreen;
            //    //AgingList.MdiParent = this;
            //    AgingList.Show();
            //}
            //AgingList.BringToFront();

        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<QueueItem> s = e.Argument as List<QueueItem>;
            //s = s.Where(x => x.queueItemType == QueueItemType.PaymentInvoice).ToList();

            foreach (var item in s)
                SendMessage(item);

        }




        // SMS_DAL dal = new SMS_DAL();

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if (bgWorker.IsBusy)
                return;
            List<QueueItem> lstQueueItems = MessageQueue();
            bgWorker.RunWorkerAsync(lstQueueItems);
        }

        List<QueueItem> MessageQueue()
        {
            var lstQueueItems = new List<QueueItem>();
            lstMessages = db.ViewUnsentMessages();

            foreach (var item in lstMessages)
            {
                var queueItem = new QueueItem { queueItemType = (QueueItemType)item.DOCTYPE, ID = item.ID };
                lstQueueItems.Add(queueItem);
            }
            return lstQueueItems;
        }
        void SendMessage(QueueItem item)
        {
            clsSalesTransSMS smsSender = new clsSalesTransSMS();
            var document = lstMessages.Where(x => x.ID == item.ID).FirstOrDefault();
            smsSender.InitiateSendingDocument(document);


            //if (item.queueItemType == QueueItemType.Aging)
            //{
            //    var document = lstAgingIncoices.Where(x => x.ID == item.ID).FirstOrDefault();
            //    smsSender.InitiateSendingInvoiceAging(document);
            //}

            //send message
            //insert row in queue table
            //update main table/s


        }

        private void ms_Main_AgedReport_Click(object sender, EventArgs e)
        {
            //if (ParmView == null || ParmView.IsDisposed)
            //{
            //    ParmView = new ParametersView();
            //    ParmView.StartPosition = FormStartPosition.CenterScreen;
            //    ParmView.reportType = QueueItemType.Aging;
            //    ParmView.Show();
            //}
            //ParmView.BringToFront();
        }

        private void ms_Main_InvoicePaymentReport_Click(object sender, EventArgs e)
        {
            //if (ParmView == null || ParmView.IsDisposed)
            //{
            //    ParmView = new ParametersView();
            //    ParmView.StartPosition = FormStartPosition.CenterScreen;
            //    ParmView.reportType = QueueItemType.PaymentInvoice;
            //    ParmView.Show();
            //}
            //ParmView.BringToFront();
        }
    }
}
