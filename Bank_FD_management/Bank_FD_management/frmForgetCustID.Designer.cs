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
            this.pnltitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtpan = new System.Windows.Forms.TextBox();
            this.lblpan = new System.Windows.Forms.Label();
            this.dtpcustbirth = new System.Windows.Forms.DateTimePicker();
            this.lbldob = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnfetchid = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.pnltitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltitle
            // 
            this.pnltitle.BackColor = System.Drawing.Color.LightGray;
            this.pnltitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnltitle.Controls.Add(this.lbltitle);
            this.pnltitle.Location = new System.Drawing.Point(12, 12);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(776, 60);
            this.pnltitle.TabIndex = 3;
            this.pnltitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltitle_Paint);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(249, 10);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(265, 33);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Forget customer ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtpan);
            this.panel1.Controls.Add(this.lblpan);
            this.panel1.Controls.Add(this.dtpcustbirth);
            this.panel1.Controls.Add(this.lbldob);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 280);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Location = new System.Drawing.Point(225, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 62);
            this.panel3.TabIndex = 30;
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
            // txtpan
            // 
            this.txtpan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpan.Location = new System.Drawing.Point(160, 134);
            this.txtpan.Name = "txtpan";
            this.txtpan.Size = new System.Drawing.Size(232, 29);
            this.txtpan.TabIndex = 27;
            // 
            // lblpan
            // 
            this.lblpan.AutoSize = true;
            this.lblpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpan.Location = new System.Drawing.Point(95, 137);
            this.lblpan.Name = "lblpan";
            this.lblpan.Size = new System.Drawing.Size(59, 24);
            this.lblpan.TabIndex = 26;
            this.lblpan.Text = "PAN :";
            // 
            // dtpcustbirth
            // 
            this.dtpcustbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpcustbirth.Location = new System.Drawing.Point(160, 96);
            this.dtpcustbirth.MaxDate = new System.DateTime(2023, 1, 7, 23, 15, 14, 0);
            this.dtpcustbirth.Name = "dtpcustbirth";
            this.dtpcustbirth.Size = new System.Drawing.Size(232, 22);
            this.dtpcustbirth.TabIndex = 25;
            this.dtpcustbirth.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(94, 94);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(60, 24);
            this.lbldob.TabIndex = 24;
            this.lbldob.Text = "DOB :";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(160, 47);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(491, 29);
            this.txtname.TabIndex = 23;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(83, 47);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(71, 24);
            this.lblname.TabIndex = 22;
            this.lblname.Text = "Name :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btncancel);
            this.panel2.Controls.Add(this.btnfetchid);
            this.panel2.Location = new System.Drawing.Point(12, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 60);
            this.panel2.TabIndex = 5;
            // 
            // btnfetchid
            // 
            this.btnfetchid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnfetchid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfetchid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnfetchid.Location = new System.Drawing.Point(322, 8);
            this.btnfetchid.Name = "btnfetchid";
            this.btnfetchid.Size = new System.Drawing.Size(127, 40);
            this.btnfetchid.TabIndex = 23;
            this.btnfetchid.Text = "Fetch Details";
            this.btnfetchid.UseVisualStyleBackColor = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(492, 9);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(130, 38);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(154, 10);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(130, 38);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // frmForgetCustID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnltitle);
            this.Name = "frmForgetCustID";
            this.Text = "frmForgetCustID";
            this.Load += new System.EventHandler(this.frmForgetCustID_Load);
            this.pnltitle.ResumeLayout(false);
            this.pnltitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtpan;
        private System.Windows.Forms.Label lblpan;
        private System.Windows.Forms.DateTimePicker dtpcustbirth;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnfetchid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncancel;
    }
}