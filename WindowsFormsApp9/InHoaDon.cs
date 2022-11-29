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
    public partial class InHoaDon : Form
    {
        private string mhd;
        public InHoaDon()
        {
            InitializeComponent();
        }
        public InHoaDon(string mhd)
        {
            InitializeComponent();
            this.mhd = mhd;
        }


        private void InHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp9.ReportHD.rdlc";
                ReportDataSource rp = new ReportDataSource();
                rp.Name = "DataSet1";
                var s = from h in db.HoaDons
                        join ct in db.CTHDs.GroupBy(x => x.MaHoaDon) on h.MaHoaDon equals ct.First().MaHoaDon
                        select new
                        {
                            MaHoaDon = h.MaHoaDon,
                            Value = ct.Sum(x => x.DonGia * x.SoLuong)
                        };
                var rs = from h in db.HoaDons
                         select new
                         {
                             MaHoaDon = h.MaHoaDon,
                             MaNV = h.MaNV,
                             NgayHoaDon = h.NgayHoaDon,
                             ThanhTien = s.FirstOrDefault(a => a.MaHoaDon == h.MaHoaDon).Value
                         };
                rp.Value = rs.Where(a=>a.MaHoaDon==mhd).ToList();
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
