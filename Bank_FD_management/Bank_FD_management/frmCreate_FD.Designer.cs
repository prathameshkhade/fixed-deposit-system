﻿namespace Bank_FD_management
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.grprdb = new System.Windows.Forms.GroupBox();
            this.rdbOnMaturity = new System.Windows.Forms.RadioButton();
            this.lblInterest = new System.Windows.Forms.Label();
            this.rdbMonthly = new System.Windows.Forms.RadioButton();
            this.rdbQuaterly = new System.Windows.Forms.RadioButton();
            this.rdbHalfYearly = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblcertid = new System.Windows.Forms.Label();
            this.txtCertID = new System.Windows.Forms.TextBox();
            this.lblFDID = new System.Windows.Forms.Label();
            this.txtFDID = new System.Windows.Forms.TextBox();
            this.txtFDAmount = new System.Windows.Forms.TextBox();
            this.lblFDAmout = new System.Windows.Forms.Label();
            this.cmbFDType = new System.Windows.Forms.ComboBox();
            this.lblFDType = new System.Windows.Forms.Label();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.lblInterestInterval = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblInterstRate = new System.Windows.Forms.Label();
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlTitle.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.grprdb.SuspendLayout();
            this.pnlRates.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.LightGray;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(17, 12);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1507, 93);
            this.pnlTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(640, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create FD";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(60, 85);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(163, 85);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(564, 34);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(49, 31);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(102, 29);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Cust ID :";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(163, 27);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(263, 34);
            this.txtID.TabIndex = 0;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // pnlDetails
            // 
            this.pnlDetails.AutoSize = true;
            this.pnlDetails.BackColor = System.Drawing.Color.LightGray;
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDetails.Controls.Add(this.grprdb);
            this.pnlDetails.Controls.Add(this.btnLoad);
            this.pnlDetails.Controls.Add(this.lblcertid);
            this.pnlDetails.Controls.Add(this.txtCertID);
            this.pnlDetails.Controls.Add(this.lblFDID);
            this.pnlDetails.Controls.Add(this.txtFDID);
            this.pnlDetails.Controls.Add(this.txtFDAmount);
            this.pnlDetails.Controls.Add(this.lblFDAmout);
            this.pnlDetails.Controls.Add(this.cmbFDType);
            this.pnlDetails.Controls.Add(this.lblFDType);
            this.pnlDetails.Controls.Add(this.txtID);
            this.pnlDetails.Controls.Add(this.cmbDays);
            this.pnlDetails.Controls.Add(this.lblID);
            this.pnlDetails.Controls.Add(this.lblInterestInterval);
            this.pnlDetails.Controls.Add(this.txtName);
            this.pnlDetails.Controls.Add(this.lblName);
            this.pnlDetails.Controls.Add(this.lblMonths);
            this.pnlDetails.Controls.Add(this.lblDays);
            this.pnlDetails.Controls.Add(this.cmbMonths);
            this.pnlDetails.Location = new System.Drawing.Point(17, 116);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(1507, 403);
            this.pnlDetails.TabIndex = 0;
            // 
            // grprdb
            // 
            this.grprdb.Controls.Add(this.rdbOnMaturity);
            this.grprdb.Controls.Add(this.lblInterest);
            this.grprdb.Controls.Add(this.rdbMonthly);
            this.grprdb.Controls.Add(this.rdbQuaterly);
            this.grprdb.Controls.Add(this.rdbHalfYearly);
            this.grprdb.Location = new System.Drawing.Point(71, 316);
            this.grprdb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grprdb.Name = "grprdb";
            this.grprdb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grprdb.Size = new System.Drawing.Size(993, 65);
            this.grprdb.TabIndex = 48;
            this.grprdb.TabStop = false;
            // 
            // rdbOnMaturity
            // 
            this.rdbOnMaturity.AutoSize = true;
            this.rdbOnMaturity.Enabled = false;
            this.rdbOnMaturity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOnMaturity.Location = new System.Drawing.Point(631, 20);
            this.rdbOnMaturity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbOnMaturity.Name = "rdbOnMaturity";
            this.rdbOnMaturity.Size = new System.Drawing.Size(312, 33);
            this.rdbOnMaturity.TabIndex = 10;
            this.rdbOnMaturity.TabStop = true;
            this.rdbOnMaturity.Text = "Interest payout on maturity";
            this.rdbOnMaturity.UseVisualStyleBackColor = true;
            this.rdbOnMaturity.CheckedChanged += new System.EventHandler(this.rdbOnMaturity_CheckedChanged);
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.CausesValidation = false;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(45, 22);
            this.lblInterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(104, 29);
            this.lblInterest.TabIndex = 24;
            this.lblInterest.Text = "interest :";
            // 
            // rdbMonthly
            // 
            this.rdbMonthly.AutoSize = true;
            this.rdbMonthly.Enabled = false;
            this.rdbMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMonthly.Location = new System.Drawing.Point(160, 20);
            this.rdbMonthly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbMonthly.Name = "rdbMonthly";
            this.rdbMonthly.Size = new System.Drawing.Size(117, 33);
            this.rdbMonthly.TabIndex = 7;
            this.rdbMonthly.TabStop = true;
            this.rdbMonthly.Text = "Monthly";
            this.rdbMonthly.UseVisualStyleBackColor = true;
            this.rdbMonthly.CheckedChanged += new System.EventHandler(this.rdbMonthly_CheckedChanged);
            // 
            // rdbQuaterly
            // 
            this.rdbQuaterly.AutoSize = true;
            this.rdbQuaterly.Enabled = false;
            this.rdbQuaterly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbQuaterly.Location = new System.Drawing.Point(305, 20);
            this.rdbQuaterly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbQuaterly.Name = "rdbQuaterly";
            this.rdbQuaterly.Size = new System.Drawing.Size(132, 33);
            this.rdbQuaterly.TabIndex = 8;
            this.rdbQuaterly.TabStop = true;
            this.rdbQuaterly.Text = "Quarterly";
            this.rdbQuaterly.UseVisualStyleBackColor = true;
            this.rdbQuaterly.CheckedChanged += new System.EventHandler(this.rdbQuaterly_CheckedChanged);
            // 
            // rdbHalfYearly
            // 
            this.rdbHalfYearly.AutoSize = true;
            this.rdbHalfYearly.Enabled = false;
            this.rdbHalfYearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHalfYearly.Location = new System.Drawing.Point(460, 20);
            this.rdbHalfYearly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbHalfYearly.Name = "rdbHalfYearly";
            this.rdbHalfYearly.Size = new System.Drawing.Size(145, 33);
            this.rdbHalfYearly.TabIndex = 9;
            this.rdbHalfYearly.TabStop = true;
            this.rdbHalfYearly.Text = "Half yearly";
            this.rdbHalfYearly.UseVisualStyleBackColor = true;
            this.rdbHalfYearly.CheckedChanged += new System.EventHandler(this.rdbHalfYearly_CheckedChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(463, 27);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(173, 33);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblcertid
            // 
            this.lblcertid.AutoSize = true;
            this.lblcertid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcertid.Location = new System.Drawing.Point(992, 89);
            this.lblcertid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcertid.Name = "lblcertid";
            this.lblcertid.Size = new System.Drawing.Size(162, 29);
            this.lblcertid.TabIndex = 47;
            this.lblcertid.Text = "Certificate ID :";
            // 
            // txtCertID
            // 
            this.txtCertID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCertID.Enabled = false;
            this.txtCertID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCertID.Location = new System.Drawing.Point(1164, 81);
            this.txtCertID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCertID.Name = "txtCertID";
            this.txtCertID.ReadOnly = true;
            this.txtCertID.Size = new System.Drawing.Size(263, 34);
            this.txtCertID.TabIndex = 6;
            // 
            // lblFDID
            // 
            this.lblFDID.AutoSize = true;
            this.lblFDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFDID.Location = new System.Drawing.Point(1067, 31);
            this.lblFDID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFDID.Name = "lblFDID";
            this.lblFDID.Size = new System.Drawing.Size(86, 29);
            this.lblFDID.TabIndex = 29;
            this.lblFDID.Text = "FD ID :";
            // 
            // txtFDID
            // 
            this.txtFDID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFDID.Enabled = false;
            this.txtFDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFDID.Location = new System.Drawing.Point(1164, 27);
            this.txtFDID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFDID.Name = "txtFDID";
            this.txtFDID.ReadOnly = true;
            this.txtFDID.Size = new System.Drawing.Size(263, 34);
            this.txtFDID.TabIndex = 5;
            // 
            // txtFDAmount
            // 
            this.txtFDAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFDAmount.Enabled = false;
            this.txtFDAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFDAmount.Location = new System.Drawing.Point(163, 210);
            this.txtFDAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFDAmount.Name = "txtFDAmount";
            this.txtFDAmount.Size = new System.Drawing.Size(269, 34);
            this.txtFDAmount.TabIndex = 5;
            this.txtFDAmount.TextChanged += new System.EventHandler(this.txtFDAmount_TextChanged);
            this.txtFDAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFDAmount_KeyPress);
            // 
            // lblFDAmout
            // 
            this.lblFDAmout.AutoSize = true;
            this.lblFDAmout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFDAmout.Location = new System.Drawing.Point(4, 214);
            this.lblFDAmout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFDAmout.Name = "lblFDAmout";
            this.lblFDAmout.Size = new System.Drawing.Size(142, 29);
            this.lblFDAmout.TabIndex = 16;
            this.lblFDAmout.Text = "FD amount :";
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
            this.cmbFDType.Location = new System.Drawing.Point(163, 270);
            this.cmbFDType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFDType.Name = "cmbFDType";
            this.cmbFDType.Size = new System.Drawing.Size(269, 37);
            this.cmbFDType.TabIndex = 6;
            this.cmbFDType.SelectedIndexChanged += new System.EventHandler(this.cmbFDType_SelectedIndexChanged);
            // 
            // lblFDType
            // 
            this.lblFDType.AutoSize = true;
            this.lblFDType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFDType.Location = new System.Drawing.Point(31, 273);
            this.lblFDType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFDType.Name = "lblFDType";
            this.lblFDType.Size = new System.Drawing.Size(118, 29);
            this.lblFDType.TabIndex = 14;
            this.lblFDType.Text = "FD Type :";
            // 
            // cmbDays
            // 
            this.cmbDays.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbDays.Location = new System.Drawing.Point(525, 148);
            this.cmbDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(121, 37);
            this.cmbDays.TabIndex = 4;
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            this.cmbDays.TextChanged += new System.EventHandler(this.cmbDays_TextChanged);
            // 
            // lblInterestInterval
            // 
            this.lblInterestInterval.AutoSize = true;
            this.lblInterestInterval.CausesValidation = false;
            this.lblInterestInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestInterval.Location = new System.Drawing.Point(48, 151);
            this.lblInterestInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterestInterval.Name = "lblInterestInterval";
            this.lblInterestInterval.Size = new System.Drawing.Size(97, 29);
            this.lblInterestInterval.TabIndex = 19;
            this.lblInterestInterval.Text = "Period :";
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.CausesValidation = false;
            this.lblMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonths.Location = new System.Drawing.Point(163, 151);
            this.lblMonths.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(103, 29);
            this.lblMonths.TabIndex = 20;
            this.lblMonths.Text = "Months :";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.CausesValidation = false;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(436, 151);
            this.lblDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(78, 29);
            this.lblDays.TabIndex = 22;
            this.lblDays.Text = "Days :";
            // 
            // cmbMonths
            // 
            this.cmbMonths.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbMonths.Location = new System.Drawing.Point(280, 148);
            this.cmbMonths.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(105, 37);
            this.cmbMonths.TabIndex = 3;
            this.cmbMonths.SelectedIndexChanged += new System.EventHandler(this.cmbMonths_SelectedIndexChanged);
            this.cmbMonths.TextChanged += new System.EventHandler(this.cmbMonths_TextChanged);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInterestRate.Enabled = false;
            this.txtInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(237, 28);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.ReadOnly = true;
            this.txtInterestRate.Size = new System.Drawing.Size(195, 34);
            this.txtInterestRate.TabIndex = 0;
            this.txtInterestRate.TextChanged += new System.EventHandler(this.txtInterestRate_TextChanged);
            // 
            // lblInterstRate
            // 
            this.lblInterstRate.AutoSize = true;
            this.lblInterstRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterstRate.Location = new System.Drawing.Point(75, 28);
            this.lblInterstRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterstRate.Name = "lblInterstRate";
            this.lblInterstRate.Size = new System.Drawing.Size(151, 29);
            this.lblInterstRate.TabIndex = 29;
            this.lblInterstRate.Text = "Interest rate :";
            // 
            // pnlRates
            // 
            this.pnlRates.BackColor = System.Drawing.Color.LightGray;
            this.pnlRates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRates.Controls.Add(this.dtpEndDate);
            this.pnlRates.Controls.Add(this.dtpStartDate);
            this.pnlRates.Controls.Add(this.lblMaturityDate);
            this.pnlRates.Controls.Add(this.lblStartDate);
            this.pnlRates.Controls.Add(this.txtFinalAmount);
            this.pnlRates.Controls.Add(this.lblFinalAmount);
            this.pnlRates.Controls.Add(this.txtTotalInterest);
            this.pnlRates.Controls.Add(this.lblTotalInterest);
            this.pnlRates.Controls.Add(this.txtPeriodicInterest);
            this.pnlRates.Controls.Add(this.lblPeriodicInterest);
            this.pnlRates.Controls.Add(this.txtInterestRate);
            this.pnlRates.Controls.Add(this.lblInterstRate);
            this.pnlRates.Location = new System.Drawing.Point(17, 532);
            this.pnlRates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRates.Name = "pnlRates";
            this.pnlRates.Size = new System.Drawing.Size(1507, 373);
            this.pnlRates.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(237, 302);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndDate.MaxDate = new System.DateTime(2023, 1, 7, 23, 15, 14, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(195, 34);
            this.dtpEndDate.TabIndex = 41;
            this.dtpEndDate.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(237, 247);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStartDate.MaxDate = new System.DateTime(2023, 1, 7, 23, 15, 14, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(195, 34);
            this.dtpStartDate.TabIndex = 40;
            this.dtpStartDate.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // lblMaturityDate
            // 
            this.lblMaturityDate.AutoSize = true;
            this.lblMaturityDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaturityDate.Location = new System.Drawing.Point(63, 306);
            this.lblMaturityDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaturityDate.Name = "lblMaturityDate";
            this.lblMaturityDate.Size = new System.Drawing.Size(161, 29);
            this.lblMaturityDate.TabIndex = 39;
            this.lblMaturityDate.Text = "Maturity date :";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(65, 252);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(160, 29);
            this.lblStartDate.TabIndex = 37;
            this.lblStartDate.Text = "Starting date :";
            // 
            // txtFinalAmount
            // 
            this.txtFinalAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFinalAmount.Enabled = false;
            this.txtFinalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalAmount.Location = new System.Drawing.Point(237, 194);
            this.txtFinalAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFinalAmount.Name = "txtFinalAmount";
            this.txtFinalAmount.ReadOnly = true;
            this.txtFinalAmount.Size = new System.Drawing.Size(195, 34);
            this.txtFinalAmount.TabIndex = 3;
            // 
            // lblFinalAmount
            // 
            this.lblFinalAmount.AutoSize = true;
            this.lblFinalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalAmount.Location = new System.Drawing.Point(57, 198);
            this.lblFinalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalAmount.Name = "lblFinalAmount";
            this.lblFinalAmount.Size = new System.Drawing.Size(163, 29);
            this.lblFinalAmount.TabIndex = 35;
            this.lblFinalAmount.Text = "Final amount :";
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalInterest.Enabled = false;
            this.txtTotalInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalInterest.Location = new System.Drawing.Point(237, 139);
            this.txtTotalInterest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.ReadOnly = true;
            this.txtTotalInterest.Size = new System.Drawing.Size(195, 34);
            this.txtTotalInterest.TabIndex = 2;
            this.txtTotalInterest.TextChanged += new System.EventHandler(this.txtTotalInterest_TextChanged);
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterest.Location = new System.Drawing.Point(60, 143);
            this.lblTotalInterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(165, 29);
            this.lblTotalInterest.TabIndex = 33;
            this.lblTotalInterest.Text = "Total Interest :";
            // 
            // txtPeriodicInterest
            // 
            this.txtPeriodicInterest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPeriodicInterest.Enabled = false;
            this.txtPeriodicInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodicInterest.Location = new System.Drawing.Point(237, 84);
            this.txtPeriodicInterest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPeriodicInterest.Name = "txtPeriodicInterest";
            this.txtPeriodicInterest.ReadOnly = true;
            this.txtPeriodicInterest.Size = new System.Drawing.Size(195, 34);
            this.txtPeriodicInterest.TabIndex = 1;
            // 
            // lblPeriodicInterest
            // 
            this.lblPeriodicInterest.AutoSize = true;
            this.lblPeriodicInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodicInterest.Location = new System.Drawing.Point(17, 87);
            this.lblPeriodicInterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodicInterest.Name = "lblPeriodicInterest";
            this.lblPeriodicInterest.Size = new System.Drawing.Size(206, 29);
            this.lblPeriodicInterest.TabIndex = 31;
            this.lblPeriodicInterest.Text = "Periodic Interest  :";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.LightGray;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnExit);
            this.pnlButtons.Controls.Add(this.btnCreate);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnPrint);
            this.pnlButtons.Location = new System.Drawing.Point(16, 921);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1508, 122);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1063, 33);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 47);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(785, 33);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(173, 47);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(509, 33);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(173, 47);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(232, 33);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(173, 47);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmCreate_FD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1541, 922);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlRates);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCreate_FD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_FD";
            this.Load += new System.EventHandler(this.frmCreate_FD_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.grprdb.ResumeLayout(false);
            this.grprdb.PerformLayout();
            this.pnlRates.ResumeLayout(false);
            this.pnlRates.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.TextBox txtFDAmount;
        private System.Windows.Forms.Label lblFDAmout;
        private System.Windows.Forms.Label lblInterestInterval;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.RadioButton rdbOnMaturity;
        private System.Windows.Forms.RadioButton rdbHalfYearly;
        private System.Windows.Forms.RadioButton rdbQuaterly;
        private System.Windows.Forms.RadioButton rdbMonthly;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblInterstRate;
        private System.Windows.Forms.Panel pnlRates;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.TextBox txtPeriodicInterest;
        private System.Windows.Forms.Label lblPeriodicInterest;
        private System.Windows.Forms.ComboBox cmbFDType;
        private System.Windows.Forms.Label lblFDType;
        private System.Windows.Forms.TextBox txtFinalAmount;
        private System.Windows.Forms.Label lblFinalAmount;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblMaturityDate;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFDID;
        private System.Windows.Forms.TextBox txtFDID;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblcertid;
        private System.Windows.Forms.TextBox txtCertID;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox grprdb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}