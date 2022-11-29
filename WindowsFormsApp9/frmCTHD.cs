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
    public partial class frmCTHD : Form
    {
        public frmCTHD()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void NapMaHoaDon()
        {
            cbbmhd.DataSource = db.HoaDons.ToList();
            cbbmhd.ValueMember = "MaHoaDon";
            cbbmhd.DisplayMember = "MaHoaDon";
        }
        public void Napmonan()
        {
            cbbtma.DataSource = db.MonAns.ToList();
            cbbtma.ValueMember = "MaMonAn";
            cbbtma.DisplayMember = "MaMonAn";
        }
        public void NapCTDH()
        {
                var cthd = from ct in db.CTHDs.Where(a => a.MaHoaDon == cbbmhd.Text)
                           select new
                           {
                               MaHoaDon = ct.MaHoaDon,
                               MaMonAn = ct.MaMonAn,
                               SoLuong = ct.SoLuong,
                               DonGia = ct.DonGia
                           };
                dataGridView1.DataSource = cthd.ToList();
        }
        public void NapThanhTien()
        {
            var s = from h in db.HoaDons.Where(a=>a.MaHoaDon == cbbmhd.Text)
                    join ct in db.CTHDs.GroupBy(x => x.MaHoaDon) on h.MaHoaDon equals ct.First().MaHoaDon
                    select new
                    {
                        Value = ct.Sum(x => x.DonGia * x.SoLuong)
                    };
            if (s.FirstOrDefault(a=>a.Value != null) == null)
                txtthanhtien.Text = "0";
            else
            {
                txtthanhtien.Text = s.First().Value.ToString();
            }    
        }

        private void frmCTHD_Load(object sender, EventArgs e)
        {
            NapMaHoaDon();
            Napmonan();
            NapCTDH();
            NapThanhTien();
        }

        private void cbbmhd_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapCTDH();
            NapThanhTien();
        }
        public void ResetLoad()
        {
            NapMaHoaDon();
            Napmonan();
            NapCTDH();
            NapThanhTien();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbmhd.Text == "" || cbbtma.Text == "" || txtsl.Text == "" || txtdg.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    return;
                }
                CTHD ct = new CTHD();
                ct.MaHoaDon = cbbmhd.Text;
                ct.DonGia = int.Parse(txtdg.Text);
                ct.SoLuong = int.Parse(txtsl.Text);
                ct.MaMonAn = cbbtma.Text;
                db.CTHDs.InsertOnSubmit(ct);
                db.SubmitChanges();
                ResetLoad();
                MessageBox.Show("Đã thêm thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbbmhd.Text == "" || cbbtma.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
                return;
            }
            try
            {
                CTHD ct = db.CTHDs.FirstOrDefault(x => x.MaMonAn == cbbtma.Text && x.MaHoaDon == cbbmhd.Text);
                ct.DonGia = int.Parse(txtdg.Text);
                ct.SoLuong = int.Parse(txtsl.Text);
                db.SubmitChanges();
                ResetLoad();
                MessageBox.Show("Đã cập nhật thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbbmhd.Text == "" || cbbtma.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
                return;
            }
            try
            {
                CTHD ct = db.CTHDs.FirstOrDefault(x => x.MaMonAn == cbbtma.Text && x.MaHoaDon == cbbmhd.Text);
                if (ct != null)
                {
                    db.CTHDs.DeleteOnSubmit(ct);
                    db.SubmitChanges();
                    ResetLoad();
                    MessageBox.Show("Đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Chi tiết hóa đơn này không tồn tại");
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
            cbbtma.Text = dataGridView1.CurrentRow.Cells["MaMonAn"].Value.ToString();
            txtdg.Text = dataGridView1.CurrentRow.Cells["DonGia"].Value.ToString();
            txtsl.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
        }

        private void thoat_form_exit(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Chi tiết Hóa Đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
