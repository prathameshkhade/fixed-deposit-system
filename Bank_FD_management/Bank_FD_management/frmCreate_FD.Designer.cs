namespace Bank_FD_management
{
    partial class frmCreate_FD
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
            this.pnltitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnldetails = new System.Windows.Forms.Panel();
            this.rdbonmaturity = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdbhalfyearly = new System.Windows.Forms.RadioButton();
            this.lblfdamount = new System.Windows.Forms.Label();
            this.cmbfdtype = new System.Windows.Forms.ComboBox();
            this.rdbquaterly = new System.Windows.Forms.RadioButton();
            this.lblfdtype = new System.Windows.Forms.Label();
            this.rdbmonthly = new System.Windows.Forms.RadioButton();
            this.lblinterest = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblinterestinterval = new System.Windows.Forms.Label();
            this.lblmonths = new System.Windows.Forms.Label();
            this.lbldays = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtinterestrate = new System.Windows.Forms.TextBox();
            this.lblinterestrate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblmaturitydate = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblstartdate = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblfinalamount = new System.Windows.Forms.Label();
            this.txttotalinterest = new System.Windows.Forms.TextBox();
            this.lbltotalinterest = new System.Windows.Forms.Label();
            this.txtperiodicinterest = new System.Windows.Forms.TextBox();
            this.lblperiodicinterest = new System.Windows.Forms.Label();
            this.pnlbuttons = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.lblfdid = new System.Windows.Forms.Label();
            this.txtfdid = new System.Windows.Forms.TextBox();
            this.pnltitle.SuspendLayout();
            this.pnldetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlbuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltitle
            // 
            this.pnltitle.BackColor = System.Drawing.Color.LightGray;
            this.pnltitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnltitle.Controls.Add(this.lbltitle);
            this.pnltitle.Location = new System.Drawing.Point(13, 12);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(1131, 60);
            this.pnltitle.TabIndex = 2;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(479, 7);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(190, 42);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Create FD";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(45, 69);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(71, 24);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name :";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(122, 69);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(424, 29);
            this.txtname.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(37, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 24);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Cust ID :";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(122, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(198, 29);
            this.txtID.TabIndex = 3;
            // 
            // pnldetails
            // 
            this.pnldetails.AutoSize = true;
            this.pnldetails.BackColor = System.Drawing.Color.LightGray;
            this.pnldetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnldetails.Controls.Add(this.lblfdid);
            this.pnldetails.Controls.Add(this.txtfdid);
            this.pnldetails.Controls.Add(this.rdbonmaturity);
            this.pnldetails.Controls.Add(this.textBox1);
            this.pnldetails.Controls.Add(this.rdbhalfyearly);
            this.pnldetails.Controls.Add(this.lblfdamount);
            this.pnldetails.Controls.Add(this.cmbfdtype);
            this.pnldetails.Controls.Add(this.rdbquaterly);
            this.pnldetails.Controls.Add(this.lblfdtype);
            this.pnldetails.Controls.Add(this.rdbmonthly);
            this.pnldetails.Controls.Add(this.txtID);
            this.pnldetails.Controls.Add(this.lblinterest);
            this.pnldetails.Controls.Add(this.comboBox2);
            this.pnldetails.Controls.Add(this.lblID);
            this.pnldetails.Controls.Add(this.lblinterestinterval);
            this.pnldetails.Controls.Add(this.txtname);
            this.pnldetails.Controls.Add(this.lblname);
            this.pnldetails.Controls.Add(this.lblmonths);
            this.pnldetails.Controls.Add(this.lbldays);
            this.pnldetails.Controls.Add(this.comboBox1);
            this.pnldetails.Location = new System.Drawing.Point(13, 88);
            this.pnldetails.Name = "pnldetails";
            this.pnldetails.Size = new System.Drawing.Size(1131, 322);
            this.pnldetails.TabIndex = 3;
            this.pnldetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnldetails_Paint);
            // 
            // rdbonmaturity
            // 
            this.rdbonmaturity.AutoSize = true;
            this.rdbonmaturity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbonmaturity.Location = new System.Drawing.Point(475, 266);
            this.rdbonmaturity.Name = "rdbonmaturity";
            this.rdbonmaturity.Size = new System.Drawing.Size(245, 28);
            this.rdbonmaturity.TabIndex = 28;
            this.rdbonmaturity.TabStop = true;
            this.rdbonmaturity.Text = "Interest payout on maturity";
            this.rdbonmaturity.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(122, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 29);
            this.textBox1.TabIndex = 17;
            // 
            // rdbhalfyearly
            // 
            this.rdbhalfyearly.AutoSize = true;
            this.rdbhalfyearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbhalfyearly.Location = new System.Drawing.Point(347, 266);
            this.rdbhalfyearly.Name = "rdbhalfyearly";
            this.rdbhalfyearly.Size = new System.Drawing.Size(114, 28);
            this.rdbhalfyearly.TabIndex = 27;
            this.rdbhalfyearly.TabStop = true;
            this.rdbhalfyearly.Text = "Half yearly";
            this.rdbhalfyearly.UseVisualStyleBackColor = true;
            // 
            // lblfdamount
            // 
            this.lblfdamount.AutoSize = true;
            this.lblfdamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfdamount.Location = new System.Drawing.Point(3, 174);
            this.lblfdamount.Name = "lblfdamount";
            this.lblfdamount.Size = new System.Drawing.Size(113, 24);
            this.lblfdamount.TabIndex = 16;
            this.lblfdamount.Text = "FD amount :";
            // 
            // cmbfdtype
            // 
            this.cmbfdtype.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbfdtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfdtype.FormattingEnabled = true;
            this.cmbfdtype.Location = new System.Drawing.Point(122, 120);
            this.cmbfdtype.Name = "cmbfdtype";
            this.cmbfdtype.Size = new System.Drawing.Size(203, 32);
            this.cmbfdtype.TabIndex = 15;
            // 
            // rdbquaterly
            // 
            this.rdbquaterly.AutoSize = true;
            this.rdbquaterly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbquaterly.Location = new System.Drawing.Point(231, 266);
            this.rdbquaterly.Name = "rdbquaterly";
            this.rdbquaterly.Size = new System.Drawing.Size(104, 28);
            this.rdbquaterly.TabIndex = 26;
            this.rdbquaterly.TabStop = true;
            this.rdbquaterly.Text = "Quarterly";
            this.rdbquaterly.UseVisualStyleBackColor = true;
            // 
            // lblfdtype
            // 
            this.lblfdtype.AutoSize = true;
            this.lblfdtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfdtype.Location = new System.Drawing.Point(23, 123);
            this.lblfdtype.Name = "lblfdtype";
            this.lblfdtype.Size = new System.Drawing.Size(93, 24);
            this.lblfdtype.TabIndex = 14;
            this.lblfdtype.Text = "FD Type :";
            // 
            // rdbmonthly
            // 
            this.rdbmonthly.AutoSize = true;
            this.rdbmonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmonthly.Location = new System.Drawing.Point(122, 266);
            this.rdbmonthly.Name = "rdbmonthly";
            this.rdbmonthly.Size = new System.Drawing.Size(94, 28);
            this.rdbmonthly.TabIndex = 25;
            this.rdbmonthly.TabStop = true;
            this.rdbmonthly.Text = "Monthly";
            this.rdbmonthly.UseVisualStyleBackColor = true;
            // 
            // lblinterest
            // 
            this.lblinterest.AutoSize = true;
            this.lblinterest.CausesValidation = false;
            this.lblinterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinterest.Location = new System.Drawing.Point(36, 268);
            this.lblinterest.Name = "lblinterest";
            this.lblinterest.Size = new System.Drawing.Size(80, 24);
            this.lblinterest.TabIndex = 24;
            this.lblinterest.Text = "interest :";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(387, 216);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 32);
            this.comboBox2.TabIndex = 23;
            // 
            // lblinterestinterval
            // 
            this.lblinterestinterval.AutoSize = true;
            this.lblinterestinterval.CausesValidation = false;
            this.lblinterestinterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinterestinterval.Location = new System.Drawing.Point(42, 219);
            this.lblinterestinterval.Name = "lblinterestinterval";
            this.lblinterestinterval.Size = new System.Drawing.Size(75, 24);
            this.lblinterestinterval.TabIndex = 19;
            this.lblinterestinterval.Text = "Period :";
            // 
            // lblmonths
            // 
            this.lblmonths.AutoSize = true;
            this.lblmonths.CausesValidation = false;
            this.lblmonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonths.Location = new System.Drawing.Point(128, 219);
            this.lblmonths.Name = "lblmonths";
            this.lblmonths.Size = new System.Drawing.Size(82, 24);
            this.lblmonths.TabIndex = 20;
            this.lblmonths.Text = "Months :";
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.CausesValidation = false;
            this.lbldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.Location = new System.Drawing.Point(320, 219);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(61, 24);
            this.lbldays.TabIndex = 22;
            this.lbldays.Text = "Days :";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 216);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 32);
            this.comboBox1.TabIndex = 21;
            // 
            // txtinterestrate
            // 
            this.txtinterestrate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtinterestrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinterestrate.Location = new System.Drawing.Point(178, 23);
            this.txtinterestrate.Name = "txtinterestrate";
            this.txtinterestrate.Size = new System.Drawing.Size(147, 29);
            this.txtinterestrate.TabIndex = 30;
            // 
            // lblinterestrate
            // 
            this.lblinterestrate.AutoSize = true;
            this.lblinterestrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinterestrate.Location = new System.Drawing.Point(56, 23);
            this.lblinterestrate.Name = "lblinterestrate";
            this.lblinterestrate.Size = new System.Drawing.Size(116, 24);
            this.lblinterestrate.TabIndex = 29;
            this.lblinterestrate.Text = "Interest rate :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.lblmaturitydate);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.lblstartdate);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblfinalamount);
            this.panel1.Controls.Add(this.txttotalinterest);
            this.panel1.Controls.Add(this.lbltotalinterest);
            this.panel1.Controls.Add(this.txtperiodicinterest);
            this.panel1.Controls.Add(this.lblperiodicinterest);
            this.panel1.Controls.Add(this.txtinterestrate);
            this.panel1.Controls.Add(this.lblinterestrate);
            this.panel1.Location = new System.Drawing.Point(13, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 299);
            this.panel1.TabIndex = 31;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(178, 246);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(147, 29);
            this.textBox5.TabIndex = 40;
            // 
            // lblmaturitydate
            // 
            this.lblmaturitydate.AutoSize = true;
            this.lblmaturitydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaturitydate.Location = new System.Drawing.Point(47, 249);
            this.lblmaturitydate.Name = "lblmaturitydate";
            this.lblmaturitydate.Size = new System.Drawing.Size(125, 24);
            this.lblmaturitydate.TabIndex = 39;
            this.lblmaturitydate.Text = "Maturity date :";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(178, 202);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(147, 29);
            this.textBox4.TabIndex = 38;
            // 
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartdate.Location = new System.Drawing.Point(49, 205);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(123, 24);
            this.lblstartdate.TabIndex = 37;
            this.lblstartdate.Text = "Starting date :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(178, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 29);
            this.textBox2.TabIndex = 36;
            // 
            // lblfinalamount
            // 
            this.lblfinalamount.AutoSize = true;
            this.lblfinalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinalamount.Location = new System.Drawing.Point(43, 161);
            this.lblfinalamount.Name = "lblfinalamount";
            this.lblfinalamount.Size = new System.Drawing.Size(129, 24);
            this.lblfinalamount.TabIndex = 35;
            this.lblfinalamount.Text = "Final amount :";
            // 
            // txttotalinterest
            // 
            this.txttotalinterest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttotalinterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalinterest.Location = new System.Drawing.Point(178, 113);
            this.txttotalinterest.Name = "txttotalinterest";
            this.txttotalinterest.Size = new System.Drawing.Size(147, 29);
            this.txttotalinterest.TabIndex = 34;
            // 
            // lbltotalinterest
            // 
            this.lbltotalinterest.AutoSize = true;
            this.lbltotalinterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalinterest.Location = new System.Drawing.Point(45, 116);
            this.lbltotalinterest.Name = "lbltotalinterest";
            this.lbltotalinterest.Size = new System.Drawing.Size(126, 24);
            this.lbltotalinterest.TabIndex = 33;
            this.lbltotalinterest.Text = "Total Interest :";
            // 
            // txtperiodicinterest
            // 
            this.txtperiodicinterest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtperiodicinterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperiodicinterest.Location = new System.Drawing.Point(178, 68);
            this.txtperiodicinterest.Name = "txtperiodicinterest";
            this.txtperiodicinterest.Size = new System.Drawing.Size(147, 29);
            this.txtperiodicinterest.TabIndex = 32;
            // 
            // lblperiodicinterest
            // 
            this.lblperiodicinterest.AutoSize = true;
            this.lblperiodicinterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperiodicinterest.Location = new System.Drawing.Point(13, 71);
            this.lblperiodicinterest.Name = "lblperiodicinterest";
            this.lblperiodicinterest.Size = new System.Drawing.Size(159, 24);
            this.lblperiodicinterest.TabIndex = 31;
            this.lblperiodicinterest.Text = "Periodic Interest  :";
            // 
            // pnlbuttons
            // 
            this.pnlbuttons.BackColor = System.Drawing.Color.LightGray;
            this.pnlbuttons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlbuttons.Controls.Add(this.btnexit);
            this.pnlbuttons.Controls.Add(this.btncreate);
            this.pnlbuttons.Controls.Add(this.btncancel);
            this.pnlbuttons.Location = new System.Drawing.Point(12, 748);
            this.pnlbuttons.Name = "pnlbuttons";
            this.pnlbuttons.Size = new System.Drawing.Size(1132, 100);
            this.pnlbuttons.TabIndex = 32;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(693, 27);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(130, 38);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(499, 27);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(130, 38);
            this.btncreate.TabIndex = 1;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(308, 27);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(130, 38);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // lblfdid
            // 
            this.lblfdid.AutoSize = true;
            this.lblfdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfdid.Location = new System.Drawing.Point(425, 25);
            this.lblfdid.Name = "lblfdid";
            this.lblfdid.Size = new System.Drawing.Size(67, 24);
            this.lblfdid.TabIndex = 29;
            this.lblfdid.Text = "FD ID :";
            // 
            // txtfdid
            // 
            this.txtfdid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtfdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfdid.Location = new System.Drawing.Point(498, 22);
            this.txtfdid.Name = "txtfdid";
            this.txtfdid.Size = new System.Drawing.Size(198, 29);
            this.txtfdid.TabIndex = 30;
            // 
            // frmCreate_FD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 860);
            this.Controls.Add(this.pnlbuttons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnldetails);
            this.Controls.Add(this.pnltitle);
            this.Name = "frmCreate_FD";
            this.Text = "Create_FD";
            this.Load += new System.EventHandler(this.Create_FD_Load);
            this.pnltitle.ResumeLayout(false);
            this.pnltitle.PerformLayout();
            this.pnldetails.ResumeLayout(false);
            this.pnldetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlbuttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel pnldetails;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblfdamount;
        private System.Windows.Forms.Label lblinterestinterval;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblmonths;
        private System.Windows.Forms.RadioButton rdbonmaturity;
        private System.Windows.Forms.RadioButton rdbhalfyearly;
        private System.Windows.Forms.RadioButton rdbquaterly;
        private System.Windows.Forms.RadioButton rdbmonthly;
        private System.Windows.Forms.Label lblinterest;
        private System.Windows.Forms.TextBox txtinterestrate;
        private System.Windows.Forms.Label lblinterestrate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttotalinterest;
        private System.Windows.Forms.Label lbltotalinterest;
        private System.Windows.Forms.TextBox txtperiodicinterest;
        private System.Windows.Forms.Label lblperiodicinterest;
        private System.Windows.Forms.ComboBox cmbfdtype;
        private System.Windows.Forms.Label lblfdtype;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblfinalamount;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblstartdate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblmaturitydate;
        private System.Windows.Forms.Panel pnlbuttons;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblfdid;
        private System.Windows.Forms.TextBox txtfdid;
    }
}