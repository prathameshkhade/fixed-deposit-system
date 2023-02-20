namespace Bank_FD_management
{
    partial class frmForgetCustID
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
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.pnlCID = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPan = new System.Windows.Forms.TextBox();
            this.lblPan = new System.Windows.Forms.Label();
            this.dtpCustBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFetchID = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlCID.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.LightGray;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(12, 12);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(776, 60);
            this.pnlTitle.TabIndex = 3;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltitle_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(249, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Forget customer ID";
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.LightGray;
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDetails.Controls.Add(this.pnlCID);
            this.pnlDetails.Controls.Add(this.txtPan);
            this.pnlDetails.Controls.Add(this.lblPan);
            this.pnlDetails.Controls.Add(this.dtpCustBirth);
            this.pnlDetails.Controls.Add(this.lblDob);
            this.pnlDetails.Controls.Add(this.txtName);
            this.pnlDetails.Controls.Add(this.lblName);
            this.pnlDetails.Location = new System.Drawing.Point(12, 85);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(776, 280);
            this.pnlDetails.TabIndex = 4;
            // 
            // pnlCID
            // 
            this.pnlCID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCID.Controls.Add(this.txtID);
            this.pnlCID.Controls.Add(this.lblID);
            this.pnlCID.Location = new System.Drawing.Point(225, 192);
            this.pnlCID.Name = "pnlCID";
            this.pnlCID.Size = new System.Drawing.Size(341, 62);
            this.pnlCID.TabIndex = 30;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(105, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(198, 29);
            this.txtID.TabIndex = 29;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(20, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 24);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "Cust ID :";
            // 
            // txtPan
            // 
            this.txtPan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPan.Location = new System.Drawing.Point(160, 134);
            this.txtPan.MaxLength = 10;
            this.txtPan.Name = "txtPan";
            this.txtPan.Size = new System.Drawing.Size(232, 29);
            this.txtPan.TabIndex = 27;
            this.txtPan.Validating += new System.ComponentModel.CancelEventHandler(this.txtPan_Validating);
            // 
            // lblPan
            // 
            this.lblPan.AutoSize = true;
            this.lblPan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPan.Location = new System.Drawing.Point(95, 137);
            this.lblPan.Name = "lblPan";
            this.lblPan.Size = new System.Drawing.Size(59, 24);
            this.lblPan.TabIndex = 26;
            this.lblPan.Text = "PAN :";
            // 
            // dtpCustBirth
            // 
            this.dtpCustBirth.CustomFormat = "";
            this.dtpCustBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCustBirth.Location = new System.Drawing.Point(160, 96);
            this.dtpCustBirth.MaxDate = new System.DateTime(2023, 1, 7, 23, 15, 14, 0);
            this.dtpCustBirth.Name = "dtpCustBirth";
            this.dtpCustBirth.Size = new System.Drawing.Size(232, 22);
            this.dtpCustBirth.TabIndex = 25;
            this.dtpCustBirth.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(94, 94);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(60, 24);
            this.lblDob.TabIndex = 24;
            this.lblDob.Text = "DOB :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(160, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(491, 29);
            this.txtName.TabIndex = 23;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(83, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name :";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.LightGray;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnExit);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnFetchID);
            this.pnlButtons.Location = new System.Drawing.Point(12, 378);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(776, 60);
            this.pnlButtons.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(492, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(154, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 38);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFetchID
            // 
            this.btnFetchID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFetchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFetchID.Location = new System.Drawing.Point(322, 8);
            this.btnFetchID.Name = "btnFetchID";
            this.btnFetchID.Size = new System.Drawing.Size(127, 40);
            this.btnFetchID.TabIndex = 23;
            this.btnFetchID.Text = "Fetch Details";
            this.btnFetchID.UseVisualStyleBackColor = false;
            this.btnFetchID.Click += new System.EventHandler(this.btnFetchID_Click);
            // 
            // frmForgetCustID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlTitle);
            this.Name = "frmForgetCustID";
            this.Text = "frmForgetCustID";
            this.Load += new System.EventHandler(this.frmForgetCustID_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlCID.ResumeLayout(false);
            this.pnlCID.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.TextBox txtPan;
        private System.Windows.Forms.Label lblPan;
        private System.Windows.Forms.DateTimePicker dtpCustBirth;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnFetchID;
        private System.Windows.Forms.Panel pnlCID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
    }
}