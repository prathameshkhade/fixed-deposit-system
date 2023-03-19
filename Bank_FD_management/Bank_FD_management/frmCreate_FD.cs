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
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }

                rdbMonthly.Checked = false;
                rdbQuaterly.Checked = false;
                rdbHalfYearly.Checked = false;
                rdbOnMaturity.Checked = false;

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
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                setConnection();





            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFDAmount_TextChanged(object sender, EventArgs e)
        {
            changePeriodicInterest();
        }

        private void frmCreate_FD_Load(object sender, EventArgs e)
        {

        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            //changeFDtype();
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

                DateTime startDate = DateTime.Now;
                DateTime newDate = startDate.AddDays(days).AddMonths(months);
                totalDays = (int)(newDate - startDate).TotalDays;

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
                    cmbFDType.Text = "";
                    changeFDtype();
                    cmbMonths.Focus();
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

                //updating the periodic interest
                if(rdbMonthly.Checked)
                {
                    double pinterest = ((amount * 1 )/ 12 )* (interest/100);
                    txtPeriodicInterest.Text = pinterest.ToString();
                }
                if (rdbQuaterly.Checked)
                {
                    double pinterest = ((amount * 3) / 12) * (interest / 100);
                    txtPeriodicInterest.Text = pinterest.ToString();
                }
                if (rdbHalfYearly.Checked)
                {
                    double pinterest = ((amount * 6) / 12) * (interest / 100);
                    txtPeriodicInterest.Text = pinterest.ToString();
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



    }
}
