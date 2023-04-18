using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Data.OleDb;

namespace Bank_FD_management
{
    public partial class frmFD_reports : Form
    {
        public frmFD_reports()
        {
            InitializeComponent();
            dtpStartDate.Visible = false;
            dtpEndDate.Visible = false;
            txtID.Visible = false;
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            lblID.Visible = false;

            dtpEndDate.MaxDate = DateTime.Now;
            dtpStartDate.MaxDate = DateTime.Now;

            ctrlOnFocusPnl1();
            ctrlOnLostFocusPnl1();

            btnViewReport.Enabled = false;
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

        private void lblReport_Type_Click(object sender, EventArgs e)
        {

        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportType.Text == "Customer wise Report")
            {
                lblID.Visible = true;
                txtID.Visible = true;

                lblStartDate.Visible = false;
                dtpStartDate.Visible = false;
                lblEndDate.Visible = false;
                dtpEndDate.Visible = false;
            }
            else if(cmbReportType.Text == "Date wise report")
            {
                lblID.Visible = false;
                txtID.Visible = false;

                lblStartDate.Visible = true;
                dtpStartDate.Visible = true;
                lblEndDate.Visible = true;
                dtpEndDate.Visible = true;

                btnViewReport.Enabled = true;
            }
            else
            {
                dtpStartDate.Visible = false;
                dtpEndDate.Visible = false;
                txtID.Visible = false;
                lblStartDate.Visible = false;
                lblEndDate.Visible = false;
                lblID.Visible = false;
                btnViewReport.Enabled = false;
            }
        }

        private void cmbReportType_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbReportType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbReportType.Text == "Customer wise Report")
                {
                    txtID.Focus();
                }
                else
                {
                    dtpStartDate.Focus();
                }
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if(cmbReportType.Text == "Customer wise Report")
            {
                OleDbCommand cmd = new OleDbCommand("Select * from FD_Master where C_ID=" + txtID.Text,Program.conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ReportDocument crypt = new ReportDocument();
                    crypt.Load("C:/Users/Hiremath/source/repos/Fixed_deposite_system/Bank_FD_management/Bank_FD_management/Reports/ID_Report.rpt");
                    crypt.RecordSelectionFormula = "{FD_master.C_ID} =" + Convert.ToInt32(txtID.Text) + "";
                    crypt.Refresh();
                    CrystalReportViewer view1 = new CrystalReportViewer();
                    pnlTitle.Visible = false;
                    pnlDetails.Visible = false;
                    pnlButtons.Visible = false;
                    view1.Dock = DockStyle.Fill;
                    view1.ReportSource = crypt;
                    this.Controls.Add(view1);
                }
                else
                {
                    MessageBox.Show("the given Customer does not exists");
                }
            }

            if (cmbReportType.Text == "Date wise report")
            {
                OleDbCommand cmd = new OleDbCommand("Select * from FD_Master where Cert_dt >= #"+dtpStartDate.Value.ToString("yyyy-MM-dd") + "# and Cert_dt <= #" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "#", Program.conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ReportDocument crypt = new ReportDocument();
                    crypt.Load("C:/Users/Hiremath/source/repos/Fixed_deposite_system/Bank_FD_management/Bank_FD_management/Reports/Date_report.rpt");
                    crypt.RecordSelectionFormula = "{FD_master.Cert_dt} >= #" + dtpStartDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "# and {FD_master.Cert_dt} <= #" + dtpEndDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "# ";
                    crypt.DataDefinition.FormulaFields["tdate"].Text = "'" + dtpStartDate.Text + " TO " + dtpEndDate.Text + "'";
                    crypt.Refresh();
                    CrystalReportViewer crp = new CrystalReportViewer();
                    pnlTitle.Visible = false;
                    pnlDetails.Visible = false;
                    pnlButtons.Visible = false;
                    //crp.ReportSource = crypt;
                    //crp.Show();
                    crp.Dock = DockStyle.Fill;
                    crp.ReportSource = crypt;
                    this.Controls.Add(crp);
                }
                else
                {
                    MessageBox.Show("there is no data for given date interval");
                }
            }
         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbReportType_DropDown(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = -1;
            txtID.Text = "";
            btncancel.Enabled = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                btnViewReport.Enabled = true;
            }
        }

        private void dtpStartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnViewReport.Focus();
            }
        }
    }
}
