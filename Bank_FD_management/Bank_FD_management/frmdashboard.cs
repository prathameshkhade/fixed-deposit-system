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

        private static string myConn = "Provider=Microsoft.ACE.Oledb.12.0; Data Source=C:/Users/Hiremath/source/repos/Fixed_deposite_system/Bank_FD_management/DB/Data.accdb";
        OleDbConnection conn = new OleDbConnection(myConn);

        public void setConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                MessageBox.Show("Database successfully connected!");
            }
        }

        public frmdashboard()
        {
            InitializeComponent();
            setConnection();
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

        private void customerMastersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer_Master custMast = new frmCustomer_Master();
            custMast.Show();
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
