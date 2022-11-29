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
    public partial class InTaiKhoan : Form
    {
        public InTaiKhoan()
        {
            InitializeComponent();
        }

        private void InTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp9.ReportTaiKhoan.rdlc";
                ReportDataSource rp = new ReportDataSource();
                rp.Name = "DataSet1";
                rp.Value = db.TaiKhoans;
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
