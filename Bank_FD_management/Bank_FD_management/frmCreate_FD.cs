using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_FD_management
{
    public partial class frmCreate_FD : Form
    {

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


        //for every panel lost focus and got focus
        private void ctrlOnFocussPnl1()
        {
            foreach (Control i in pnlDetails.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocussPnl2()
        {
            foreach (Control i in pnlRates.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocussPnl3()
        {
            foreach (Control i in pnlButtons.Controls)
            {
                if (i is Button)
                {
                    i.GotFocus += onFocus;
                }
            }
        }


        // just for on lost focusing the seperate panel
        private void ctrlOnLostFocussPnl1()
        {
            foreach (Control i in pnlDetails.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocussPnl2()
        {
            foreach (Control i in pnlRates.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocussPnl3()
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

            ctrlOnFocussPnl1();
            ctrlOnFocussPnl2();
            ctrlOnFocussPnl3();
            ctrlOnLostFocussPnl1();
            ctrlOnLostFocussPnl2();
            ctrlOnLostFocussPnl3();
        }
    }
}
