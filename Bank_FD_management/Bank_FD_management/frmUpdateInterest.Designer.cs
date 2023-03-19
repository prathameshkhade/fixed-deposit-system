namespace Bank_FD_management
{
    partial class frmUpdateInterest
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.cmbfdtype = new System.Windows.Forms.ComboBox();
            this.lblfdtype = new System.Windows.Forms.Label();
            this.txtPenDiff = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtinterest = new System.Windows.Forms.TextBox();
            this.lblinterest = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.pnltitle.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnltitle.TabIndex = 42;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(277, 10);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(213, 33);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Update Interest";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.LightGray;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInfo.Controls.Add(this.cmbfdtype);
            this.pnlInfo.Controls.Add(this.lblfdtype);
            this.pnlInfo.Controls.Add(this.txtPenDiff);
            this.pnlInfo.Controls.Add(this.lblpassword);
            this.pnlInfo.Controls.Add(this.txtinterest);
            this.pnlInfo.Controls.Add(this.lblinterest);
            this.pnlInfo.Location = new System.Drawing.Point(12, 84);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(776, 278);
            this.pnlInfo.TabIndex = 44;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbfdtype
            // 
            this.cmbfdtype.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbfdtype.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbfdtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfdtype.FormattingEnabled = true;
            this.cmbfdtype.Items.AddRange(new object[] {
            "7 to 30 days",
            "31 to 90 days",
            "91 to 180 days",
            "181 to 365 days",
            "more than 365"});
            this.cmbfdtype.Location = new System.Drawing.Point(297, 50);
            this.cmbfdtype.Name = "cmbfdtype";
            this.cmbfdtype.Size = new System.Drawing.Size(203, 32);
            this.cmbfdtype.TabIndex = 0;
            this.cmbfdtype.TextChanged += new System.EventHandler(this.cmbfdtype_TextChanged);
            this.cmbfdtype.Validating += new System.ComponentModel.CancelEventHandler(this.cmbfdtype_Validating);
            // 
            // lblfdtype
            // 
            this.lblfdtype.AutoSize = true;
            this.lblfdtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfdtype.Location = new System.Drawing.Point(185, 53);
            this.lblfdtype.Name = "lblfdtype";
            this.lblfdtype.Size = new System.Drawing.Size(109, 24);
            this.lblfdtype.TabIndex = 36;
            this.lblfdtype.Text = "FD interval :";
            // 
            // txtPenDiff
            // 
            this.txtPenDiff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPenDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenDiff.Location = new System.Drawing.Point(297, 163);
            this.txtPenDiff.Name = "txtPenDiff";
            this.txtPenDiff.Size = new System.Drawing.Size(198, 29);
            this.txtPenDiff.TabIndex = 2;
            this.txtPenDiff.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            this.txtPenDiff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenDiff_KeyPress);
            this.txtPenDiff.Validating += new System.ComponentModel.CancelEventHandler(this.txtPenDiff_Validating);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(127, 166);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(169, 24);
            this.lblpassword.TabIndex = 34;
            this.lblpassword.Text = "Penalty difference :";
            // 
            // txtinterest
            // 
            this.txtinterest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtinterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinterest.Location = new System.Drawing.Point(297, 109);
            this.txtinterest.Name = "txtinterest";
            this.txtinterest.Size = new System.Drawing.Size(198, 29);
            this.txtinterest.TabIndex = 1;
            this.txtinterest.TextChanged += new System.EventHandler(this.txtinterest_TextChanged);
            this.txtinterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinterest_KeyPress);
            this.txtinterest.Validating += new System.ComponentModel.CancelEventHandler(this.txtinterest_Validating);
            // 
            // lblinterest
            // 
            this.lblinterest.AutoSize = true;
            this.lblinterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinterest.Location = new System.Drawing.Point(215, 112);
            this.lblinterest.Name = "lblinterest";
            this.lblinterest.Size = new System.Drawing.Size(80, 24);
            this.lblinterest.TabIndex = 30;
            this.lblinterest.Text = "Interest :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Location = new System.Drawing.Point(12, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 64);
            this.panel1.TabIndex = 45;
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
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
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
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsave.Location = new System.Drawing.Point(322, 8);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(127, 40);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmUpdateInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnltitle);
            this.Name = "frmUpdateInterest";
            this.Text = "Update Interest";
            this.pnltitle.ResumeLayout(false);
            this.pnltitle.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TextBox txtPenDiff;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtinterest;
        private System.Windows.Forms.Label lblinterest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cmbfdtype;
        private System.Windows.Forms.Label lblfdtype;
    }
}