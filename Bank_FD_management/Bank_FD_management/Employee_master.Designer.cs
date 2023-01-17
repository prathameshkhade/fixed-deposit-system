namespace Bank_FD_management
{
    partial class Employee_Master
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.pnltitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfetchdetails = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtempphone = new System.Windows.Forms.TextBox();
            this.lblempphone = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.lblempid = new System.Windows.Forms.Label();
            this.dtpemptbirth = new System.Windows.Forms.DateTimePicker();
            this.lbldob = new System.Windows.Forms.Label();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.pnltitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Select Employee :";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(198, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(353, 32);
            this.comboBox4.TabIndex = 39;
            // 
            // pnltitle
            // 
            this.pnltitle.BackColor = System.Drawing.Color.LightGray;
            this.pnltitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnltitle.Controls.Add(this.lbltitle);
            this.pnltitle.Location = new System.Drawing.Point(12, 9);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(776, 60);
            this.pnltitle.TabIndex = 41;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(249, 10);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(242, 33);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Employee Master";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnfetchdetails);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 75);
            this.panel1.TabIndex = 42;
            // 
            // btnfetchdetails
            // 
            this.btnfetchdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfetchdetails.Location = new System.Drawing.Point(580, 14);
            this.btnfetchdetails.Name = "btnfetchdetails";
            this.btnfetchdetails.Size = new System.Drawing.Size(127, 40);
            this.btnfetchdetails.TabIndex = 41;
            this.btnfetchdetails.Text = "Fetch Details";
            this.btnfetchdetails.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtempphone);
            this.panel2.Controls.Add(this.lblempphone);
            this.panel2.Controls.Add(this.txtempid);
            this.panel2.Controls.Add(this.lblempid);
            this.panel2.Controls.Add(this.dtpemptbirth);
            this.panel2.Controls.Add(this.lbldob);
            this.panel2.Controls.Add(this.txtempname);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Location = new System.Drawing.Point(12, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 220);
            this.panel2.TabIndex = 43;
            // 
            // txtempphone
            // 
            this.txtempphone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtempphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempphone.Location = new System.Drawing.Point(108, 120);
            this.txtempphone.Name = "txtempphone";
            this.txtempphone.Size = new System.Drawing.Size(198, 29);
            this.txtempphone.TabIndex = 37;
            // 
            // lblempphone
            // 
            this.lblempphone.AutoSize = true;
            this.lblempphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempphone.Location = new System.Drawing.Point(25, 124);
            this.lblempphone.Name = "lblempphone";
            this.lblempphone.Size = new System.Drawing.Size(76, 24);
            this.lblempphone.TabIndex = 36;
            this.lblempphone.Text = "Phone :";
            // 
            // txtempid
            // 
            this.txtempid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.Location = new System.Drawing.Point(152, 18);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(198, 29);
            this.txtempid.TabIndex = 31;
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempid.Location = new System.Drawing.Point(23, 21);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(128, 24);
            this.lblempid.TabIndex = 30;
            this.lblempid.Text = "Employee ID :";
            // 
            // dtpemptbirth
            // 
            this.dtpemptbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpemptbirth.Location = new System.Drawing.Point(104, 170);
            this.dtpemptbirth.MaxDate = new System.DateTime(2023, 1, 7, 23, 15, 14, 0);
            this.dtpemptbirth.Name = "dtpemptbirth";
            this.dtpemptbirth.Size = new System.Drawing.Size(232, 22);
            this.dtpemptbirth.TabIndex = 29;
            this.dtpemptbirth.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(38, 170);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(60, 24);
            this.lbldob.TabIndex = 28;
            this.lbldob.Text = "DOB :";
            // 
            // txtempname
            // 
            this.txtempname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempname.Location = new System.Drawing.Point(108, 68);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(491, 29);
            this.txtempname.TabIndex = 27;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(31, 70);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(71, 24);
            this.lblname.TabIndex = 26;
            this.lblname.Text = "Name :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnexit);
            this.panel3.Controls.Add(this.btncancel);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Location = new System.Drawing.Point(12, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 46);
            this.panel3.TabIndex = 44;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(323, 7);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(127, 30);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(521, 7);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(130, 30);
            this.btnexit.TabIndex = 46;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(136, 7);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(130, 30);
            this.btncancel.TabIndex = 45;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // Employee_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnltitle);
            this.Name = "Employee_Master";
            this.Text = "Employee_Master";
            this.pnltitle.ResumeLayout(false);
            this.pnltitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Panel pnltitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfetchdetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpemptbirth;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.TextBox txtempphone;
        private System.Windows.Forms.Label lblempphone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncancel;
    }
}