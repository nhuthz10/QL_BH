using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class frmhoadon : Form
    {
        public frmhoadon()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void Napmahoadon()
        {
            cbbmhd.DataSource = db.HoaDons.ToList();
            cbbmhd.ValueMember = "MaHoaDon";
            cbbmhd.DisplayMember = "MaHoaDon";
        }
        public void Napmanhanvien()
        {
            cbbmnv.DataSource = db.NVs.ToList();
            cbbmnv.ValueMember = "MaNV";
            cbbmnv.DisplayMember = "MaNV";
        }
        public void Naphoadon()
        {
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
            dataGridView1.DataSource = rs.ToList();
        } 
        private void frmhoadon_Load(object sender, EventArgs e)
        {
            Napmahoadon();
            Napmanhanvien();
            Naphoadon();
        }
        public void ResetLoad()
        {
            Naphoadon();
            Napmahoadon();
            Naphoadon();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbmhd.Text == "" || cbbmnv.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    return;
                }
                HoaDon hd = new HoaDon();
                hd.MaHoaDon = cbbmhd.Text;
                hd.MaNV = cbbmnv.Text;
                hd.NgayHoaDon = dateTimePicker1.Value;
                db.HoaDons.InsertOnSubmit(hd);
                db.SubmitChanges();
                ResetLoad();
                MessageBox.Show("Đã thêm thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (cbbmhd.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
                return;
            }
            try
            {
                HoaDon hd = db.HoaDons.FirstOrDefault(x => x.MaHoaDon == cbbmhd.Text);
                if (hd != null)
                {
                    db.HoaDons.DeleteOnSubmit(hd);
                    db.SubmitChanges();
                    ResetLoad();
                    MessageBox.Show("Đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Hóa đơn này không tồn tại");
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            cbbmhd.Text = dataGridView1.CurrentRow.Cells["MaHoaDon"].Value.ToString();
            cbbmnv.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NgayHoaDon"].Value.ToString();
        }
    }
}
