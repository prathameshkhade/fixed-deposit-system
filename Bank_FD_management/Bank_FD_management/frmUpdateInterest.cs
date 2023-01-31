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
    public partial class frmUpdateInterest : Form
    {
        private static string myConn = "Provider=Microsoft.ACE.Oledb.12.0; Data Source=../../../DB/Data.accdb";
        private OleDbConnection conn = new OleDbConnection(myConn);

        public void setConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        // just for on focusing the seperate panel
        private void onFocus(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            ctrl.Tag = ctrl.BackColor;
            ctrl.BackColor = Color.Cyan;
        }

        private void onLostFocus(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            ctrl.Tag = ctrl.BackColor;
            ctrl.BackColor = Color.White;
        }

        private void ctrlOnFocus()
        {
            foreach (Control c in pnlInfo.Controls)
            {
                c.GotFocus += onFocus;
            }
        }

        private void ctrlOnLostFocus()
        {
            foreach (Control c in pnlInfo.Controls)
            {
                c.LostFocus += onLostFocus;
            }
        }

        public frmUpdateInterest()
        {
            InitializeComponent();
            ctrlOnFocus();
            ctrlOnLostFocus();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlInfo.Controls)
            {
                if (c is ComboBox || c is TextBox)
                    c.Text = "";
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                setConnection();
                OleDbCommand cmd = new OleDbCommand("insert into interest_master values ('" + cmbfdtype.Text + "', " + txtinterest.Text + ", " + txtPenDiff.Text + ")" , conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted...");
                conn.Close();
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtinterest_TextChanged(object sender, EventArgs e)
        {
            //double num_chk = double.Parse(txtinterest.Text);
            //if (!char.Isnumber(txtinterest.Text, 1))
            //{
            //    MessageBox.Show("Enter Float value.");
            //    txtinterest.Text = "";
            //    txtinterest.Focus();
            //}
        }
    }
}
