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
    public partial class frmloaimonan : Form
    {
        public frmloaimonan()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void Napmaloaimonan()
        {
            cbbmlma.DataSource = db.LoaiMonAns;
            cbbmlma.ValueMember = "MaLoaiMonAn";
            cbbmlma.DisplayMember = "MaLoaiMonAn";
        }
        public void Naptenloaimonan()
        {
            cbbtlma.DataSource = db.LoaiMonAns;
            cbbtlma.ValueMember = "TenLoaiMonAn";
            cbbtlma.DisplayMember = "TenLoaiMonAn";
        }
        public void Naploaimonan()
        {
            var lma = db.LoaiMonAns.Select(a => new { a.MaLoaiMonAn, a.TenLoaiMonAn });
            dataGridView1.DataSource = lma.ToList();
        }
        private void frmloaimonan_Load(object sender, EventArgs e)
        {
            Napmaloaimonan();
            Naptenloaimonan();
            Naploaimonan();
        }
        public void ResetLoad()
        {
            Naploaimonan();
            Napmaloaimonan();
            Naptenloaimonan();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbmlma.Text == "" && cbbtlma.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    return;
                }
                LoaiMonAn lam = new LoaiMonAn();
                lam.MaLoaiMonAn = cbbmlma.Text;
                lam.TenLoaiMonAn = cbbtlma.Text;
                db.LoaiMonAns.InsertOnSubmit(lam);
                db.SubmitChanges();
                ResetLoad();
                MessageBox.Show("Đã thêm thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (cbbmlma.SelectedValue == null && cbbtlma.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
                return;
            }
            try
            {
                string ma = cbbmlma.Text;
                LoaiMonAn lma = db.LoaiMonAns.FirstOrDefault(x => x.MaLoaiMonAn == ma);
                lma.TenLoaiMonAn = cbbtlma.Text;
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
            if (cbbmlma.SelectedValue == null && cbbtlma.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
                return;
            }
            try
            {
                LoaiMonAn lma = db.LoaiMonAns.FirstOrDefault(x => x.MaLoaiMonAn == cbbmlma.Text);
                if (lma != null)
                {
                    db.LoaiMonAns.DeleteOnSubmit(lma);
                    db.SubmitChanges();
                    ResetLoad();
                    MessageBox.Show("Đã xóa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            cbbmlma.Text = dataGridView1.CurrentRow.Cells["MaLoaiMonAn"].Value.ToString();
            cbbtlma.Text = dataGridView1.CurrentRow.Cells["TenLoaiMonAn"].Value.ToString();
        }
    }
}
