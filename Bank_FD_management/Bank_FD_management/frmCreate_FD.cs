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
    public partial class frmCreate_FD : Form
    {
        private ErrorProvider err = new ErrorProvider();
        private static string myConn = "Provider=Microsoft.ACE.Oledb.12.0; Data Source=../../../DB/Data.accdb";
        private OleDbConnection conn = new OleDbConnection(myConn);
        

        public void setConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                MessageBox.Show("Connection succesfull");
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


        //just for got focusing every panel 
        private void ctrlOnFocusPnl1()
        {
            foreach (Control i in pnlDetails.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocusPnl2()
        {
            foreach (Control i in pnlRates.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocusPnl3()
        {
            foreach (Control i in pnlButtons.Controls)
            {
                if (i is Button)
                {
                    i.GotFocus += onFocus;
                }
            }
        }


        //just for on lost focusing the panel
        private void ctrlOnLostFocusPnl1()
        {
            foreach (Control i in pnlDetails.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocusPnl2()
        {
            foreach (Control i in pnlRates.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocusPnl3()
        {
            foreach (Control i in pnlButtons.Controls)
            {
                if (i is Button)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }


        // for removing all the text from cancel button
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in pnlDetails.Controls)
            {
                if (c is TextBox)
                {
                   c.Text = "";                
                }

                cmbMonths.SelectedIndex = -1;
                cmbDays.SelectedIndex = -1;
                cmbFDType.SelectedIndex = -1;

                rdbMonthly.Checked = false;
                rdbQuaterly.Checked = false;
                rdbHalfYearly.Checked = false;
                rdbOnMaturity.Checked = false;

                dtpEndDate.Value = DateTime.Now;

                disableediting();
                

                
            }
            foreach (Control c in pnlRates.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }


        // for exiting the current form 
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        public frmCreate_FD()
        {
            InitializeComponent();

            ctrlOnFocusPnl1();
            ctrlOnFocusPnl2();
            ctrlOnFocusPnl3();
            ctrlOnLostFocusPnl1();
            ctrlOnLostFocusPnl2();
            ctrlOnLostFocusPnl3();

            setConnection();
            dtpStartDate.MaxDate = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;              
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtFinalAmount.Text))
                {
                    setConnection();

                    OleDbCommand cmd = new OleDbCommand("insert into FD_Master c_id , c_name , cert_dt , cert_id , mature_dt , period_mon , period_day , fd_type , intr_rate , fd_amount , mature_amount , total_intr , total_days) values(" + txtID.Text + ",'" + txtName.Text + "',#" + dtpStartDate.Value + "#,#" + dtpEndDate.Value + "#," + cmbMonths.Text + "," + cmbDays.Text + ",'" + cmbFDType.Text + "'," + txtInterestRate.Text + "," + txtFDAmount.Text + "," + txtFinalAmount.Text + "," + txtTotalInterest.Text + "," + totalDays + ")", conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Inserted successfully");
                }
                else
                {
                    MessageBox.Show("Enter data first !!");
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFDAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFDAmount.Text))
            {
                changePeriodicInterest();
                ChangeTotalInterest();
            }
            else
            {
                txtPeriodicInterest.Text = "";
                txtTotalInterest.Text = "";
                txtFinalAmount.Text = "";
            }
        }

        private void frmCreate_FD_Load(object sender, EventArgs e)
        {

        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            //changeFDtype();
            ChangeTotalInterest();
        }

        private void enableediting()
        {
            cmbMonths.Enabled = true;
            cmbDays.Enabled = true;
            txtFDAmount.Enabled = true;
            rdbMonthly.Enabled = true;
            rdbQuaterly.Enabled = true;
            rdbHalfYearly.Enabled = true;
            rdbOnMaturity.Enabled = true;
        }
        private void disableediting()
        {
            cmbMonths.Enabled = false;
            cmbDays.Enabled = false;
            txtFDAmount.Enabled = false;
            rdbMonthly.Enabled = false;
            rdbQuaterly.Enabled = false;
            rdbHalfYearly.Enabled = false;
            rdbOnMaturity.Enabled = false;
        }

        private void clrpnl2()
        {
            txtInterestRate.Text = "";
            txtPeriodicInterest.Text ="";
            txtTotalInterest.Text = "";
            txtFinalAmount.Text = "";
            dtpEndDate.Value = DateTime.Now;
        }

        //to load the name of the customer and enable editing if the id is present
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    setConnection();
                    OleDbCommand cmd = new OleDbCommand("select * from customer_master where c_id = " + txtID.Text, conn);

                    OleDbDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {               
                        while (dr.Read())
                        {
                            txtName.Text = dr["C_name"].ToString();
                        }
                        enableediting();
                    }
                    else
                    {
                        MessageBox.Show("No data found for id " + txtID.Text);
                        txtID.Text = "";
                        txtName.Text = "";
                        txtID.Focus();
                        disableediting();                    
                    }
                }
                else
                {
                    err.SetError(txtID, "Enter ID");
                    txtID.Focus();
                    disableediting();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //to update fd type depending on days and months
        int totalDays;
        private void changeFDtype()
        {
            if (!string.IsNullOrEmpty(cmbMonths.Text) && !string.IsNullOrEmpty(cmbDays.Text))
            {
                int days = int.Parse(cmbDays.Text);
                int months = int.Parse(cmbMonths.Text);

                //calculating total days
                DateTime startDate = DateTime.Now;
                DateTime newDate = startDate.AddDays(days).AddMonths(months);
                totalDays = (int)(newDate - startDate).TotalDays;

                //to change the end date
                dtpEndDate.MaxDate = DateTime.Now.AddDays(totalDays);
                dtpEndDate.Value = DateTime.Now.AddDays(totalDays);

                //totalDays = (months * 30) + days;
                if (totalDays > 365)
                {
                    cmbFDType.SelectedIndex = 4;
                }
                else if(totalDays>=181)
                {
                    cmbFDType.SelectedIndex = 3;
                }
                else if(totalDays>=91)
                {
                    cmbFDType.SelectedIndex = 2;
                }
                else if(totalDays>=31)
                {
                    cmbFDType.SelectedIndex = 1;             
                }
                else if(totalDays>=7)
                {
                    cmbFDType.SelectedIndex = 0;
                }
                else
                {   //logical error = cmddays combobox dosent get clear even tho we assign null value;              
                    MessageBox.Show("Please select atleast 7 days period");
                    cmbDays.Text = "";
                    cmbFDType.SelectedIndex = -1;
                    changeFDtype();
                    cmbDays.Focus();
                    clrpnl2();
                   
                }
            }
            else
            {
                if(!string.IsNullOrEmpty(cmbMonths.Text))
                {
                    cmbMonths.Focus();
                }
                else
                {
                    cmbDays.Focus();
                }
            }
        }


        private void cmbMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            //changeFDtype();
            ChangeTotalInterest();
            
        }

        private void cmbMonths_TextChanged(object sender, EventArgs e)
        {
            changeFDtype();
        }

        private void cmbDays_TextChanged(object sender, EventArgs e)
        {
            changeFDtype();
        }

        //to load the interest rate automatically
        double interest;
        private void cmbFDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbFDType.SelectedIndex == 0)
            {
                OleDbCommand cmd = new OleDbCommand("select interest from interest_master where duration = '" + cmbFDType.Text + "'", conn);
                interest = Convert.ToDouble(cmd.ExecuteScalar());
                txtInterestRate.Text = interest.ToString();
            }
            else if (cmbFDType.SelectedIndex == 1)
            {
                OleDbCommand cmd = new OleDbCommand("select interest from interest_master where duration = '" + cmbFDType.Text + "'", conn);
                interest = Convert.ToDouble(cmd.ExecuteScalar());
                txtInterestRate.Text = interest.ToString();
            }
            else if (cmbFDType.SelectedIndex == 2)
            {
                OleDbCommand cmd = new OleDbCommand("select interest from interest_master where duration = '" + cmbFDType.Text + "'", conn);
                interest = Convert.ToDouble(cmd.ExecuteScalar());
                txtInterestRate.Text = interest.ToString();
            }
            else if (cmbFDType.SelectedIndex == 3)
            {
                OleDbCommand cmd = new OleDbCommand("select interest from interest_master where duration = '" + cmbFDType.Text + "'", conn);
                interest = Convert.ToDouble(cmd.ExecuteScalar());
                txtInterestRate.Text = interest.ToString();
            }
            else if (cmbFDType.SelectedIndex == 4)
            {
                OleDbCommand cmd = new OleDbCommand("select interest from interest_master where duration = '" + cmbFDType.Text + "'", conn);
                interest = Convert.ToDouble(cmd.ExecuteScalar());
                txtInterestRate.Text = interest.ToString();
            }
        }


        //to update periodic interest automatically depending upon amount and radiobuttons
        private void changePeriodicInterest()
        {
            if (!string.IsNullOrEmpty(txtFDAmount.Text) && !string.IsNullOrEmpty(txtInterestRate.Text))
            {
                //getting latest amount
                double amount = double.Parse(txtFDAmount.Text);

                //updating the periodic interest here 1,2,3=months and 12=bcoz we are calculating by months
                if (rdbMonthly.Checked)
                {
                    double pinterest = ((amount * 1 )/ 12 )* (interest/100);
                    txtPeriodicInterest.Text = pinterest.ToString("0.##");
                }
                if (rdbQuaterly.Checked)
                {
                    double pinterest = ((amount * 3) / 12) * (interest / 100);
                    txtPeriodicInterest.Text = pinterest.ToString("0.##");
                }
                if (rdbHalfYearly.Checked)
                {
                    double pinterest = ((amount * 6) / 12) * (interest / 100);
                    txtPeriodicInterest.Text = pinterest.ToString("0.##");
                }
                if (rdbOnMaturity.Checked)
                {
                    txtPeriodicInterest.Text = "0";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtFDAmount.Text))
                {
                    txtFDAmount.Focus();
                }
                else
                {
                    rdbMonthly.Focus();
                }
            }
        }

        private void ChangeTotalInterest()
        {
            //getting latest amount
            if (!string.IsNullOrEmpty(cmbMonths.Text)&&!string.IsNullOrEmpty(cmbDays.Text)&&!string.IsNullOrEmpty(txtFDAmount.Text)&&!string.IsNullOrEmpty(txtInterestRate.Text))
            {
                double amount = double.Parse(txtFDAmount.Text);
                txtTotalInterest.Text = ((amount * totalDays / 365 * interest) / 100).ToString("0.##");
            }
            
        }


        private void rdbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            changePeriodicInterest();
        }

        private void rdbQuaterly_CheckedChanged(object sender, EventArgs e)
        {
            changePeriodicInterest();
        }

        private void rdbHalfYearly_CheckedChanged(object sender, EventArgs e)
        {
            changePeriodicInterest();
        }

        private void rdbOnMaturity_CheckedChanged(object sender, EventArgs e)
        {
            changePeriodicInterest();
        }

        private void txtInterestRate_TextChanged(object sender, EventArgs e)
        {
            changePeriodicInterest();
        }

        private void txtTotalInterest_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotalInterest.Text)&&!string.IsNullOrEmpty(txtFDAmount.Text))
            {
                txtFinalAmount.Text = (Convert.ToDouble(txtFDAmount.Text)+Convert.ToDouble(txtTotalInterest.Text)).ToString("0.##");
            }
        }
    }
}
