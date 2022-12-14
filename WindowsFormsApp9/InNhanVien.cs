using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class InNhanVien : Form
    {
        public InNhanVien()
        {
            InitializeComponent();
        }

        private void InNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp9.ReportNhanVien.rdlc";
                ReportDataSource rp = new ReportDataSource();
                rp.Name = "DataSet1";
                rp.Value = db.NVs;
                reportViewer1.LocalReport.DataSources.Add(rp);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
