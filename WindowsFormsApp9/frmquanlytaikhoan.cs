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
    public partial class frmquanlytaikhoan : Form
    {
        public frmquanlytaikhoan()
        {
            InitializeComponent();
        }

        private void frmquanlytaikhoan_Load(object sender, EventArgs e)
        {
            loadDataTaiKhoan();
        }

        public void loadDataTaiKhoan()
        {
            using (DataClasses1DataContext dt = new DataClasses1DataContext())
            {
                dataView.DataSource = dt.TaiKhoans.Select(d => d);

            }
        }

        private void btn_Them(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dt = new DataClasses1DataContext())
            {
                TaiKhoan themTK = new TaiKhoan();
                themTK.HovaTen = tb_HoTen.Text;
                themTK.ChucVu = tb_ChucVu.Text;
                themTK.TenTaiKhoan = tb_User.Text;
                themTK.MatKhau = tb_Pass.Text;
                dt.TaiKhoans.InsertOnSubmit(themTK);
                dt.SubmitChanges();
            }
            loadDataTaiKhoan();
        }

        private void btn_Xoa(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dt = new DataClasses1DataContext())
            {
                string id = dataView.SelectedCells[0].OwningRow.Cells["TenTaiKhoan"].Value.ToString();
                TaiKhoan delete = dt.TaiKhoans.Where(p => p.TenTaiKhoan.Equals(id)).SingleOrDefault();
                dt.TaiKhoans.DeleteOnSubmit(delete);
                dt.SubmitChanges();
            }
            loadDataTaiKhoan();
        }

        private void btn_Khoitao(object sender, EventArgs e)
        {
            tb_HoTen.Text = "";
            tb_ChucVu.Text = "";
            tb_User.Text = "";
            tb_Pass.Text = "";
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
