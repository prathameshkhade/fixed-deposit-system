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
    public partial class frmcreatecustomer : Form
    {
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
            foreach(Control i in pnldetails.Controls)
            {
                if(i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocusPnl2()
        {
            foreach (Control i in pnlminor.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocusPnl3()
        {
            foreach (Control i in pnlnominee.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocusPnl4()
        {
            foreach (Control i in pnlbuttons.Controls)
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
            foreach (Control i in pnldetails.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocusPnl2()
        {
            foreach (Control i in pnlminor.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocusPnl3()
        {
            foreach (Control i in pnlnominee.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocusPnl4()
        {
            foreach (Control i in pnlbuttons.Controls)
            {
                if (i is Button)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        // For removing text and enabling boxes for Minor Panel
        private void chbminor_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbminor.Checked)
            {
                foreach (Control c in pnlminor.Controls)
                {
                    if (c is TextBox)
                        c.Enabled = true;
                }
            }

            if (!chbminor.Checked)
            {
                foreach (Control c in pnlminor.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                        c.Enabled = false;
                    }
                }
            }
        }

        // For removing text and disabling boxes for Nominee Panel
        private void chbnominee_CheckedChanged(object sender, EventArgs e)
        {
            if (chbnominee.Checked)
            {
                foreach (Control c in pnlnominee.Controls)
                {
                    if (c is TextBox || c is CheckBox)
                        c.Enabled = true;
                }
                dobNom.CustomFormat = "";
            }

            if (!chbnominee.Checked)
            {
                foreach (Control c in pnlnominee.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                        c.Enabled = false;
                    }
                }
                chbisnomminor.Enabled = false;
                chbisnomminor.Checked = false;
            }
        }

        //for enabling and disabling nominees minor checkbox section
        private void chbisnomminor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbisnomminor.Checked)
            {
                dobNom.Enabled = true;
            }

            if (!chbisnomminor.Checked)
            {
                //dobNom.CustomFormat = "";
                //dobNom.Format = DateTimePickerFormat.Custom;
                dobNom.Enabled = false;
            }
        }

        // for removing all the text from cancel button
        private void btncancel_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnldetails.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }

                chbminor.Checked = false;
                chbnominee.Checked = false;
            }
        }

        // for exiting the current form 
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // just like main() for form
        public frmcreatecustomer()
        {
            InitializeComponent();

            txtID.GotFocus += onFocus;
            txtID.LostFocus += onLostFocus;
            ctrlOnFocusPnl1();
            ctrlOnFocusPnl2();
            ctrlOnFocusPnl3();
            ctrlOnFocusPnl4();
            ctrlOnLostFocusPnl1();
            ctrlOnLostFocusPnl2();
            ctrlOnLostFocusPnl3();
            ctrlOnLostFocusPnl4();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //if (!chbminor.Checked)
            //{
            //    txtgname.Text = "null";
            //    txtgaddress.Text = "null";
            //    txtgrelation.Text = "null";
            //    mskTxtGPhoneNo.Text = "0000000000";
            //}

            //if (!chbnominee.Checked)
            //{
            //    txtnname.Text = "null";
            //    txtnaddress.Text = "null";
            //    mskTxtNPhoneNo.Text = "0000000000";
            //}

            try
            {
                setConnection();
                OleDbCommand cmd = new OleDbCommand("insert into customer_master values ('" + txtname.Text + "', '" + txtaddress.Text + "', '" + cmbcity.Text + "', '" + cmbstate.Text + "', '" + cmbdistrict.Text + "', " + mskTxtPincode.Text + ", " + mskTxtPhoneNo.Text + ", '" + txtemail.Text + "', #" + dtpcustbirth.Value + "#, '" + txtpan.Text + "', #" + DateTime.Now + "#, '" + chbminor.Checked + "', '" + txtgname.Text +  "', '" + txtgaddress.Text + "', '" + txtgrelation.Text + "', " + mskTxtGPhoneNo.Text + ", '" + txtnname.Text + "', '" + txtnrelation.Text + "', " + mskTxtNPhoneNo.Text + ", '" + chbisnomminor.Checked + "', " + (DateTime.Now.Year - dobNom.Value.Year) + ")", conn);
                cmd.ExecuteNonQuery();
            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("data inserted!");
            conn.Close();
        }

        private void chbNewData_CheckedChanged(object sender, EventArgs e)
        {
            if(chbNewData.Checked)
            {
                txtID.Text = "";
                txtID.Enabled = false;
                btnfetchid.Enabled = false;
            }
            
            if(!chbNewData.Checked)
            {
                txtID.Enabled = true;
                btnfetchid.Enabled = true;
            }
        }
    }
}
