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
    public partial class frmmonan : Form
    {
        public frmmonan()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void Napmaloaimonan()
        {
            cbblma.DataSource = db.LoaiMonAns.ToList();
            cbblma.ValueMember = "MaLoaiMonAn";
            cbblma.DisplayMember = "MaLoaiMonAn";
        }
        public void Napmonan()
        {
            var ma = db.MonAns.Select(a => new { a.MaLoaiMonAn, a.MaMonAn, a.TenMonAn });
            dataGridView1.DataSource = ma.ToList();
        }
        public void ResetLoad()
        {
            Napmaloaimonan();
            Napmonan();
        }

        private void frmmonan_Load(object sender, EventArgs e)
        {
            Napmaloaimonan();
            Napmonan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmloaimonan f = new frmloaimonan();
            f.ShowDialog();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            ResetLoad();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmma.Text == "" || txttma.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    return;
                }
                MonAn monAn = new MonAn();
                monAn.MaMonAn = txtmma.Text;
                monAn.TenMonAn = txttma.Text;
                monAn.MaLoaiMonAn = cbblma.Text;
                db.MonAns.InsertOnSubmit(monAn);
                db.SubmitChanges();
                ResetLoad();
                MessageBox.Show("Đã thêm thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmma.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
                return;
            }
            try
            {
                MonAn monAn = db.MonAns.FirstOrDefault(x => x.MaMonAn == txtmma.Text);
                monAn.TenMonAn = txttma.Text;
                monAn.MaLoaiMonAn = cbblma.Text;
                db.SubmitChanges();
                ResetLoad();
                MessageBox.Show("Đã cập nhật thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmma.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
                return;
            }
            try
            {
                MonAn monAn = db.MonAns.FirstOrDefault(x => x.MaMonAn == txtmma.Text);
                if (monAn != null)
                {
                    db.MonAns.DeleteOnSubmit(monAn);
                    db.SubmitChanges();
                    ResetLoad();
                    MessageBox.Show("Đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Món ăn này không tồn tại");
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            cbblma.Text = dataGridView1.CurrentRow.Cells["MaLoaiMonAn"].Value.ToString();
            txtmma.Text = dataGridView1.CurrentRow.Cells["MaMonAn"].Value.ToString();
            txttma.Text = dataGridView1.CurrentRow.Cells["TenMonAn"].Value.ToString();
        }

        private void thoat_Monan(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Món Ăn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
