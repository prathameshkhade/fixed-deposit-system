﻿using System.Windows.Forms;
using System.Data.OleDb;

namespace Bank_FD_management
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Program.setConnection();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            OleDbCommand cmd;

            if(cmbRole.SelectedIndex != -1)
            {
                // Providing error
                if (string.IsNullOrEmpty(txtUname.Text))
                {
                    Program.err.SetError(txtUname, "Please enter Username!");
                    txtUname.Focus();
                }

                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    Program.err.SetError(txtPass, "Please enter Password!");
                    txtPass.Focus();
                }

                // Admin login
                if (cmbRole.SelectedIndex == 0)
                {
                    if(!string.IsNullOrEmpty(txtUname.Text) && !string.IsNullOrEmpty(txtPass.Text))
                    {
                        cmd = new OleDbCommand("select * from admin_login where uname = '" + txtUname.Text + "' and pass = '" + txtPass.Text + "'", Program.conn);
                        OleDbDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            MessageBox.Show("Welcome " + txtUname.Text);

                            // go to emp dashboard page 
                            frmdashboard admin = new frmdashboard();
                            this.Hide();
                            admin.ShowDialog();
                            admin.BringToFront();

                            // clear the login form for later use
                            clearLogin();
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
                    cmd = new OleDbCommand("select * from employee_login where uname = '" + txtUname.Text + "' and pass = '" + txtPass.Text + "'", Program.conn);
                    OleDbDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("Welcome " + txtUname.Text);

                        // go to emp dashboard page
                        frmEmpDashboard emp = new frmEmpDashboard();
                        this.Hide();
                        emp.Show();
                        emp.BringToFront();

                        // clear the login form for later use
                        clearLogin();
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
                Program.err.SetError(txtUname, null);
            }
        }

        private void txtPass_Validated(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPass.Text))
            {
                Program.err.SetError(txtPass, null);
            }
        }

        private void chkShow_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkShow.Checked) txtPass.PasswordChar = '\0';
            if (!chkShow.Checked) txtPass.PasswordChar = '*';
        }

        private void clearLogin()
        {
            txtUname.Clear();
            txtPass.Clear();
            cmbRole.SelectedIndex = -1;
            cmbRole.Text = "--Select Role--";
            cmbRole.Focus();
        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }

        private void cmbRole_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtUname.Focus();
            }
        }

        private void txtUname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }

        private void frmLogin_Load(object sender, System.EventArgs e)
        {

        }
    }
}
