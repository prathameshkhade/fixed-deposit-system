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

        // Function that will clear all the form 
        private void clrfrm()
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
            clrfrm();
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
            try
            {
                if (chbNewData.Checked)
                {
                    if ((chbminor.Checked) && (chbnominee.Checked))
                    {
                        setConnection();
                        OleDbCommand cmd = new OleDbCommand("insert into customer_master (C_name , address , city , state , district , pin_code , phone , e_mail , DOB  , PAN , Add_date , is_minor_cust , g_name , g_addr , g_relation , g_phone , have_nom, N_name , Rel_of_nom , Phone_nom , Is_minor , dob_nom,  Age_minor) values('" + txtname.Text + "', '" + txtaddress.Text + "', '" + cmbcity.Text + "', '" + cmbstate.Text + "', '" + cmbdistrict.Text + "', " + txtPinCode.Text + ", " + txtPhone.Text + ",'" + txtemail.Text + "', #" + dtpcustbirth.Value + "# ,'" + txtpan.Text + "', #" + DateTime.Now + "#, " + chbminor.Checked + ", '" + txtgname.Text + "', '" + txtgaddress.Text + "', '" + txtgrelation.Text + "', " + txtGuardPhone.Text + ", " + chbnominee.Checked + ", '" + txtnname.Text + "', '" + txtnrelation.Text + "', " + txtNomPhone.Text + ", " + chbisnomminor.Checked + ", #" + dobNom.Value + "#, " + (DateTime.Now.Year - dobNom.Value.Year) + ")", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted!");
                    }
                    else if (chbminor.Checked)
                    {
                        setConnection();
                        OleDbCommand cmd = new OleDbCommand("insert into customer_master (C_name , address , city , state , district , pin_code , phone , e_mail , DOB  , PAN , Add_date , is_minor_cust , g_name , g_addr , g_relation , g_phone )values('" + txtname.Text + "', '" + txtaddress.Text + "', '" + cmbcity.Text + "', '" + cmbstate.Text + "', '" + cmbdistrict.Text + "', " + txtPinCode.Text + ", " + txtPhone.Text + ",'" + txtemail.Text + "', #" + dtpcustbirth.Value + "# ,'" + txtpan.Text + "', #" + DateTime.Now + "#, " + chbminor.Checked + ", '" + txtgname.Text + "', '" + txtgaddress.Text + "', '" + txtgrelation.Text + "', " + txtGuardPhone.Text + ")", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted!");
                    }
                    else if (chbnominee.Checked)
                    {
                        setConnection();
                        OleDbCommand cmd = new OleDbCommand("insert into customer_master (C_name , address , city , state , district , pin_code , phone , e_mail , DOB  , PAN , Add_date, have_nom,  N_name , Rel_of_nom , Phone_nom , Is_minor , dob_nom, Age_minor) values('" + txtname.Text + "', '" + txtaddress.Text + "', '" + cmbcity.Text + "', '" + cmbstate.Text + "', '" + cmbdistrict.Text + "', " + txtPinCode.Text + ", " + txtPhone.Text + ",'" + txtemail.Text + "', #" + dtpcustbirth.Value + "# ,'" + txtpan.Text + "', #" + DateTime.Now + "#, " + chbnominee.Checked + ", '" + txtnname.Text + "', '" + txtnrelation.Text + "', " + txtNomPhone.Text + ", " + chbisnomminor.Checked + ", #" + dobNom.Value + "#, " + (DateTime.Now.Year - dobNom.Value.Year) + ")", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted!");
                    }
                }
                else
                {
                    setConnection();
                    OleDbCommand cmd = new OleDbCommand("update customer_master set c_name = '" + txtname.Text + "', address = '" + txtaddress.Text + "', city = '" + cmbcity.Text + "', state = '" + cmbstate.Text + "', district = '" + cmbdistrict.Text + "', pin_code = " + txtPinCode.Text + ", phone = " + txtPhone.Text + ", e_mail = '" + txtemail.Text + "', dob = #" + dtpcustbirth.Value + "#, pan = '" + txtpan.Text + "', is_minor_cust = " + chbminor.Checked + ", g_name = '" + txtgname.Text + "', g_addr = '" + txtgaddress.Text + "', g_relation = '" + txtgrelation.Text + "', g_phone = " + txtGuardPhone.Text + ", n_name = '" + txtnname.Text + "', rel_of_nom = '" + txtnrelation.Text + "', phone_nom = " + txtNomPhone.Text + ", is_minor = " + chbisnomminor.Checked + ", have_nom = " + chbminor.Checked + " where c_id = " + txtID.Text, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data updated...");
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        private void chbNewData_CheckedChanged(object sender, EventArgs e)
        {
            if(chbNewData.Checked)
            {
                txtID.Text = "";
                clrfrm();
                txtID.Enabled = false;
                btnfetchid.Enabled = false;
            }
            
            if(!chbNewData.Checked)
            {
                txtID.Enabled = true;
                btnfetchid.Enabled = true;
            }
        }

        private void btnfetchid_Click(object sender, EventArgs e)
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
                            txtname.Text = dr["C_name"].ToString();
                            txtaddress.Text = dr["address"].ToString();
                            cmbcity.Text = dr["city"].ToString();
                            cmbstate.Text = dr["state"].ToString();
                            cmbdistrict.Text = dr["district"].ToString();
                            txtPinCode.Text = dr["pin_code"].ToString();
                            txtPhone.Text = dr["phone"].ToString();
                            txtemail.Text = dr["e_mail"].ToString();
                            dtpcustbirth.Text = dr["dob"].ToString();
                            txtpan.Text = dr["PAN"].ToString();
                            chbminor.Checked = (bool)(dr["is_minor_cust"]);
                            txtgname.Text = dr["g_name"].ToString();
                            txtgaddress.Text = dr["g_addr"].ToString();
                            txtgrelation.Text = dr["g_relation"].ToString();
                            txtGuardPhone.Text = dr["g_phone"].ToString();
                            txtnname.Text = dr["n_name"].ToString();
                            txtnrelation.Text = dr["rel_of_nom"].ToString();
                            txtNomPhone.Text = dr["phone_nom"].ToString();
                            chbisnomminor.Checked = (bool)(dr["is_minor"]);
                            chbnominee.Checked = (bool)(dr["have_nom"]);
                            dobNom.Text = dr["dob_nom"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found for id " + txtID.Text);
                        txtID.Text = "";
                        txtID.Focus();
                    }
                }
                else
                {
                    err.SetError(txtID, "Enter ID");
                    txtID.Focus();
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
