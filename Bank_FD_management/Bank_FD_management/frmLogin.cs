using System.Windows.Forms;
using System.Data.OleDb;

namespace Bank_FD_management
{
    public partial class frmLogin : Form
    {
        ErrorProvider err = new ErrorProvider();
        private static string myConn = "Provider=Microsoft.ACE.Oledb.12.0; Data Source=../../../DB/Data.accdb";
        private OleDbConnection conn = new OleDbConnection(myConn);

        public void setConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public frmLogin()
        {
            InitializeComponent();
            setConnection();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            OleDbCommand cmd;

            if(cmbRole.SelectedIndex != -1)
            {
                // Providing error
                if(string.IsNullOrEmpty(txtUname.Text))
                {
                    err.SetError(txtUname, "Please enter Username!");
                    txtUname.Focus();
                }

                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    err.SetError(txtPass, "Please enter Password!");
                    txtPass.Focus();
                }

                // Admin login
                if (cmbRole.SelectedIndex == 0)
                {
                    if(!string.IsNullOrEmpty(txtUname.Text) && !string.IsNullOrEmpty(txtPass.Text))
                    {
                        cmd = new OleDbCommand("select * from admin_login where uname = '" + txtUname.Text + "' and pass = '" + txtPass.Text + "'", conn);
                        OleDbDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            MessageBox.Show("Welcome " + txtUname.Text);

                            // go to emp dashboard page
                            frmdashboard admin = new frmdashboard();
                            this.Hide();
                            admin.ShowDialog();
                            admin.BringToFront();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password is wrong!");
                        }

                        dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("Either Username or Password is empty");
                        if(string.IsNullOrEmpty(txtUname.Text))
                        {
                            txtUname.Focus();
                        }
                        else
                        {
                            txtPass.Focus();
                        }
                    }
                }

                // Employee login
                if (cmbRole.SelectedIndex == 1)
                {
                    cmd = new OleDbCommand("select * from employee_login where uname = '" + txtUname.Text + "' and pass = '" + txtPass.Text + "'", conn);
                    OleDbDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("Welcome " + txtUname.Text);

                        // go to emp dashboard page
                        frmEmpDashboard emp = new frmEmpDashboard();
                        this.Hide();
                        emp.Show();
                        emp.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is wrong!");
                    }

                    dr.Close();
                }
            } 
            else
            {
                MessageBox.Show("Please select your role");
                cmbRole.Focus();
            }
        }

        private void txtUname_Validated(object sender, System.EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUname.Text))
            {
                err.SetError(txtUname, null);
            }
        }

        private void txtPass_Validated(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPass.Text))
            {
                err.SetError(txtPass, null);
            }
        }
    }
}
