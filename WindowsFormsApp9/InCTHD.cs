using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace WindowsFormsApp9
{
    public partial class InCTHD : Form
    {
        private string mhd;
        public InCTHD()
        {
            InitializeComponent();
        }
        public InCTHD( string mhd)
        {
            InitializeComponent();
            this.mhd = mhd;
        }
        private void InCTHD_Load(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp9.Report1.rdlc";
                ReportDataSource rp = new ReportDataSource();
                rp.Name = "DataSet1";
                rp.Value = db.CTHDs.Where(a=>a.MaHoaDon == mhd);
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
