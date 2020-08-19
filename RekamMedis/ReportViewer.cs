using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
namespace RekamMedis
{
    public partial class ReportViewer : Form
    {
        public ReportViewer(ReportClass rpt)
        {
            InitializeComponent();
            InitializeReport(rpt);
        }
        private void InitializeReport(ReportClass rpt)
        {
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Zoom(1);
            this.crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;
        }
        private void ReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
