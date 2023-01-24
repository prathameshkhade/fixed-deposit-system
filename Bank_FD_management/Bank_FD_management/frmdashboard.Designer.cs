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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakFDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakFDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forgetCustomerIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInterestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.utilityToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 38);
            this.menuStrip1.TabIndex = 0;
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
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // fDToolStripMenuItem
            // 
            this.fDToolStripMenuItem.Name = "fDToolStripMenuItem";
            this.fDToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
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
            this.breakFDToolStripMenuItem.Click += new System.EventHandler(this.breakFDToolStripMenuItem_Click);
            // 
            // breakFDToolStripMenuItem1
            // 
            this.breakFDToolStripMenuItem1.Name = "breakFDToolStripMenuItem1";
            this.breakFDToolStripMenuItem1.Size = new System.Drawing.Size(180, 34);
            this.breakFDToolStripMenuItem1.Text = "Break FD";
            this.breakFDToolStripMenuItem1.Click += new System.EventHandler(this.breakFDToolStripMenuItem1_Click);
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeMastersToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(98, 34);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // employeeMastersToolStripMenuItem
            // 
            this.employeeMastersToolStripMenuItem.Name = "employeeMastersToolStripMenuItem";
            this.employeeMastersToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.employeeMastersToolStripMenuItem.Text = "Employee Masters";
            this.employeeMastersToolStripMenuItem.Click += new System.EventHandler(this.employeeMastersToolStripMenuItem_Click);
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
            // frmdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmdashboard";
            this.Text = "frmdashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmdashboard_Load);
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
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeMastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forgetCustomerIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakFDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakFDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateInterestToolStripMenuItem;
    }
}