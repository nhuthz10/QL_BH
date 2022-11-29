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
    public partial class frm_HuongDanCaiDat : Form
    {
        public frm_HuongDanCaiDat()
        {
            InitializeComponent();
        }
        int number_img = 0;

        private void btn_quaylai_Click(object sender, EventArgs e)
        {

            if (number_img > 0)
            {
                number_img = number_img - 1;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[number_img]);
            }
        }

        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            if (number_img < openFileDialog1.FileNames.Length - 1)
            {
                number_img = number_img + 1;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[number_img]);
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {

            number_img = 0;
            openFileDialog1.Filter = "Images File |*.png; *.ipg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[number_img]);
            }
        }

        private void thoat_HDSD(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Hướng Dẫn Cài Đặt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
