using System;
using System.Windows.Forms;

namespace Bank_FD_management
{
    public partial class frmdashboard : Form
    {
        public frmdashboard()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcreatecustomer cust = new frmcreatecustomer();
            cust.Show();
        }

        private void fDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreate_FD crfd = new frmCreate_FD();
            crfd.Show();
        }

        private void breakFDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmbreakFD brfd = new frmbreakFD();
            brfd.Show();
        }

        private void employeeMastersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Master empMast = new Employee_Master();
            empMast.Show();
        }

        private void forgetCustomerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForgetCustID frCustID = new frmForgetCustID();
            frCustID.Show();
        }

        private void updateInterestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateInterest updtIntr = new frmUpdateInterest();
            updtIntr.Show();
        }

        private void fDMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFD_master fd_master = new frmFD_master();
            fd_master.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAdd().Show();
        }

        private void frmdashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Program.login.Visible) Application.Exit(); 
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.login.Show();
            Program.login.BringToFront();
            this.Close();
        }
    }
}
