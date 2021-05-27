namespace lab1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kwh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKwh = new System.Windows.Forms.TextBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pick = new System.Windows.Forms.Label();
            this.offpick = new System.Windows.Forms.Label();
            this.txtpick = new System.Windows.Forms.TextBox();
            this.txtoff = new System.Windows.Forms.TextBox();
            this.ListCust = new System.Windows.Forms.ListBox();
            this.Accountno = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Accountnumber = new System.Windows.Forms.TextBox();
            this.Custname = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Rcust = new System.Windows.Forms.TextBox();
            this.Ccust = new System.Windows.Forms.TextBox();
            this.Icust = new System.Windows.Forms.TextBox();
            this.Tcust = new System.Windows.Forms.TextBox();
            this.Tcharge = new System.Windows.Forms.TextBox();
            this.Icharge = new System.Windows.Forms.TextBox();
            this.Ccharge = new System.Windows.Forms.TextBox();
            this.Rcharge = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // cobox
            // 
            this.cobox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobox.FormattingEnabled = true;
            this.cobox.Location = new System.Drawing.Point(621, 52);
            this.cobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobox.Name = "cobox";
            this.cobox.Size = new System.Drawing.Size(240, 33);
            this.cobox.TabIndex = 0;
            this.cobox.SelectedIndexChanged += new System.EventHandler(this.cobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select which type of cutomer you are?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kwh
            // 
            this.kwh.AutoSize = true;
            this.kwh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kwh.Location = new System.Drawing.Point(180, 272);
            this.kwh.Name = "kwh";
            this.kwh.Size = new System.Drawing.Size(321, 24);
            this.kwh.TabIndex = 2;
            this.kwh.Text = "kilowatt-hour Used by your house";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bill Amount";
            // 
            // txtKwh
            // 
            this.txtKwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKwh.Location = new System.Drawing.Point(621, 272);
            this.txtKwh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKwh.Name = "txtKwh";
            this.txtKwh.Size = new System.Drawing.Size(147, 27);
            this.txtKwh.TabIndex = 3;
            this.txtKwh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoff_KeyPress);
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(621, 351);
            this.txtBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.Size = new System.Drawing.Size(147, 27);
            this.txtBill.TabIndex = 6;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(551, 404);
            this.calculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(312, 34);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "CALCULATE";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(239, 404);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(251, 34);
            this.clear.TabIndex = 7;
            this.clear.Text = "RESET ALL FIELDS";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1079, 458);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(76, 39);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pick
            // 
            this.pick.AutoSize = true;
            this.pick.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick.Location = new System.Drawing.Point(232, 246);
            this.pick.Name = "pick";
            this.pick.Size = new System.Drawing.Size(323, 24);
            this.pick.TabIndex = 10;
            this.pick.Text = "Kilowhatt-hour Used in pick hours";
            // 
            // offpick
            // 
            this.offpick.AutoSize = true;
            this.offpick.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.offpick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offpick.Location = new System.Drawing.Point(203, 297);
            this.offpick.Name = "offpick";
            this.offpick.Size = new System.Drawing.Size(352, 24);
            this.offpick.TabIndex = 11;
            this.offpick.Text = "Kilowhatt-hour Used in off-pick hours";
            // 
            // txtpick
            // 
            this.txtpick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpick.Location = new System.Drawing.Point(621, 245);
            this.txtpick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpick.Name = "txtpick";
            this.txtpick.Size = new System.Drawing.Size(147, 28);
            this.txtpick.TabIndex = 4;
            this.txtpick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpick_KeyPress);
            // 
            // txtoff
            // 
            this.txtoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoff.Location = new System.Drawing.Point(621, 299);
            this.txtoff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtoff.Name = "txtoff";
            this.txtoff.Size = new System.Drawing.Size(147, 27);
            this.txtoff.TabIndex = 5;
            this.txtoff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkwh_KeyPress);
            // 
            // ListCust
            // 
            this.ListCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCust.FormattingEnabled = true;
            this.ListCust.ItemHeight = 20;
            this.ListCust.Location = new System.Drawing.Point(231, 527);
            this.ListCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListCust.Name = "ListCust";
            this.ListCust.Size = new System.Drawing.Size(1016, 184);
            this.ListCust.TabIndex = 14;
            // 
            // Accountno
            // 
            this.Accountno.AutoSize = true;
            this.Accountno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Accountno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accountno.Location = new System.Drawing.Point(328, 130);
            this.Accountno.Name = "Accountno";
            this.Accountno.Size = new System.Drawing.Size(209, 24);
            this.Accountno.TabIndex = 15;
            this.Accountno.Text = "ACCOUNT NUMBER:";
            this.Accountno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "CUSTOMER NAME:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Accountnumber
            // 
            this.Accountnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accountnumber.Location = new System.Drawing.Point(621, 128);
            this.Accountnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Accountnumber.Name = "Accountnumber";
            this.Accountnumber.ReadOnly = true;
            this.Accountnumber.Size = new System.Drawing.Size(147, 28);
            this.Accountnumber.TabIndex = 1;
            // 
            // Custname
            // 
            this.Custname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Custname.Location = new System.Drawing.Point(621, 187);
            this.Custname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Custname.Name = "Custname";
            this.Custname.Size = new System.Drawing.Size(240, 28);
            this.Custname.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(956, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Residential Customers";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 743);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(948, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Commercial Customers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(977, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Industial Customers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1001, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Customers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(913, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "All Customers Total charges";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(869, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Industial Customers Total charges";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(840, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(295, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Commercial Customers Total charges";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(848, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(287, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Residential Customers Total charges";
            // 
            // Rcust
            // 
            this.Rcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcust.Location = new System.Drawing.Point(1187, 133);
            this.Rcust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rcust.Name = "Rcust";
            this.Rcust.ReadOnly = true;
            this.Rcust.Size = new System.Drawing.Size(65, 22);
            this.Rcust.TabIndex = 28;
            // 
            // Ccust
            // 
            this.Ccust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ccust.Location = new System.Drawing.Point(1187, 158);
            this.Ccust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ccust.Name = "Ccust";
            this.Ccust.ReadOnly = true;
            this.Ccust.Size = new System.Drawing.Size(65, 22);
            this.Ccust.TabIndex = 29;
            // 
            // Icust
            // 
            this.Icust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icust.Location = new System.Drawing.Point(1187, 185);
            this.Icust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Icust.Name = "Icust";
            this.Icust.ReadOnly = true;
            this.Icust.Size = new System.Drawing.Size(65, 22);
            this.Icust.TabIndex = 30;
            // 
            // Tcust
            // 
            this.Tcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tcust.Location = new System.Drawing.Point(1187, 213);
            this.Tcust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tcust.Name = "Tcust";
            this.Tcust.ReadOnly = true;
            this.Tcust.Size = new System.Drawing.Size(65, 22);
            this.Tcust.TabIndex = 31;
            // 
            // Tcharge
            // 
            this.Tcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tcharge.Location = new System.Drawing.Point(1189, 390);
            this.Tcharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tcharge.Name = "Tcharge";
            this.Tcharge.ReadOnly = true;
            this.Tcharge.Size = new System.Drawing.Size(65, 22);
            this.Tcharge.TabIndex = 35;
            // 
            // Icharge
            // 
            this.Icharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icharge.Location = new System.Drawing.Point(1189, 362);
            this.Icharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Icharge.Name = "Icharge";
            this.Icharge.ReadOnly = true;
            this.Icharge.Size = new System.Drawing.Size(65, 22);
            this.Icharge.TabIndex = 34;
            // 
            // Ccharge
            // 
            this.Ccharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ccharge.Location = new System.Drawing.Point(1189, 335);
            this.Ccharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ccharge.Name = "Ccharge";
            this.Ccharge.ReadOnly = true;
            this.Ccharge.Size = new System.Drawing.Size(65, 22);
            this.Ccharge.TabIndex = 33;
            // 
            // Rcharge
            // 
            this.Rcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcharge.Location = new System.Drawing.Point(1189, 310);
            this.Rcharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rcharge.Name = "Rcharge";
            this.Rcharge.ReadOnly = true;
            this.Rcharge.Size = new System.Drawing.Size(65, 22);
            this.Rcharge.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1011, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 24);
            this.label13.TabIndex = 36;
            this.label13.Text = "Number of Customers";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1011, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(236, 24);
            this.label14.TabIndex = 37;
            this.label14.Text = "Charges per Customers ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(235, 475);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 24);
            this.label15.TabIndex = 38;
            this.label15.Text = "Customers History";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(551, 463);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(312, 34);
            this.add.TabIndex = 9;
            this.add.Text = "ADD TO FILE";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1485, 743);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Tcharge);
            this.Controls.Add(this.Icharge);
            this.Controls.Add(this.Ccharge);
            this.Controls.Add(this.Rcharge);
            this.Controls.Add(this.Tcust);
            this.Controls.Add(this.Icust);
            this.Controls.Add(this.Ccust);
            this.Controls.Add(this.Rcust);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Custname);
            this.Controls.Add(this.Accountnumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Accountno);
            this.Controls.Add(this.ListCust);
            this.Controls.Add(this.txtoff);
            this.Controls.Add(this.txtpick);
            this.Controls.Add(this.offpick);
            this.Controls.Add(this.pick);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.txtKwh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kwh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cobox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kwh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKwh;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label pick;
        private System.Windows.Forms.Label offpick;
        private System.Windows.Forms.TextBox txtpick;
        private System.Windows.Forms.TextBox txtoff;
        private System.Windows.Forms.ListBox ListCust;
        private System.Windows.Forms.Label Accountno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Accountnumber;
        private System.Windows.Forms.TextBox Custname;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox Tcharge;
        private System.Windows.Forms.TextBox Icharge;
        private System.Windows.Forms.TextBox Ccharge;
        private System.Windows.Forms.TextBox Rcharge;
        private System.Windows.Forms.TextBox Tcust;
        private System.Windows.Forms.TextBox Icust;
        private System.Windows.Forms.TextBox Ccust;
        private System.Windows.Forms.TextBox Rcust;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button add;
    }
}

