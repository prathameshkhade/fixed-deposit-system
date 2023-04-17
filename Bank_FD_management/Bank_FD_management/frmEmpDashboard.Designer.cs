namespace Bank_FD_management
{
    partial class frmEmpDashboard
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
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakFDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakFDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fDMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forgetCustomerIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.breakFDToolStripMenuItem,
            this.mastersToolStripMenuItem,
            this.utilityToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.fDToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(85, 34);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // fDToolStripMenuItem
            // 
            this.fDToolStripMenuItem.Name = "fDToolStripMenuItem";
            this.fDToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.fDToolStripMenuItem.Text = "FD";
            this.fDToolStripMenuItem.Click += new System.EventHandler(this.fDToolStripMenuItem_Click);
            // 
            // breakFDToolStripMenuItem
            // 
            this.breakFDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.breakFDToolStripMenuItem1});
            this.breakFDToolStripMenuItem.Name = "breakFDToolStripMenuItem";
            this.breakFDToolStripMenuItem.Size = new System.Drawing.Size(107, 34);
            this.breakFDToolStripMenuItem.Text = "Break FD";
            // 
            // breakFDToolStripMenuItem1
            // 
            this.breakFDToolStripMenuItem1.Name = "breakFDToolStripMenuItem1";
            this.breakFDToolStripMenuItem1.Size = new System.Drawing.Size(168, 34);
            this.breakFDToolStripMenuItem1.Text = "Break FD";
            this.breakFDToolStripMenuItem1.Click += new System.EventHandler(this.breakFDToolStripMenuItem1_Click);
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fDMasterToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(98, 34);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // fDMasterToolStripMenuItem
            // 
            this.fDMasterToolStripMenuItem.Name = "fDMasterToolStripMenuItem";
            this.fDMasterToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.fDMasterToolStripMenuItem.Text = "FD_Master";
            this.fDMasterToolStripMenuItem.Click += new System.EventHandler(this.fDMasterToolStripMenuItem_Click);
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forgetCustomerIDToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // forgetCustomerIDToolStripMenuItem
            // 
            this.forgetCustomerIDToolStripMenuItem.Name = "forgetCustomerIDToolStripMenuItem";
            this.forgetCustomerIDToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.forgetCustomerIDToolStripMenuItem.Text = "Forget Customer ID";
            this.forgetCustomerIDToolStripMenuItem.Click += new System.EventHandler(this.forgetCustomerIDToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 34);
            this.exitToolStripMenuItem.Text = "Log Out";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmEmpDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmEmpDashboard";
            this.Text = "Employee Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEmpDashboard_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakFDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakFDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fDMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forgetCustomerIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}