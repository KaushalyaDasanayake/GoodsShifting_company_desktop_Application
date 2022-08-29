using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace E_shift_Management_System
{
    public partial class OperationReport : Form
    {
        public OperationReport()
        {
            InitializeComponent();
        }

        private void OperationReport_Load(object sender, EventArgs e)
        {
            CrystalReport1 objrpt = new CrystalReport1();
            objrpt.Load();
            crystalReportViewer1.ReportSource = objrpt;
            crystalReportViewer1.Show();
        }
    }
}
