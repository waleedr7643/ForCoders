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
    public partial class MessageDetailList : Form
    {
        DataAccess dt = new DataAccess();
        List<TMRMESSAGETABLE> LstTmrMessagetable = new List<TMRMESSAGETABLE>();
        string status;
        public MessageDetailList()
        {
            InitializeComponent();
        }

        private void MessageDetailList_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LstTmrMessagetable = dt.ViewFilteredMessages(cmbMSGStatus.Text, cmbMSGSeries.Text, DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dateTimePicker2.Text));
            dgSmsList.Rows.Clear();
            foreach (var item in LstTmrMessagetable)
            {
                int i = dgSmsList.Rows.Add();
                dgSmsList.Rows[i].Cells["Docnmbr"].Value = item.DOCNUMBR;


                if (item.SERIES.Trim() == "rm")
                    dgSmsList.Rows[i].Cells["VendorCustomer"].Value = item.CUSTNMBR;
                else if (item.SERIES.Trim() == "pm")
                    dgSmsList.Rows[i].Cells["VendorCustomer"].Value = item.VENDORID;
                dgSmsList.Rows[i].Cells["Doctype"].Value = Enum.GetName(typeof(DocType), item.DOCTYPE);
                dgSmsList.Rows[i].Cells["Duedate"].Value = item.DUEDATE.ToString("dd/MM/yyyy");
                dgSmsList.Rows[i].Cells["Docdate"].Value = item.DOCDATE.ToString("dd/MM/yyyy");
                dgSmsList.Rows[i].Cells["Docamnt"].Value = String.Format("{0:#,##0.00}", item.DOCAMNT);
                dgSmsList.Rows[i].Cells["Vchrnmbr"].Value = item.VCHRNMBR;
                dgSmsList.Rows[i].Cells["Series"].Value = item.SERIES.ToUpper();
                var st = item.Status;

                if (st == 4)
                    status = "Error";
                else if (st == 2)
                    status = "Sent";
                else if (st == 3)
                    status = "NOT SENT";
                dgSmsList.Rows[i].Cells["MSGStatus"].Value = status;

            }
        }


    }
}
