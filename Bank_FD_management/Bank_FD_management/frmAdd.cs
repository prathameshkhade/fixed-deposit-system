﻿using System;
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
                            btnCancel.PerformClick();
                        }
                    }

                    if (cmbRole.SelectedIndex == 1)
                    {
                        OleDbCommand cmd = new OleDbCommand("insert into Employee_login (name, uname, pass) values('" + txtName.Text + "', '" + txtUname.Text + "', '" + txtPass.Text + "')", Program.conn);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Employee added succesfully");
                            btnCancel.PerformClick();
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
            foreach (Control c in panel3.Controls)
            {
                if (c is TextBox txt) txt.Clear();
                if (c is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                    cmb.Text = "--Select Role--";
                }
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked) txtPass.PasswordChar = '\0';
            if (!chkShow.Checked) txtPass.PasswordChar = '*';
        }
    }
}
