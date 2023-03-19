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

        }

        private void frmCreate_FD_Load(object sender, EventArgs e)
        {

        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
