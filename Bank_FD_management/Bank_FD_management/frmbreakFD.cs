using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bank_FD_management
{


    public partial class frmbreakFD : Form
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



        //for every control on panel got focus
        private void ctrlOnFocuspnl1()
        {
            foreach (Control i in pnlFetch.Controls)
            {
                if (i is TextBox || i is ComboBox || i is Button)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocuspnl2()
        {
            foreach (Control i in pnlBreak.Controls)
            {
                if (i is TextBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocuspnl3()
        {
            btnCancel.GotFocus += onFocus;
            btnBreak.GotFocus += onFocus;
            btnExit.GotFocus += onFocus;
        }

        private void ctrlOnFocuspnlmid1()
        {
            foreach (Control i in pnlMid1.Controls)
            {
                if (i is TextBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }
        private void ctrlOnFocuspnlmid2()
        {
            foreach (Control i in pnlMid2.Controls)
            {
                if (i is TextBox)
                {
                    i.GotFocus += onFocus;
                }
            }
        }


        //for every control on panel lost focus
        private void ctrlOnLostFocuspnl1()
        {
            foreach (Control i in pnlFetch.Controls)
            {
                if (i is TextBox || i is ComboBox || i is Button)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocuspnl2()
        {
            foreach (Control i in pnlBreak.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocuspnl3()
        {
            btnCancel.LostFocus += onLostFocus;
            btnBreak.LostFocus += onLostFocus;
            btnExit.LostFocus += onLostFocus;
        }

        private void ctrlOnLostFocuspnlmid1()
        {
            foreach (Control i in pnlMid1.Controls)
            {
                if (i is TextBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }
        private void ctrlOnLostFocuspnlmid2()
        {
            foreach (Control i in pnlMid2.Controls)
            {
                if (i is TextBox)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }


        // for removing all the text from cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach(Control c in pnlFetch.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }

            foreach (Control c in pnlBreak.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

            foreach (Control c in pnlMid1.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }

            foreach(Control c in pnlMid2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = ""; 
                }
            }

            txtCertID.Focus();
        }


        // for exiting the current form 
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmbreakFD()
        {
            InitializeComponent();

            setConnection();

            ctrlOnFocuspnl1();
            ctrlOnFocuspnl2();
            ctrlOnFocuspnl3();
            ctrlOnFocuspnlmid1();
            ctrlOnFocuspnlmid2();

            ctrlOnLostFocuspnl1();
            ctrlOnLostFocuspnl2();
            ctrlOnLostFocuspnl3();
            ctrlOnLostFocuspnlmid1();
            ctrlOnLostFocuspnlmid2();

            btnBreak.Enabled = false;

            rbdPayInterest.Enabled = false;
            rbdBreakFD.Enabled = false;
        }


        int periodic_intr;



        private void pay_intr_cal(int m1 , int m2)// m1= num of days and m2= num of months
        {
            OleDbCommand cmd1 = new OleDbCommand("select paid_intr from FD_transection where cert_id = " + txtCertID.Text, conn);
            int paid_intr = (int)cmd1.ExecuteScalar();

            btnBreak.Text = "Pay Interest";
            DateTime curr = DateTime.Now;
            DateTime mature = DateTime.Parse(dtpMatureDate.Text);
            DateTime last_paid = DateTime.Parse(dtplastpaid.Text);
            TimeSpan diff = curr - last_paid;

            //difference between current date and lastpaid date in days
            int diffi = diff.Days;

            //difference between current date and lastpaid date in months
            //int diff_month = (int)Math.Floor(diff.Days / 30.44);
            int diff_month = (int)(diff.Days / m1);

            //to disable button if the elsped days are less than month
            if ((int.Parse(txtelapsed_days.Text) < m1) && btnBreak.Text == "Pay Interest")
            {
                btnBreak.Enabled = false;
            }
            if (curr < mature)
            {
                if (curr < dtpStartDate.Value.AddMonths(m2))
                {
                    txtpayable_intr.Text = "0";
                    txtPaid_intr.Text = "0";
                }
                else if (diffi >= m1)
                {
                    txtpayable_intr.Text = (periodic_intr * diff_month).ToString();
                }
                else
                {
                    txtpayable_intr.Text = "0";
                }
            }
            else// FD matured
            {
                TimeSpan diff_mature = mature - last_paid;
                int diff_mon_mature = (int)(diff_mature.Days / m1);
                txtpayable_intr.Text = (periodic_intr * diff_mon_mature).ToString();
                txtPaid_intr.Text = paid_intr.ToString();

                rbdBreakFD.Checked = true;
                rbdPayInterest.Enabled = false;
                MessageBox.Show("FD is Matured");
            }
            //disabling pay button when payble interest =0;
            if (txtpayable_intr.Text == "0")
            {
                btnBreak.Enabled = false;
            }
        }



        private void rbdPayInterest_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdPayInterest.Checked && !string.IsNullOrEmpty(txtCertID.Text))
            {
                OleDbCommand cmd1 = new OleDbCommand("select Period_intr from FD_master where cert_id = " + txtCertID.Text, conn);
                string period = (string)cmd1.ExecuteScalar();

                switch (period)
                {
                    case "Monthly":
                        pay_intr_cal(30, 1);
                        break;

                    case "Quarterly":
                        pay_intr_cal(90, 3);
                        break;

                    case "Half yearly":
                        pay_intr_cal(180, 6);
                        break;

                    case "Interest payout on maturity":
                        rbdBreakFD.Checked = true;
                        rbdPayInterest.Enabled = false;
                        break;

                    default:
                        break;
                }
                if (double.TryParse(txtpayable_intr.Text, out double value) && value != 0)
                {
                    btnBreak.Enabled = true;
                }

            }

        }



        private void rbdBreakFD_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                if (string.IsNullOrEmpty(txtpayable_intr.Text))
                {
                    txtpayable_intr.Text = "0";
                }

                btnBreak.Text = "Break";

                dtpWith_date.MaxDate = DateTime.Now.AddDays(1).Date;
                dtpWith_date.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");

                int amount = Convert.ToInt32(txtFDAmount.Text);

                OleDbCommand cmd = new OleDbCommand("select p_interest from interest_master where duration = '" + txtPeriod.Text + "'", conn);
                double temp = Convert.ToDouble(cmd.ExecuteScalar());
                double penIntrDiff = Convert.ToDouble(txtinterestRate.Text) - temp;
                txtpen_intr.Text = penIntrDiff.ToString();

                if (DateTime.Now.Date < dtpMatureDate.Value.Date)   // if he wants to break before matuarity
                {
                    if (DateTime.Now < dtpStartDate.Value.AddMonths(1))  //he is breaking fd before month
                    {
                        txtWith_amt.Text = amount.ToString();
                        txtpen_intr.Text = "0";
                    }
                    else if (dtplastpaid.Value >= dtpStartDate.Value)  // he is breaking fd after one month
                    {
                        TimeSpan d = DateTime.Now - dtpStartDate.Value;
                        int diff = d.Days;
                        double tot_intr = ((amount * diff / 365 * penIntrDiff) / 100);
                        txtWith_amt.Text = (amount + tot_intr - Convert.ToInt32(txtPaid_intr.Text)).ToString();
                    }
                }
                else  //when fd matures completely
                {
                    TimeSpan d = dtpMatureDate.Value - dtplastpaid.Value;
                    int diff = d.Days;
                    double rem_intr = ((amount * diff / 365 * Convert.ToDouble(txtinterestRate.Text)) / 100);
                    txtWith_amt.Text = (amount + Convert.ToInt32(txtPaid_intr.Text) + rem_intr).ToString("0");
                    txtpen_intr.Text = "0";
                }

                if (double.TryParse(txtWith_amt.Text, out double value) && value != 0)
                {
                    btnBreak.Enabled = true;
                }
                else
                {
                    btnBreak.Enabled = false;
                }
            }

        }

        private void btnFetchDetails_Click(object sender, EventArgs e)
        {
           try
            {
                // To disable radio button if curr date > mature date
                OleDbCommand cmdMatureDate = new OleDbCommand("select mature_dt from fd_master where cert_id = " + txtCertID.Text, conn);
                var mDate = DateTime.Parse(cmdMatureDate.ExecuteScalar().ToString());

                if(DateTime.Now.Date > mDate)
                {
                    rbdPayInterest.Enabled = false;
                }
                else
                {
                    rbdPayInterest.Enabled = true;
                }

                if (!string.IsNullOrEmpty(txtCertID.Text))
                {
                    OleDbCommand cmd = new OleDbCommand("select * from FD_master where cert_id = " + txtCertID.Text, conn);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    OleDbCommand cmd1 = new OleDbCommand("select * from FD_transection where cert_id = " + txtCertID.Text, conn);
                    OleDbDataReader dr1 = cmd1.ExecuteReader();

                    if (dr.HasRows && dr1.HasRows)
                    {
                        while (dr.Read() && dr1.Read())
                        {
                            if (dr["status"].ToString() == "Open")
                            {

                                txtName.Text = dr["C_name"].ToString();
                                txtFD_ID.Text = dr["FD_ID"].ToString();
                                txtFDStatus.Text = dr["status"].ToString();
                                txtFDAmount.Text = dr["FD_amount"].ToString();
                                txtFinalAmount.Text = dr["Mature_amount"].ToString();

                                dtpStartDate.MaxDate = DateTime.Now.AddDays(1);
                                dtpStartDate.Text = dr["Cert_dt"].ToString();

                                DateTime dt = DateTime.Parse(dr["Mature_dt"].ToString());
                                dtpMatureDate.MaxDate = dt;
                                dtpMatureDate.Value = dt;

                                txtPeriod.Text = dr["FD_type"].ToString();
                                txtelapsed_days.Text = (DateTime.Now.Subtract(dtpStartDate.Value).TotalDays).ToString("0");
                                txtinterestRate.Text = dr["intr_rate"].ToString();
                                txtTotalInterest.Text = dr["Total_intr"].ToString();

                                txtPaid_intr.Text = dr1["paid_intr"].ToString();

                                dtplastpaid.MaxDate = DateTime.Now;
                                dtplastpaid.Text = dr1["last_pay_date"].ToString();

                                periodic_intr = int.Parse(dr["Periodic_intr"].ToString());

                                if (!string.IsNullOrEmpty(txtpayable_intr.Text))
                                {
                                    btnBreak.Enabled = false;
                                }

                                rbdBreakFD.Enabled = true;
                                rbdPayInterest.Enabled = true;
                            }
                            else
                            {
                                // exception la taklay. else kadhych ka?
                                MessageBox.Show("Cant load data : FD is already broke");
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("No data found for id " + txtCertID.Text);
                        txtCertID.Text = "";
                        txtName.Text = "";
                        txtCertID.Focus();
                    }
                }
                else
                {
                    err.SetError(txtCertID, "Enter ID");
                    txtCertID.Focus();
                }

            }

            catch(NullReferenceException)
            {
                MessageBox.Show("No data found for the Certificate ID: " + txtCertID.Text);
                txtCertID.Clear();
                txtCertID.Focus();
            }

            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
        }

        private void pnlButtons_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cal_Break()
        {
            OleDbCommand cmd1 = new OleDbCommand("select paid_intr from FD_transection where cert_id = " + txtCertID.Text, conn);
            int paid_intr = (int)cmd1.ExecuteScalar();

            //if(DateTime.Now >= dtpStartDate.Value.ad)
            
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            if (btnBreak.Text == "Pay Interest")
            {
                if (!string.IsNullOrEmpty(txtPaid_intr.Text) && !string.IsNullOrEmpty(txtpayable_intr.Text))
                {
                    if (DateTime.Now < dtpMatureDate.Value)
                    {
                        var temp1 = txtPaid_intr.Text;
                        var temp2 = txtpayable_intr.Text;

                        txtPaid_intr.Text = (Convert.ToInt32(txtPaid_intr.Text) + Convert.ToInt32(txtpayable_intr.Text)).ToString();
                        txtpayable_intr.Text = "0";


                        DialogResult res = MessageBox.Show("Do you want to pay? /n Rs." + temp2 + "/-", "Confirm", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            OleDbCommand cmd = new OleDbCommand("update fd_transection set paid_intr = " + txtPaid_intr.Text + ", last_pay_date = #" + DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss") + "# where cert_id = " + txtCertID.Text, conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Interest Paid");
                            btnBreak.Enabled = false;
                        }
                        else
                        {
                            txtPaid_intr.Text = temp1;
                            txtpayable_intr.Text = temp2;
                        }
                    }
                }
            }
            else if (btnBreak.Text == "Break")
            {               
                if(!string.IsNullOrEmpty(txtWith_amt.Text) && !string.IsNullOrEmpty(txtpen_intr.Text))
                {
                    DialogResult res = MessageBox.Show("Do you want to break the FD?", "Confirm", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        // update status in tables fd_transection and insert data into break_fd table
                        OleDbCommand cmdUpdateStatus = new OleDbCommand("update fd_master set status = 'Break' where cert_id = " + txtCertID.Text, conn);
                        cmdUpdateStatus.ExecuteNonQuery();

                        OleDbCommand cmdUpdateStatus1 = new OleDbCommand("update fd_transection set fd_status = 'Break' where cert_id = " + txtCertID.Text, conn);
                        cmdUpdateStatus1.ExecuteNonQuery();
                            
                        // record is deleted automatically after updating status in transection table
                        OleDbCommand cmdGetInfo = new OleDbCommand("select * from fd_master where cert_id = " + txtCertID.Text, conn);
                        OleDbDataReader dr = cmdGetInfo.ExecuteReader();

                        OleDbCommand cmdGetPenIntr = new OleDbCommand("select * from Interest_master where duration = '" + txtPeriod.Text + "'", conn);
                        OleDbDataReader dr1 = cmdGetPenIntr.ExecuteReader();
                        double penIntr = double.Parse(txtinterestRate.Text) - double.Parse(txtpen_intr.Text) ;

                        int cid = 0, mon = 0, day = 0, totalDays = 0;
                        DateTime certDate = DateTime.Today;
                        string fdType = "", matAmt = "";

                        if(dr.HasRows)
                        {
                            while(dr.Read())
                            {
                                cid = Convert.ToInt32(dr["c_id"].ToString());
                                certDate = DateTime.Parse(dr["cert_dt"].ToString());
                                mon = Convert.ToInt32(dr["period_mon"].ToString());
                                day = Convert.ToInt32(dr["period_day"].ToString());
                                fdType = dr["fd_type"].ToString();
                                matAmt = dr["mature_amount"].ToString();
                                totalDays = Convert.ToInt32(dr["total_days"].ToString());
                            }
                        }
                        dr.Close();

                        OleDbCommand cmdInsert = new OleDbCommand("insert into break_fd values (" + txtFD_ID.Text + ", '" + cid + "', '" + txtName.Text + "', #" + certDate + "#, " + txtCertID.Text + ", #" + dtpMatureDate.Value + "#, " + mon + ", " + day + ", '" + "Break" + "', '" + fdType + "', " + txtinterestRate.Text + ", " + txtFDAmount.Text + ", " + matAmt + ", " + txtTotalInterest.Text + ", " + totalDays + ", " + periodic_intr + ", " + txtWith_amt.Text + ", #" + dtpWith_date.Value + "#, " + txtPaid_intr.Text + ", " + penIntr + ")", conn);
                        cmdInsert.ExecuteNonQuery();

                        MessageBox.Show("Your fd is breaked");
                        btnBreak.Enabled = false;
                    }
                    else if (res == DialogResult.No)
                    {

                    }

                }
                else
                {
                    btnBreak.Enabled = false;
                }
            }
        }

        private void txtCertID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCertID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtCertID.Text))
                {
                    btnFetchDetails.PerformClick();
                }
                else
                {
                    MessageBox.Show("Please enter Customer ID");
                    txtCertID.Focus();
                }
            }
        }
    }
}
