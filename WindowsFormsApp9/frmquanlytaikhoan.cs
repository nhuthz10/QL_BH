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
                if(tb_ChucVu.Text == "" || tb_HoTen.Text == "" || tb_Pass.Text == "" || tb_User.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                }    
                try 
                {
                    TaiKhoan themTK = new TaiKhoan();
                    themTK.HovaTen = tb_HoTen.Text;
                    themTK.ChucVu = tb_ChucVu.Text;
                    themTK.TenTaiKhoan = tb_User.Text;
                    themTK.MatKhau = tb_Pass.Text;
                    dt.TaiKhoans.InsertOnSubmit(themTK);
                    dt.SubmitChanges();
                    loadDataTaiKhoan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }          
        }

        private void btn_Xoa(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dt = new DataClasses1DataContext())
            {
                if (tb_User.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    return;
                }                   
                try 
                {
                    TaiKhoan delete = dt.TaiKhoans.FirstOrDefault(a => a.TenTaiKhoan == tb_User.Text);
                    if(delete != null)
                    {
                        dt.TaiKhoans.DeleteOnSubmit(delete);
                        dt.SubmitChanges();
                        loadDataTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại tài khoản này");
                    }                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_Khoitao(object sender, EventArgs e)
        {
            tb_HoTen.Text = "";
            tb_ChucVu.Text = "";
            tb_User.Text = "";
            tb_Pass.Text = "";
        }

        private void dataView_Click(object sender, EventArgs e)
        {
            tb_HoTen.Text = dataView.CurrentRow.Cells["HovaTen"].Value.ToString();
            tb_ChucVu.Text = dataView.CurrentRow.Cells["ChucVu"].Value.ToString();
            tb_User.Text = dataView.CurrentRow.Cells["TenTaiKhoan"].Value.ToString();
            tb_Pass.Text = dataView.CurrentRow.Cells["MatKhau"].Value.ToString();
        }
    }
}
