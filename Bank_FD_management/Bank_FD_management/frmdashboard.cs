using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bank_FD_management
{
    public partial class frmdashboard : Form
    {
        public frmdashboard()
        {
            InitializeComponent();
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {

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

        private void breakFDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void breakFDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmbreakFD brfd = new frmbreakFD();
            brfd.Show();
        }


        private void fDMastersToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
