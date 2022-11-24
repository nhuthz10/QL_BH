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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string tentk = txtdangnhap.Text;
            string mk = txtmatkhau.Text;


            //Check data
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản"); return; }
            else if (mk.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu"); return; }
            //Query data
            using (DataClasses1DataContext dataClass1 = new DataClasses1DataContext())
            {
                var dangnhap = dataClass1.TaiKhoans.Where(p => p.TenTaiKhoan == tentk && p.MatKhau == mk);


                if (dangnhap != null)
                {
                    MessageBox.Show("Đăng nhập thành công");

                    Form2 form = new Form2();
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng");
                }
            }
        } 
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }
    }

    
    
}
