﻿using System;
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
    public partial class frmcreatecustomer : Form
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

        private void ctrlOnFocussPnl1()
        {
            foreach(Control i in pnldetails.Controls)
            {
                if(i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocussPnl2()
        {
            foreach (Control i in pnlminor.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocussPnl3()
        {
            foreach (Control i in pnlnominee.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }

        private void ctrlOnFocussPnl4()
        {
            foreach (Control i in pnlbuttons.Controls)
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
            foreach (Control i in pnldetails.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocussPnl2()
        {
            foreach (Control i in pnlminor.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocussPnl3()
        {
            foreach (Control i in pnlnominee.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void ctrlOnLostFocussPnl4()
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

        // just like main() for form
        public frmcreatecustomer()
        {
            InitializeComponent();

            ctrlOnFocussPnl1();
            ctrlOnFocussPnl2();
            ctrlOnFocussPnl3();
            ctrlOnFocussPnl4();
            ctrlOnLostFocussPnl1();
            ctrlOnLostFocussPnl2();
            ctrlOnLostFocussPnl3();
            ctrlOnLostFocussPnl4();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void chbminor_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void txtgaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgrelation_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlminor_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}