namespace TMR.GP.SMSAlertSystem
{
    partial class MessageDetailList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMSGSeries = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMSGStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgSmsList = new System.Windows.Forms.DataGridView();
            this.Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docnmbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docamnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vchrnmbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSmsList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleName = "ll";
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbMSGSeries);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbMSGStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(510, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(191, 98);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 26);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.Value = new System.DateTime(2019, 4, 9, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 40);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 26);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2019, 4, 9, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "End Date";
            // 
            // cmbMSGSeries
            // 
            this.cmbMSGSeries.AccessibleName = "cmbMessageSeries";
            this.cmbMSGSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMSGSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMSGSeries.FormattingEnabled = true;
            this.cmbMSGSeries.Items.AddRange(new object[] {
            "All",
            "RM ",
            "PM"});
            this.cmbMSGSeries.Location = new System.Drawing.Point(47, 98);
            this.cmbMSGSeries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMSGSeries.Name = "cmbMSGSeries";
            this.cmbMSGSeries.Size = new System.Drawing.Size(123, 28);
            this.cmbMSGSeries.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Message Series";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Start Date";
            // 
            // cmbMSGStatus
            // 
            this.cmbMSGStatus.AccessibleName = "cmbMessageStatus";
            this.cmbMSGStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMSGStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMSGStatus.FormattingEnabled = true;
            this.cmbMSGStatus.Items.AddRange(new object[] {
            "All",
            "Unsent",
            "Sent",
            "Error"});
            this.cmbMSGStatus.Location = new System.Drawing.Point(47, 40);
            this.cmbMSGStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMSGStatus.Name = "cmbMSGStatus";
            this.cmbMSGStatus.Size = new System.Drawing.Size(123, 28);
            this.cmbMSGStatus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dgSmsList
            // 
            this.dgSmsList.AllowUserToAddRows = false;
            this.dgSmsList.AllowUserToDeleteRows = false;
            this.dgSmsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSmsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Series,
            this.Docnmbr,
            this.Doctype,
            this.VendorCustomer,
            this.Docdate,
            this.Duedate,
            this.Docamnt,
            this.Vchrnmbr,
            this.MsgStatus});
            this.dgSmsList.Location = new System.Drawing.Point(2, 164);
            this.dgSmsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgSmsList.Name = "dgSmsList";
            this.dgSmsList.ReadOnly = true;
            this.dgSmsList.RowTemplate.Height = 24;
            this.dgSmsList.Size = new System.Drawing.Size(1004, 379);
            this.dgSmsList.TabIndex = 9;
            // 
            // Series
            // 
            this.Series.HeaderText = "Series";
            this.Series.Name = "Series";
            this.Series.ReadOnly = true;
            this.Series.Width = 60;
            // 
            // Docnmbr
            // 
            this.Docnmbr.HeaderText = "Doc Number";
            this.Docnmbr.Name = "Docnmbr";
            this.Docnmbr.ReadOnly = true;
            this.Docnmbr.Width = 120;
            // 
            // Doctype
            // 
            this.Doctype.HeaderText = "Doc Type";
            this.Doctype.Name = "Doctype";
            this.Doctype.ReadOnly = true;
            this.Doctype.Width = 160;
            // 
            // VendorCustomer
            // 
            this.VendorCustomer.HeaderText = "Vendor/Customer";
            this.VendorCustomer.Name = "VendorCustomer";
            this.VendorCustomer.ReadOnly = true;
            this.VendorCustomer.Width = 120;
            // 
            // Docdate
            // 
            this.Docdate.HeaderText = "Doc Date";
            this.Docdate.Name = "Docdate";
            this.Docdate.ReadOnly = true;
            // 
            // Duedate
            // 
            this.Duedate.HeaderText = "Due Date";
            this.Duedate.Name = "Duedate";
            this.Duedate.ReadOnly = true;
            // 
            // Docamnt
            // 
            this.Docamnt.HeaderText = "Doc Amount";
            this.Docamnt.Name = "Docamnt";
            this.Docamnt.ReadOnly = true;
            // 
            // Vchrnmbr
            // 
            this.Vchrnmbr.HeaderText = "Vchrnmbr";
            this.Vchrnmbr.Name = "Vchrnmbr";
            this.Vchrnmbr.ReadOnly = true;
            this.Vchrnmbr.Width = 120;
            // 
            // MsgStatus
            // 
            this.MsgStatus.HeaderText = "Status";
            this.MsgStatus.Name = "MsgStatus";
            this.MsgStatus.ReadOnly = true;
            this.MsgStatus.Width = 80;
            // 
            // MessageDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 554);
            this.Controls.Add(this.dgSmsList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MessageDetailList";
            this.Text = "DetailList";
            this.Load += new System.EventHandler(this.MessageDetailList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSmsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMSGStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgSmsList;
        private System.Windows.Forms.ComboBox cmbMSGSeries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Series;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docnmbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctype;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docamnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vchrnmbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgStatus;
    }
}