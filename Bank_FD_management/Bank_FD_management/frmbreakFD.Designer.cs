namespace Bank_FD_management
{
    partial class frmbreakFD
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBreak = new System.Windows.Forms.Panel();
            this.txtpen_intr = new System.Windows.Forms.TextBox();
            this.lblPenaltyInterest = new System.Windows.Forms.Label();
            this.txtWith_amt = new System.Windows.Forms.TextBox();
            this.lblWithdrawableAmount = new System.Windows.Forms.Label();
            this.dtpWith_date = new System.Windows.Forms.DateTimePicker();
            this.lblWithDate = new System.Windows.Forms.Label();
            this.txtFDStatus = new System.Windows.Forms.TextBox();
            this.lblDFStatus = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCertID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlFetch = new System.Windows.Forms.Panel();
            this.rbdBreakFD = new System.Windows.Forms.RadioButton();
            this.rbdPayInterest = new System.Windows.Forms.RadioButton();
            this.txtFD_ID = new System.Windows.Forms.TextBox();
            this.lblFD_ID = new System.Windows.Forms.Label();
            this.btnFetchDetails = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMid1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtelapsed_days = new System.Windows.Forms.TextBox();
            this.txtFDAmount = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblMaturityDate = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblFDAmount = new System.Windows.Forms.Label();
            this.lblFinalAmount = new System.Windows.Forms.Label();
            this.dtpMatureDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtFinalAmount = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtnterestRate = new System.Windows.Forms.TextBox();
            this.txtpayable_intr = new System.Windows.Forms.TextBox();
            this.lblPayableInterest = new System.Windows.Forms.Label();
            this.txtPaid_intr = new System.Windows.Forms.TextBox();
            this.lblPaidInterest = new System.Windows.Forms.Label();
            this.txtTotalInterest = new System.Windows.Forms.TextBox();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.pnlMid2 = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.pnlBreak.SuspendLayout();
            this.pnlFetch.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlMid1.SuspendLayout();
            this.pnlMid2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.LightGray;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(13, 12);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1101, 60);
            this.pnlTitle.TabIndex = 34;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(427, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(274, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FD Transection";
            // 
            // pnlBreak
            // 
            this.pnlBreak.BackColor = System.Drawing.Color.LightGray;
            this.pnlBreak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBreak.Controls.Add(this.txtpen_intr);
            this.pnlBreak.Controls.Add(this.lblPenaltyInterest);
            this.pnlBreak.Controls.Add(this.txtWith_amt);
            this.pnlBreak.Controls.Add(this.lblWithdrawableAmount);
            this.pnlBreak.Controls.Add(this.dtpWith_date);
            this.pnlBreak.Controls.Add(this.lblWithDate);
            this.pnlBreak.Location = new System.Drawing.Point(571, 384);
            this.pnlBreak.Name = "pnlBreak";
            this.pnlBreak.Size = new System.Drawing.Size(543, 173);
            this.pnlBreak.TabIndex = 1;
            // 
            // txtpen_intr
            // 
            this.txtpen_intr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtpen_intr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpen_intr.Location = new System.Drawing.Point(222, 65);
            this.txtpen_intr.Name = "txtpen_intr";
            this.txtpen_intr.Size = new System.Drawing.Size(177, 29);
            this.txtpen_intr.TabIndex = 64;
            // 
            // lblPenaltyInterest
            // 
            this.lblPenaltyInterest.AutoSize = true;
            this.lblPenaltyInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenaltyInterest.Location = new System.Drawing.Point(70, 68);
            this.lblPenaltyInterest.Name = "lblPenaltyInterest";
            this.lblPenaltyInterest.Size = new System.Drawing.Size(146, 24);
            this.lblPenaltyInterest.TabIndex = 65;
            this.lblPenaltyInterest.Text = "Penalty Interest :";
            // 
            // txtWith_amt
            // 
            this.txtWith_amt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtWith_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWith_amt.Location = new System.Drawing.Point(222, 113);
            this.txtWith_amt.Name = "txtWith_amt";
            this.txtWith_amt.Size = new System.Drawing.Size(177, 29);
            this.txtWith_amt.TabIndex = 62;
            // 
            // lblWithdrawableAmount
            // 
            this.lblWithdrawableAmount.AutoSize = true;
            this.lblWithdrawableAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawableAmount.Location = new System.Drawing.Point(14, 115);
            this.lblWithdrawableAmount.Name = "lblWithdrawableAmount";
            this.lblWithdrawableAmount.Size = new System.Drawing.Size(202, 24);
            this.lblWithdrawableAmount.TabIndex = 63;
            this.lblWithdrawableAmount.Text = "Withdrawable amount :";
            // 
            // dtpWith_date
            // 
            this.dtpWith_date.Enabled = false;
            this.dtpWith_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWith_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWith_date.Location = new System.Drawing.Point(222, 19);
            this.dtpWith_date.MaxDate = new System.DateTime(2023, 1, 7, 23, 15, 14, 0);
            this.dtpWith_date.Name = "dtpWith_date";
            this.dtpWith_date.Size = new System.Drawing.Size(177, 29);
            this.dtpWith_date.TabIndex = 61;
            this.dtpWith_date.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // lblWithDate
            // 
            this.lblWithDate.AutoSize = true;
            this.lblWithDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithDate.Location = new System.Drawing.Point(77, 22);
            this.lblWithDate.Name = "lblWithDate";
            this.lblWithDate.Size = new System.Drawing.Size(139, 24);
            this.lblWithDate.TabIndex = 60;
            this.lblWithDate.Text = "Withdraw date :";
            // 
            // txtFDStatus
            // 
            this.txtFDStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFDStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFDStatus.Location = new System.Drawing.Point(909, 62);
            this.txtFDStatus.Name = "txtFDStatus";
            this.txtFDStatus.Size = new System.Drawing.Size(147, 29);
            this.txtFDStatus.TabIndex = 4;
            // 
            // lblDFStatus
            // 
            this.lblDFStatus.AutoSize = true;
            this.lblDFStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDFStatus.Location = new System.Drawing.Point(806, 65);
            this.lblDFStatus.Name = "lblDFStatus";
            this.lblDFStatus.Size = new System.Drawing.Size(100, 24);
            this.lblDFStatus.TabIndex = 52;
            this.lblDFStatus.Text = "FD Status :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(172, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(323, 29);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(93, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name :";
            // 
            // txtCertID
            // 
            this.txtCertID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCertID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCertID.Location = new System.Drawing.Point(172, 14);
            this.txtCertID.Name = "txtCertID";
            this.txtCertID.Size = new System.Drawing.Size(178, 29);
            this.txtCertID.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(43, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(123, 24);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "Certificate ID :";
            // 
            // pnlFetch
            // 
            this.pnlFetch.BackColor = System.Drawing.Color.LightGray;
            this.pnlFetch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFetch.Controls.Add(this.rbdBreakFD);
            this.pnlFetch.Controls.Add(this.rbdPayInterest);
            this.pnlFetch.Controls.Add(this.txtFD_ID);
            this.pnlFetch.Controls.Add(this.lblFD_ID);
            this.pnlFetch.Controls.Add(this.btnFetchDetails);
            this.pnlFetch.Controls.Add(this.txtCertID);
            this.pnlFetch.Controls.Add(this.lblID);
            this.pnlFetch.Controls.Add(this.txtName);
            this.pnlFetch.Controls.Add(this.txtFDStatus);
            this.pnlFetch.Controls.Add(this.lblDFStatus);
            this.pnlFetch.Controls.Add(this.lblName);
            this.pnlFetch.Location = new System.Drawing.Point(13, 83);
            this.pnlFetch.Name = "pnlFetch";
            this.pnlFetch.Size = new System.Drawing.Size(1101, 110);
            this.pnlFetch.TabIndex = 0;
            // 
            // rbdBreakFD
            // 
            this.rbdBreakFD.AutoSize = true;
            this.rbdBreakFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdBreakFD.Location = new System.Drawing.Point(676, 18);
            this.rbdBreakFD.Name = "rbdBreakFD";
            this.rbdBreakFD.Size = new System.Drawing.Size(95, 24);
            this.rbdBreakFD.TabIndex = 82;
            this.rbdBreakFD.TabStop = true;
            this.rbdBreakFD.Text = "Break FD";
            this.rbdBreakFD.UseVisualStyleBackColor = true;
            this.rbdBreakFD.CheckedChanged += new System.EventHandler(this.rbdBreakFD_CheckedChanged);
            // 
            // rbdPayInterest
            // 
            this.rbdPayInterest.AutoSize = true;
            this.rbdPayInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdPayInterest.Location = new System.Drawing.Point(542, 18);
            this.rbdPayInterest.Name = "rbdPayInterest";
            this.rbdPayInterest.Size = new System.Drawing.Size(112, 24);
            this.rbdPayInterest.TabIndex = 80;
            this.rbdPayInterest.TabStop = true;
            this.rbdPayInterest.Text = "Pay Interest";
            this.rbdPayInterest.UseVisualStyleBackColor = true;
            this.rbdPayInterest.CheckedChanged += new System.EventHandler(this.rbdPayInterest_CheckedChanged);
            // 
            // txtFD_ID
            // 
            this.txtFD_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFD_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFD_ID.Location = new System.Drawing.Point(909, 16);
            this.txtFD_ID.Name = "txtFD_ID";
            this.txtFD_ID.Size = new System.Drawing.Size(147, 29);
            this.txtFD_ID.TabIndex = 53;
            // 
            // lblFD_ID
            // 
            this.lblFD_ID.AutoSize = true;
            this.lblFD_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFD_ID.Location = new System.Drawing.Point(839, 19);
            this.lblFD_ID.Name = "lblFD_ID";
            this.lblFD_ID.Size = new System.Drawing.Size(67, 24);
            this.lblFD_ID.TabIndex = 54;
            this.lblFD_ID.Text = "FD ID :";
            // 
            // btnFetchDetails
            // 
            this.btnFetchDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchDetails.Location = new System.Drawing.Point(368, 11);
            this.btnFetchDetails.Name = "btnFetchDetails";
            this.btnFetchDetails.Size = new System.Drawing.Size(127, 34);
            this.btnFetchDetails.TabIndex = 1;
            this.btnFetchDetails.Text = "Fetch Details";
            this.btnFetchDetails.UseVisualStyleBackColor = true;
            this.btnFetchDetails.Click += new System.EventHandler(this.btnFetchDetails_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.LightGray;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnExit);
            this.pnlButtons.Controls.Add(this.btnBreak);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Location = new System.Drawing.Point(13, 568);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1102, 94);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(676, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBreak.Location = new System.Drawing.Point(457, 27);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(197, 38);
            this.btnBreak.TabIndex = 0;
            this.btnBreak.Text = "Break";
            this.btnBreak.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(299, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlMid1
            // 
            this.pnlMid1.BackColor = System.Drawing.Color.LightGray;
            this.pnlMid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMid1.Controls.Add(this.label1);
            this.pnlMid1.Controls.Add(this.txtelapsed_days);
            this.pnlMid1.Controls.Add(this.txtFDAmount);
            this.pnlMid1.Controls.Add(this.lblPeriod);
            this.pnlMid1.Controls.Add(this.lblMaturityDate);
            this.pnlMid1.Controls.Add(this.txtPeriod);
            this.pnlMid1.Controls.Add(this.dtpStartDate);
            this.pnlMid1.Controls.Add(this.lblFDAmount);
            this.pnlMid1.Controls.Add(this.lblFinalAmount);
            this.pnlMid1.Controls.Add(this.dtpMatureDate);
            this.pnlMid1.Controls.Add(this.lblStartDate);
            this.pnlMid1.Controls.Add(this.txtFinalAmount);
            this.pnlMid1.Controls.Add(this.lblInterestRate);
            this.pnlMid1.Controls.Add(this.txtnterestRate);
            this.pnlMid1.Location = new System.Drawing.Point(13, 204);
            this.pnlMid1.Name = "pnlMid1";
            this.pnlMid1.Size = new System.Drawing.Size(1101, 169);
            this.pnlMid1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(728, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 80;
            this.label1.Text = "Days elapsed :";
            // 
            // txtelapsed_days
            // 
            this.txtelapsed_days.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtelapsed_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtelapsed_days.Location = new System.Drawing.Point(865, 88);
            this.txtelapsed_days.Name = "txtelapsed_days";
            this.txtelapsed_days.Size = new System.Drawing.Size(181, 29);
            this.txtelapsed_days.TabIndex = 79;
            // 
            // txtFDAmount
            // 
            this.txtFDAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFDAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFDAmount.Location = new System.Drawing.Point(172, 33);
            this.txtFDAmount.Name = "txtFDAmount";
            this.txtFDAmount.Size = new System.Drawing.Size(178, 29);
            this.txtFDAmount.TabIndex = 65;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(783, 37);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(75, 24);
            this.lblPeriod.TabIndex = 73;
            this.lblPeriod.Text = "Period :";
            // 
            // lblMaturityDate
            // 
            this.lblMaturityDate.AutoSize = true;
            this.lblMaturityDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaturityDate.Location = new System.Drawing.Point(390, 88);
            this.lblMaturityDate.Name = "lblMaturityDate";
            this.lblMaturityDate.Size = new System.Drawing.Size(125, 24);
            this.lblMaturityDate.TabIndex = 71;
            this.lblMaturityDate.Text = "Maturity date :";
            // 
            // txtPeriod
            // 
            this.txtPeriod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriod.Location = new System.Drawing.Point(864, 36);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(181, 29);
            this.txtPeriod.TabIndex = 72;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(522, 35);
            this.dtpStartDate.MaxDate = new System.DateTime(2023, 1, 7, 23, 15, 14, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(180, 29);
            this.dtpStartDate.TabIndex = 78;
            this.dtpStartDate.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // lblFDAmount
            // 
            this.lblFDAmount.AutoSize = true;
            this.lblFDAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFDAmount.Location = new System.Drawing.Point(54, 35);
            this.lblFDAmount.Name = "lblFDAmount";
            this.lblFDAmount.Size = new System.Drawing.Size(113, 24);
            this.lblFDAmount.TabIndex = 69;
            this.lblFDAmount.Text = "FD amount :";
            // 
            // lblFinalAmount
            // 
            this.lblFinalAmount.AutoSize = true;
            this.lblFinalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalAmount.Location = new System.Drawing.Point(38, 87);
            this.lblFinalAmount.Name = "lblFinalAmount";
            this.lblFinalAmount.Size = new System.Drawing.Size(129, 24);
            this.lblFinalAmount.TabIndex = 76;
            this.lblFinalAmount.Text = "Final amount :";
            // 
            // dtpMatureDate
            // 
            this.dtpMatureDate.Enabled = false;
            this.dtpMatureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMatureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMatureDate.Location = new System.Drawing.Point(522, 87);
            this.dtpMatureDate.MaxDate = new System.DateTime(2023, 1, 7, 23, 15, 14, 0);
            this.dtpMatureDate.Name = "dtpMatureDate";
            this.dtpMatureDate.Size = new System.Drawing.Size(180, 29);
            this.dtpMatureDate.TabIndex = 77;
            this.dtpMatureDate.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(392, 35);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(123, 24);
            this.lblStartDate.TabIndex = 70;
            this.lblStartDate.Text = "Starting date :";
            // 
            // txtFinalAmount
            // 
            this.txtFinalAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFinalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalAmount.Location = new System.Drawing.Point(173, 85);
            this.txtFinalAmount.Name = "txtFinalAmount";
            this.txtFinalAmount.Size = new System.Drawing.Size(177, 29);
            this.txtFinalAmount.TabIndex = 68;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.Location = new System.Drawing.Point(51, 137);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(116, 24);
            this.lblInterestRate.TabIndex = 74;
            this.lblInterestRate.Text = "Interest rate :";
            // 
            // txtnterestRate
            // 
            this.txtnterestRate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtnterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnterestRate.Location = new System.Drawing.Point(173, 135);
            this.txtnterestRate.Name = "txtnterestRate";
            this.txtnterestRate.Size = new System.Drawing.Size(177, 29);
            this.txtnterestRate.TabIndex = 66;
            // 
            // txtpayable_intr
            // 
            this.txtpayable_intr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtpayable_intr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpayable_intr.Location = new System.Drawing.Point(174, 118);
            this.txtpayable_intr.Name = "txtpayable_intr";
            this.txtpayable_intr.Size = new System.Drawing.Size(178, 29);
            this.txtpayable_intr.TabIndex = 83;
            // 
            // lblPayableInterest
            // 
            this.lblPayableInterest.AutoSize = true;
            this.lblPayableInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayableInterest.Location = new System.Drawing.Point(20, 118);
            this.lblPayableInterest.Name = "lblPayableInterest";
            this.lblPayableInterest.Size = new System.Drawing.Size(152, 24);
            this.lblPayableInterest.TabIndex = 84;
            this.lblPayableInterest.Text = "Payable interest :";
            // 
            // txtPaid_intr
            // 
            this.txtPaid_intr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPaid_intr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid_intr.Location = new System.Drawing.Point(175, 68);
            this.txtPaid_intr.Name = "txtPaid_intr";
            this.txtPaid_intr.Size = new System.Drawing.Size(177, 29);
            this.txtPaid_intr.TabIndex = 79;
            // 
            // lblPaidInterest
            // 
            this.lblPaidInterest.AutoSize = true;
            this.lblPaidInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidInterest.Location = new System.Drawing.Point(47, 69);
            this.lblPaidInterest.Name = "lblPaidInterest";
            this.lblPaidInterest.Size = new System.Drawing.Size(122, 24);
            this.lblPaidInterest.TabIndex = 81;
            this.lblPaidInterest.Text = "Paid interest :";
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalInterest.Location = new System.Drawing.Point(175, 20);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.Size = new System.Drawing.Size(177, 29);
            this.txtTotalInterest.TabIndex = 67;
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterest.Location = new System.Drawing.Point(38, 20);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(126, 24);
            this.lblTotalInterest.TabIndex = 75;
            this.lblTotalInterest.Text = "Total Interest :";
            // 
            // pnlMid2
            // 
            this.pnlMid2.BackColor = System.Drawing.Color.LightGray;
            this.pnlMid2.Controls.Add(this.txtpayable_intr);
            this.pnlMid2.Controls.Add(this.txtTotalInterest);
            this.pnlMid2.Controls.Add(this.lblTotalInterest);
            this.pnlMid2.Controls.Add(this.lblPayableInterest);
            this.pnlMid2.Controls.Add(this.txtPaid_intr);
            this.pnlMid2.Controls.Add(this.lblPaidInterest);
            this.pnlMid2.Location = new System.Drawing.Point(13, 371);
            this.pnlMid2.Name = "pnlMid2";
            this.pnlMid2.Size = new System.Drawing.Size(546, 186);
            this.pnlMid2.TabIndex = 36;
            // 
            // frmbreakFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 674);
            this.Controls.Add(this.pnlMid2);
            this.Controls.Add(this.pnlMid1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlFetch);
            this.Controls.Add(this.pnlBreak);
            this.Controls.Add(this.pnlTitle);
            this.Name = "frmbreakFD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FD Break";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlBreak.ResumeLayout(false);
            this.pnlBreak.PerformLayout();
            this.pnlFetch.ResumeLayout(false);
            this.pnlFetch.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlMid1.ResumeLayout(false);
            this.pnlMid1.PerformLayout();
            this.pnlMid2.ResumeLayout(false);
            this.pnlMid2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBreak;
        private System.Windows.Forms.TextBox txtCertID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlFetch;
        private System.Windows.Forms.Button btnFetchDetails;
        private System.Windows.Forms.TextBox txtFDStatus;
        private System.Windows.Forms.Label lblDFStatus;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWithDate;
        private System.Windows.Forms.TextBox txtFD_ID;
        private System.Windows.Forms.Label lblFD_ID;
        private System.Windows.Forms.DateTimePicker dtpWith_date;
        private System.Windows.Forms.TextBox txtpen_intr;
        private System.Windows.Forms.Label lblPenaltyInterest;
        private System.Windows.Forms.TextBox txtWith_amt;
        private System.Windows.Forms.Label lblWithdrawableAmount;
        private System.Windows.Forms.Panel pnlMid1;
        private System.Windows.Forms.RadioButton rbdBreakFD;
        private System.Windows.Forms.RadioButton rbdPayInterest;
        private System.Windows.Forms.TextBox txtFDAmount;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblMaturityDate;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblFDAmount;
        private System.Windows.Forms.Label lblFinalAmount;
        private System.Windows.Forms.DateTimePicker dtpMatureDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtFinalAmount;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtnterestRate;
        private System.Windows.Forms.TextBox txtpayable_intr;
        private System.Windows.Forms.Label lblPayableInterest;
        private System.Windows.Forms.TextBox txtPaid_intr;
        private System.Windows.Forms.Label lblPaidInterest;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Panel pnlMid2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtelapsed_days;
    }
}