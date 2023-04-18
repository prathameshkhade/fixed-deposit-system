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
            }
        }

        private void cmbReportType_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbReportType_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if(cmbReportType.Text == "Customer wise Report")
            {

            }

            if (cmbReportType.Text == "Date wise report")
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
         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
