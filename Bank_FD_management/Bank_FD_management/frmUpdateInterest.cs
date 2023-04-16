using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bank_FD_management

{
    public partial class frmUpdateInterest : Form
    {
        private ErrorProvider err = new ErrorProvider();
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
            setConnection();
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
            ctrlClear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("update interest_master set interest = " + txtinterest.Text + ", p_interest = " + txtPenDiff.Text + " where duration = '" + cmbfdtype.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updatated");
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                ctrlClear();
            }
        }

        private void txtinterest_TextChanged(object sender, EventArgs e)
        {

        }

        //for clearing the entire form
        private void ctrlClear()
        {
            foreach (Control c in pnlInfo.Controls)
            {
                if (c is ComboBox || c is TextBox)
                    c.Text = "";
            }
        }

        private void cmbfdtype_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(cmbfdtype.Text))
            {
                err.SetError(cmbfdtype, "Please select FD type");
            }
            else { err.SetError(cmbfdtype, null); }
        }

        private void txtinterest_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtinterest.Text))
            {
                err.SetError(txtinterest, "Please enter rate of interest");
            }
            else { err.SetError(txtinterest, null); }
        }

        private void txtPenDiff_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPenDiff.Text))
            {
                err.SetError(txtPenDiff, "Please enter difference of interest");
            }
            else { err.SetError(txtinterest, null); }
        }

        private void txtinterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPenDiff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmbfdtype_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("select * from interest_master where duration = '" + cmbfdtype.Text + "'", conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        txtinterest.Text = dr["interest"].ToString();
                        txtPenDiff.Text = dr["p_interest"].ToString();
                    }
                }

            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
