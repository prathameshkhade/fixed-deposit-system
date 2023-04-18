namespace Bank_FD_management
{
    partial class frmdashboard
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
            this.menuDash = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakFDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakFDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fDMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forgetCustomerIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInterestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fDReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDash.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuDash
            // 
            this.menuDash.BackColor = System.Drawing.Color.LightGray;
            this.menuDash.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.breakFDToolStripMenuItem,
            this.mastersToolStripMenuItem,
            this.utilityToolStripMenuItem,
            this.addToToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuDash.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuDash.Location = new System.Drawing.Point(0, 0);
            this.menuDash.Name = "menuDash";
            this.menuDash.Size = new System.Drawing.Size(1284, 38);
            this.menuDash.TabIndex = 0;
            this.menuDash.Text = "menuStrip1";
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
            this.fDMasterToolStripMenuItem,
            this.fDReportsToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(98, 34);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // fDMasterToolStripMenuItem
            // 
            this.fDMasterToolStripMenuItem.Name = "fDMasterToolStripMenuItem";
            this.fDMasterToolStripMenuItem.Size = new System.Drawing.Size(187, 34);
            this.fDMasterToolStripMenuItem.Text = "FD_Master";
            this.fDMasterToolStripMenuItem.Click += new System.EventHandler(this.fDMasterToolStripMenuItem_Click);
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forgetCustomerIDToolStripMenuItem,
            this.updateInterestToolStripMenuItem});
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
            // updateInterestToolStripMenuItem
            // 
            this.updateInterestToolStripMenuItem.Name = "updateInterestToolStripMenuItem";
            this.updateInterestToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.updateInterestToolStripMenuItem.Text = "Update Interest";
            this.updateInterestToolStripMenuItem.Click += new System.EventHandler(this.updateInterestToolStripMenuItem_Click);
            // 
            // addToToolStripMenuItem
            // 
            this.addToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIDToolStripMenuItem});
            this.addToToolStripMenuItem.Name = "addToToolStripMenuItem";
            this.addToToolStripMenuItem.Size = new System.Drawing.Size(63, 34);
            this.addToToolStripMenuItem.Text = "Add";
            // 
            // userIDToolStripMenuItem
            // 
            this.userIDToolStripMenuItem.Name = "userIDToolStripMenuItem";
            this.userIDToolStripMenuItem.Size = new System.Drawing.Size(154, 34);
            this.userIDToolStripMenuItem.Text = "User ID";
            this.userIDToolStripMenuItem.Click += new System.EventHandler(this.userIDToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(100, 34);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // fDReportsToolStripMenuItem
            // 
            this.fDReportsToolStripMenuItem.Name = "fDReportsToolStripMenuItem";
            this.fDReportsToolStripMenuItem.Size = new System.Drawing.Size(187, 34);
            this.fDReportsToolStripMenuItem.Text = "FD Reports";
            this.fDReportsToolStripMenuItem.Click += new System.EventHandler(this.fDReportsToolStripMenuItem_Click);
            // 
            // frmdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.menuDash);
            this.MainMenuStrip = this.menuDash;
            this.Name = "frmdashboard";
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmdashboard_FormClosed);
            this.menuDash.ResumeLayout(false);
            this.menuDash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuDash;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forgetCustomerIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakFDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakFDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateInterestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fDMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fDReportsToolStripMenuItem;
    }
}