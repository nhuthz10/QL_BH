namespace WindowsFormsApp9
{
    partial class frmloaimonan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmloaimonan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaLoaiMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.cbbtlma = new System.Windows.Forms.ComboBox();
            this.cbbmlma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(367, 270);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các loại món ăn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiMonAn,
            this.TenLoaiMonAn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(367, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // MaLoaiMonAn
            // 
            this.MaLoaiMonAn.DataPropertyName = "MaLoaiMonAn";
            this.MaLoaiMonAn.HeaderText = "Mã Loại Món Ăn";
            this.MaLoaiMonAn.MinimumWidth = 8;
            this.MaLoaiMonAn.Name = "MaLoaiMonAn";
            this.MaLoaiMonAn.Width = 150;
            // 
            // TenLoaiMonAn
            // 
            this.TenLoaiMonAn.DataPropertyName = "TenLoaiMonAn";
            this.TenLoaiMonAn.HeaderText = "Tên Loại Món Ăn";
            this.TenLoaiMonAn.MinimumWidth = 8;
            this.TenLoaiMonAn.Name = "TenLoaiMonAn";
            this.TenLoaiMonAn.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btncapnhat);
            this.groupBox2.Controls.Add(this.cbbtlma);
            this.groupBox2.Controls.Add(this.cbbmlma);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(396, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(269, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các loại món ăn";
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Location = new System.Drawing.Point(17, 157);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(56, 31);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Location = new System.Drawing.Point(197, 157);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(58, 31);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btncapnhat.ForeColor = System.Drawing.Color.Black;
            this.btncapnhat.Location = new System.Drawing.Point(95, 157);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(82, 31);
            this.btncapnhat.TabIndex = 1;
            this.btncapnhat.Text = "Sửa";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // cbbtlma
            // 
            this.cbbtlma.FormattingEnabled = true;
            this.cbbtlma.Location = new System.Drawing.Point(135, 111);
            this.cbbtlma.Margin = new System.Windows.Forms.Padding(2);
            this.cbbtlma.Name = "cbbtlma";
            this.cbbtlma.Size = new System.Drawing.Size(117, 24);
            this.cbbtlma.TabIndex = 1;
            // 
            // cbbmlma
            // 
            this.cbbmlma.FormattingEnabled = true;
            this.cbbmlma.Location = new System.Drawing.Point(135, 40);
            this.cbbmlma.Margin = new System.Windows.Forms.Padding(2);
            this.cbbmlma.Name = "cbbmlma";
            this.cbbmlma.Size = new System.Drawing.Size(117, 24);
            this.cbbmlma.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại món ăn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại món ăn:";
            // 
            // frmloaimonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp9.Properties.Resources.art_colors;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 297);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmloaimonan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Món Ăn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.thoat_LoaiMonAn);
            this.Load += new System.EventHandler(this.frmloaimonan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiMonAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.ComboBox cbbtlma;
        private System.Windows.Forms.ComboBox cbbmlma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}