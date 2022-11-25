using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp9;

namespace WindowsFormsApp1
{
    public partial class frmquanlynhanvien : Form
    {
        

        public frmquanlynhanvien()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            using (DataClasses1DataContext dt = new DataClasses1DataContext())
            {
                dataGridView1.DataSource = dt.NVs.Select(d => d);
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[4].Width = 200;
                dataGridView1.Columns[5].Width = 200;
                dataGridView1.Columns[6].Width = 170;

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_manv.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            tb_tennv.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            dt_ngaysinh.Text = dataGridView1.CurrentRow.Cells["NamSinh"].Value.ToString();
            tb_diachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            tb_dienthoai.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
            dt_ngayvaolam.Text = dataGridView1.CurrentRow.Cells["NCL"].Value.ToString();
            tb_luong.Text = dataGridView1.CurrentRow.Cells["Luong"].Value.ToString();

        }

    private void btn_them_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dt = new DataClasses1DataContext())
            {
                NV them = new NV();
                them.MaNV = tb_manv.Text;
                them.HoTen = tb_tennv.Text;
                them.DiaChi = tb_diachi.Text;
                them.SDT = tb_dienthoai.Text;
                them.Luong = int.Parse(tb_luong.Text);
                them.NamSinh = DateTime.ParseExact(dt_ngaysinh.Text, "d/M/yyyy", null);
                them.NCL = DateTime.ParseExact(dt_ngayvaolam.Text, "d/M/yyyy", null);
                dt.NVs.InsertOnSubmit(them);
                dt.SubmitChanges();
            }
            loadData();
        }

        private void btn_khoitao_Click(object sender, EventArgs e)
        {
            tb_manv.Text = "";
            tb_tennv.Text = "";
            tb_diachi.Text = "";
            tb_dienthoai.Text = "";
            tb_luong.Text = "";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dt = new DataClasses1DataContext())
            {
                string id = dataGridView1.SelectedCells[0].OwningRow.Cells["MaNV"].Value.ToString();
                NV delete = dt.NVs.Where(p => p.MaNV.Equals(id)).SingleOrDefault();
                dt.NVs.DeleteOnSubmit(delete);
                dt.SubmitChanges();
            }
            loadData();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dt = new DataClasses1DataContext())
            {
                if (txt_timkiem.Text == "") loadData();
                else
                {
                    dataGridView1.DataSource = dt.NVs.Where(p => p.MaNV.Equals(txt_timkiem.Text));
                }
            }
        }
    }
}
