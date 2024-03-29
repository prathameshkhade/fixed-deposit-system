﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bank_FD_management
{
    public partial class frmFD_master : Form
    {
        public frmFD_master()
        {
            InitializeComponent();
        }

        private void lblInterest_Click(object sender, EventArgs e)
        {

        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                OleDbCommand cmd = new OleDbCommand("select * from FD_master where c_id = " + txtID.Text + "", Program.conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtName.Text = dr["c_name"].ToString();
                        OleDbCommand cmd1 = new OleDbCommand("SELECT cert_id, fd_amount, cert_dt FROM FD_master WHERE c_id = " + txtID.Text + "", Program.conn);
                        //var adapter = new OleDbDataAdapter(cmd1);
                        //var dt = new System.Data.DataTable();
                        //adapter.Fill(dt);
                        //dgvList.DataSource = dt;
                        DataTable dt = new DataTable();
                        OleDbDataAdapter adr = new OleDbDataAdapter(cmd1);
                        adr.Fill(dt);
                        dgvList.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("the given id does not exist");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Customer ID");
            }
        }

        private void txtCertID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlRates_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the user clicked on a valid cell (i.e. a cert_id cell)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvList.Columns[e.ColumnIndex].Name == "cert_id")
            {
                // Get the value of the clicked cell (i.e. the cert_id value)
                int certId = (int)dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Query the database for the data associated with the cert_id
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM FD_master WHERE cert_id =" + certId, Program.conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtFDID.Text = dr["fd_id"].ToString();
                        txtCertID.Text = dr["cert_id"].ToString();
                        txtStatus.Text = dr["status"].ToString();
                        cmbFDType.Text = dr["fd_type"].ToString();
                        txtInterestRate.Text = dr["intr_rate"].ToString();
                        txtFDAmount.Text = dr["fd_amount"].ToString();
                        txtFinalAmount.Text = dr["mature_amount"].ToString();

                        dtpStartDate.MaxDate = DateTime.Now.AddMonths(1);
                        dtpStartDate.Text = dr["cert_dt"].ToString();

                        dtpEndDate.MaxDate =DateTime.Parse(dr["mature_dt"].ToString());
                        dtpEndDate.Text = dr["mature_dt"].ToString();

                        txtTotalInterest.Text = dr["total_intr"].ToString();
                        txtintr_period.Text = dr["Period_intr"].ToString();
                        cmbMonths.Text = dr["period_mon"].ToString();
                        cmbDays.Text = dr["period_day"].ToString();
                        txtPeriodicInterest.Text = dr["periodic_intr"].ToString();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlRates.Controls)
            {
                if (c is TextBox || c is ComboBox || c is DateTimePicker)
                {
                    c.Text = "";
                }
            }
            txtName.Text = "";
            txtFDID.Text = "";
            txtCertID.Text = "";
            txtStatus.Text = "";

            foreach(DataGridView d1 in pnldatagridview.Controls)
            {
                d1.DataSource = null;
                d1.Rows.Clear();
            }

            txtID.Text = "";
            txtID.Focus();
        }

        private void lblcertid_Click(object sender, EventArgs e)
        {

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(!string.IsNullOrEmpty(txtID.Text))
                {
                    btnLoad.Focus();
                }
                else
                {
                    MessageBox.Show("Enter ID first");
                    txtID.Focus();
                }
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
