using System;
using System.Windows.Forms;

namespace Bank_FD_management
{
    public partial class frmEmpDashboard : Form
    {
        public frmEmpDashboard()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmcreatecustomer().Show();
        }

        private void fDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCreate_FD().Show();
        }

        private void breakFDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmbreakFD().Show();
        }

        private void fDMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmFD_master().Show();
        }

        private void forgetCustomerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmForgetCustID().Show();
        }

        private void frmEmpDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Program.login.Visible) Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.login.Show();
            Program.login.BringToFront();
            this.Close();
        }
    }
}
