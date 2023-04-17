using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bank_FD_management
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbRole.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtUname.Text) && !string.IsNullOrEmpty(txtPass.Text))
                {
                    if(cmbRole.SelectedIndex == 0)
                    {
                        OleDbCommand cmd = new OleDbCommand("insert into admin_login (name, uname, pass) values ('" + txtName.Text + "', '" + txtUname.Text + "', '" + txtPass.Text + "')", Program.conn);
                        
                        if(cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show(" Admin added succesfully");
                        }
                    }

                    if (cmbRole.SelectedIndex == 1)
                    {
                        OleDbCommand cmd = new OleDbCommand("insert into employee_login (name, uname, pass) values ('" + txtName.Text + "', '" + txtUname.Text + "', '" + txtPass.Text + "'", Program.conn);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Employee added succesfully");
                        }
                    }
                } 
                else
                {
                    if (string.IsNullOrEmpty(txtName.Text)) txtName.Focus();
                    if (string.IsNullOrEmpty(txtUname.Text)) txtUname.Focus();
                    if (string.IsNullOrEmpty(txtPass.Text)) txtPass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Select Role");
                cmbRole.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt) txt.Clear();
                if (c is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                    cmb.Text = "--Select Role--";
                }

            }
        }
    }
}
