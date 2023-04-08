namespace Bank_FD_management
{
    partial class frmFD_master
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlRates = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblMaturityDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtFinalAmount = new System.Windows.Forms.TextBox();
            this.lblFinalAmount = new System.Windows.Forms.Label();
            this.txtTotalInterest = new System.Windows.Forms.TextBox();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.txtPeriodicInterest = new System.Windows.Forms.TextBox();
            this.lblPeriodicInterest = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblInterstRate = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblInterestInterval = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblFDType = new System.Windows.Forms.Label();
            this.cmbFDType = new System.Windows.Forms.ComboBox();
            this.lblFDAmout = new System.Windows.Forms.Label();
            this.txtFDAmount = new System.Windows.Forms.TextBox();
            this.txtFDID = new System.Windows.Forms.TextBox();
            this.lblFDID = new System.Windows.Forms.Label();
            this.txtCertID = new System.Windows.Forms.TextBox();
            this.lblcertid = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnlhead = new System.Windows.Forms.Panel();
            this.txtintr_period = new System.Windows.Forms.TextBox();
            this.lblintr_period = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNumbers = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pnlButtons.SuspendLayout();
            this.pnlRates.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlhead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.LightGray;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnExit);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Location = new System.Drawing.Point(10, 556);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1132, 85);
            this.pnlButtons.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(609, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(382, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlRates
            // 
            this.pnlRates.BackColor = System.Drawing.Color.LightGray;
            this.pnlRates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRates.Controls.Add(this.txtFDAmount);
            this.pnlRates.Controls.Add(this.txtintr_period);
            this.pnlRates.Controls.Add(this.lblFDAmout);
            this.pnlRates.Controls.Add(this.dtpEndDate);
            this.pnlRates.Controls.Add(this.txtInterestRate);
            this.pnlRates.Controls.Add(this.lblInterstRate);
            this.pnlRates.Controls.Add(this.lblintr_period);
            this.pnlRates.Controls.Add(this.txtPeriodicInterest);
            this.pnlRates.Controls.Add(this.dtpStartDate);
            this.pnlRates.Controls.Add(this.lblPeriodicInterest);
            this.pnlRates.Controls.Add(this.lblMaturityDate);
            this.pnlRates.Controls.Add(this.cmbFDType);
            this.pnlRates.Controls.Add(this.lblStartDate);
            this.pnlRates.Controls.Add(this.lblFDType);
            this.pnlRates.Controls.Add(this.txtFinalAmount);
            this.pnlRates.Controls.Add(this.lblFinalAmount);
            this.pnlRates.Controls.Add(this.txtTotalInterest);
            this.pnlRates.Controls.Add(this.lblTotalInterest);
            this.pnlRates.Controls.Add(this.cmbDays);
            this.pnlRates.Controls.Add(this.cmbMonths);
            this.pnlRates.Controls.Add(this.lblDays);
            this.pnlRates.Controls.Add(this.lblInterestInterval);
            this.pnlRates.Controls.Add(this.lblMonths);
            this.pnlRates.Location = new System.Drawing.Point(13, 303);
            this.pnlRates.Name = "pnlRates";
            this.pnlRates.Size = new System.Drawing.Size(1131, 243);
            this.pnlRates.TabIndex = 4;
            this.pnlRates.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRates_Paint);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(459, 79);
            this.dtpEndDate.MaxDate = new System.DateTime(2023, 1, 7, 23, 15, 14, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(147, 29);
            this.dtpEndDate.TabIndex = 41;
            this.dtpEndDate.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(459, 24);
            this.dtpStartDate.MaxDate = new System.DateTime(2023, 1, 7, 23, 15, 14, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(147, 29);
            this.dtpStartDate.TabIndex = 40;
            this.dtpStartDate.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // lblMaturityDate
            // 
            this.lblMaturityDate.AutoSize = true;
            this.lblMaturityDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaturityDate.Location = new System.Drawing.Point(361, 81);
            this.lblMaturityDate.Name = "lblMaturityDate";
            this.lblMaturityDate.Size = new System.Drawing.Size(96, 24);
            this.lblMaturityDate.TabIndex = 39;
            this.lblMaturityDate.Text = "End date :";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(360, 27);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(97, 24);
            this.lblStartDate.TabIndex = 37;
            this.lblStartDate.Text = "Start date :";
            // 
            // txtFinalAmount
            // 
            this.txtFinalAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFinalAmount.Enabled = false;
            this.txtFinalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalAmount.Location = new System.Drawing.Point(138, 180);
            this.txtFinalAmount.Name = "txtFinalAmount";
            this.txtFinalAmount.ReadOnly = true;
            this.txtFinalAmount.Size = new System.Drawing.Size(147, 29);
            this.txtFinalAmount.TabIndex = 3;
            // 
            // lblFinalAmount
            // 
            this.lblFinalAmount.AutoSize = true;
            this.lblFinalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalAmount.Location = new System.Drawing.Point(3, 183);
            this.lblFinalAmount.Name = "lblFinalAmount";
            this.lblFinalAmount.Size = new System.Drawing.Size(129, 24);
            this.lblFinalAmount.TabIndex = 35;
            this.lblFinalAmount.Text = "Final amount :";
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalInterest.Enabled = false;
            this.txtTotalInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalInterest.Location = new System.Drawing.Point(459, 126);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.ReadOnly = true;
            this.txtTotalInterest.Size = new System.Drawing.Size(147, 29);
            this.txtTotalInterest.TabIndex = 2;
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterest.Location = new System.Drawing.Point(326, 129);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(126, 24);
            this.lblTotalInterest.TabIndex = 33;
            this.lblTotalInterest.Text = "Total Interest :";
            // 
            // txtPeriodicInterest
            // 
            this.txtPeriodicInterest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPeriodicInterest.Enabled = false;
            this.txtPeriodicInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodicInterest.Location = new System.Drawing.Point(836, 76);
            this.txtPeriodicInterest.Name = "txtPeriodicInterest";
            this.txtPeriodicInterest.ReadOnly = true;
            this.txtPeriodicInterest.Size = new System.Drawing.Size(147, 29);
            this.txtPeriodicInterest.TabIndex = 1;
            // 
            // lblPeriodicInterest
            // 
            this.lblPeriodicInterest.AutoSize = true;
            this.lblPeriodicInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodicInterest.Location = new System.Drawing.Point(671, 79);
            this.lblPeriodicInterest.Name = "lblPeriodicInterest";
            this.lblPeriodicInterest.Size = new System.Drawing.Size(159, 24);
            this.lblPeriodicInterest.TabIndex = 31;
            this.lblPeriodicInterest.Text = "Periodic Interest  :";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInterestRate.Enabled = false;
            this.txtInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(138, 78);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.ReadOnly = true;
            this.txtInterestRate.Size = new System.Drawing.Size(147, 29);
            this.txtInterestRate.TabIndex = 0;
            // 
            // lblInterstRate
            // 
            this.lblInterstRate.AutoSize = true;
            this.lblInterstRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterstRate.Location = new System.Drawing.Point(16, 78);
            this.lblInterstRate.Name = "lblInterstRate";
            this.lblInterstRate.Size = new System.Drawing.Size(116, 24);
            this.lblInterstRate.TabIndex = 29;
            this.lblInterstRate.Text = "Interest rate :";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.LightGray;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(13, 10);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1131, 60);
            this.pnlTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(479, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FD Master";
            // 
            // cmbMonths
            // 
            this.cmbMonths.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMonths.Enabled = false;
            this.cmbMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMonths.Location = new System.Drawing.Point(836, 24);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(68, 32);
            this.cmbMonths.TabIndex = 3;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.CausesValidation = false;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(918, 27);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(61, 24);
            this.lblDays.TabIndex = 22;
            this.lblDays.Text = "Days :";
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.CausesValidation = false;
            this.lblMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonths.Location = new System.Drawing.Point(756, 27);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(82, 24);
            this.lblMonths.TabIndex = 20;
            this.lblMonths.Text = "Months :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(59, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(136, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(373, 29);
            this.txtName.TabIndex = 2;
            // 
            // lblInterestInterval
            // 
            this.lblInterestInterval.AutoSize = true;
            this.lblInterestInterval.CausesValidation = false;
            this.lblInterestInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestInterval.Location = new System.Drawing.Point(680, 27);
            this.lblInterestInterval.Name = "lblInterestInterval";
            this.lblInterestInterval.Size = new System.Drawing.Size(75, 24);
            this.lblInterestInterval.TabIndex = 19;
            this.lblInterestInterval.Text = "Period :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(51, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 24);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Cust ID :";
            // 
            // cmbDays
            // 
            this.cmbDays.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDays.Enabled = false;
            this.cmbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDays.Location = new System.Drawing.Point(977, 24);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(68, 32);
            this.cmbDays.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(136, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(163, 29);
            this.txtID.TabIndex = 0;
            // 
            // lblFDType
            // 
            this.lblFDType.AutoSize = true;
            this.lblFDType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFDType.Location = new System.Drawing.Point(43, 29);
            this.lblFDType.Name = "lblFDType";
            this.lblFDType.Size = new System.Drawing.Size(93, 24);
            this.lblFDType.TabIndex = 14;
            this.lblFDType.Text = "FD Type :";
            // 
            // cmbFDType
            // 
            this.cmbFDType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbFDType.Enabled = false;
            this.cmbFDType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFDType.FormattingEnabled = true;
            this.cmbFDType.Items.AddRange(new object[] {
            "7 to 30 days",
            "31 to 90 days",
            "91 to 180 days",
            "181 to 365 days",
            "more than 365 days"});
            this.cmbFDType.Location = new System.Drawing.Point(138, 25);
            this.cmbFDType.Name = "cmbFDType";
            this.cmbFDType.Size = new System.Drawing.Size(147, 32);
            this.cmbFDType.TabIndex = 6;
            // 
            // lblFDAmout
            // 
            this.lblFDAmout.AutoSize = true;
            this.lblFDAmout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFDAmout.Location = new System.Drawing.Point(22, 129);
            this.lblFDAmout.Name = "lblFDAmout";
            this.lblFDAmout.Size = new System.Drawing.Size(113, 24);
            this.lblFDAmout.TabIndex = 16;
            this.lblFDAmout.Text = "FD amount :";
            // 
            // txtFDAmount
            // 
            this.txtFDAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFDAmount.Enabled = false;
            this.txtFDAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFDAmount.Location = new System.Drawing.Point(138, 127);
            this.txtFDAmount.Name = "txtFDAmount";
            this.txtFDAmount.Size = new System.Drawing.Size(147, 29);
            this.txtFDAmount.TabIndex = 5;
            // 
            // txtFDID
            // 
            this.txtFDID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFDID.Enabled = false;
            this.txtFDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFDID.Location = new System.Drawing.Point(138, 21);
            this.txtFDID.Name = "txtFDID";
            this.txtFDID.ReadOnly = true;
            this.txtFDID.Size = new System.Drawing.Size(147, 29);
            this.txtFDID.TabIndex = 5;
            // 
            // lblFDID
            // 
            this.lblFDID.AutoSize = true;
            this.lblFDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFDID.Location = new System.Drawing.Point(64, 24);
            this.lblFDID.Name = "lblFDID";
            this.lblFDID.Size = new System.Drawing.Size(67, 24);
            this.lblFDID.TabIndex = 29;
            this.lblFDID.Text = "FD ID :";
            // 
            // txtCertID
            // 
            this.txtCertID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCertID.Enabled = false;
            this.txtCertID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCertID.Location = new System.Drawing.Point(497, 24);
            this.txtCertID.Name = "txtCertID";
            this.txtCertID.ReadOnly = true;
            this.txtCertID.Size = new System.Drawing.Size(147, 29);
            this.txtCertID.TabIndex = 6;
            this.txtCertID.TextChanged += new System.EventHandler(this.txtCertID_TextChanged);
            // 
            // lblcertid
            // 
            this.lblcertid.AutoSize = true;
            this.lblcertid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcertid.Location = new System.Drawing.Point(369, 24);
            this.lblcertid.Name = "lblcertid";
            this.lblcertid.Size = new System.Drawing.Size(123, 24);
            this.lblcertid.TabIndex = 47;
            this.lblcertid.Text = "Certificate ID :";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(379, 23);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(130, 29);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pnlhead
            // 
            this.pnlhead.AutoSize = true;
            this.pnlhead.BackColor = System.Drawing.Color.LightGray;
            this.pnlhead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlhead.Controls.Add(this.btnLoad);
            this.pnlhead.Controls.Add(this.txtID);
            this.pnlhead.Controls.Add(this.lblID);
            this.pnlhead.Controls.Add(this.txtName);
            this.pnlhead.Controls.Add(this.lblName);
            this.pnlhead.Location = new System.Drawing.Point(13, 80);
            this.pnlhead.Name = "pnlhead";
            this.pnlhead.Size = new System.Drawing.Size(738, 132);
            this.pnlhead.TabIndex = 3;
            // 
            // txtintr_period
            // 
            this.txtintr_period.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtintr_period.Enabled = false;
            this.txtintr_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtintr_period.Location = new System.Drawing.Point(459, 180);
            this.txtintr_period.Name = "txtintr_period";
            this.txtintr_period.ReadOnly = true;
            this.txtintr_period.Size = new System.Drawing.Size(147, 29);
            this.txtintr_period.TabIndex = 48;
            // 
            // lblintr_period
            // 
            this.lblintr_period.AutoSize = true;
            this.lblintr_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintr_period.Location = new System.Drawing.Point(318, 183);
            this.lblintr_period.Name = "lblintr_period";
            this.lblintr_period.Size = new System.Drawing.Size(139, 24);
            this.lblintr_period.TabIndex = 49;
            this.lblintr_period.Text = "Interest period :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Location = new System.Drawing.Point(746, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 215);
            this.panel1.TabIndex = 7;
            // 
            // pnlNumbers
            // 
            this.pnlNumbers.BackColor = System.Drawing.Color.LightGray;
            this.pnlNumbers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNumbers.Controls.Add(this.lblcertid);
            this.pnlNumbers.Controls.Add(this.txtFDID);
            this.pnlNumbers.Controls.Add(this.txtCertID);
            this.pnlNumbers.Controls.Add(this.lblFDID);
            this.pnlNumbers.Location = new System.Drawing.Point(13, 220);
            this.pnlNumbers.Name = "pnlNumbers";
            this.pnlNumbers.Size = new System.Drawing.Size(724, 75);
            this.pnlNumbers.TabIndex = 8;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(13, 12);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(367, 188);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // FD_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 648);
            this.Controls.Add(this.pnlNumbers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlRates);
            this.Controls.Add(this.pnlhead);
            this.Controls.Add(this.pnlTitle);
            this.Name = "FD_master";
            this.Text = "FD_master";
            this.pnlButtons.ResumeLayout(false);
            this.pnlRates.ResumeLayout(false);
            this.pnlRates.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlhead.ResumeLayout(false);
            this.pnlhead.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlNumbers.ResumeLayout(false);
            this.pnlNumbers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlRates;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblMaturityDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtFinalAmount;
        private System.Windows.Forms.Label lblFinalAmount;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.TextBox txtPeriodicInterest;
        private System.Windows.Forms.Label lblPeriodicInterest;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblInterstRate;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblInterestInterval;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblFDType;
        private System.Windows.Forms.ComboBox cmbFDType;
        private System.Windows.Forms.Label lblFDAmout;
        private System.Windows.Forms.TextBox txtFDAmount;
        private System.Windows.Forms.TextBox txtFDID;
        private System.Windows.Forms.Label lblFDID;
        private System.Windows.Forms.TextBox txtCertID;
        private System.Windows.Forms.Label lblcertid;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel pnlhead;
        private System.Windows.Forms.TextBox txtintr_period;
        private System.Windows.Forms.Label lblintr_period;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNumbers;
        private System.Windows.Forms.DataGridView dgvList;
    }
}