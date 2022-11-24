namespace WindowsFormsApp9
{
    partial class frmmonan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txttma = new System.Windows.Forms.TextBox();
            this.txtmma = new System.Windows.Forms.TextBox();
            this.cbblma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaLoaiMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btncapnhat);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txttma);
            this.groupBox1.Controls.Add(this.txtmma);
            this.groupBox1.Controls.Add(this.cbblma);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 396);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn:";
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(149, 262);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(81, 51);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(113, 330);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(161, 51);
            this.btncapnhat.TabIndex = 3;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(283, 262);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(94, 51);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "---";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(6, 262);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(94, 51);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttma
            // 
            this.txttma.Location = new System.Drawing.Point(149, 179);
            this.txttma.Name = "txttma";
            this.txttma.Size = new System.Drawing.Size(187, 30);
            this.txttma.TabIndex = 2;
            // 
            // txtmma
            // 
            this.txtmma.Location = new System.Drawing.Point(149, 121);
            this.txtmma.Name = "txtmma";
            this.txtmma.Size = new System.Drawing.Size(187, 30);
            this.txtmma.TabIndex = 2;
            // 
            // cbblma
            // 
            this.cbblma.FormattingEnabled = true;
            this.cbblma.Location = new System.Drawing.Point(190, 58);
            this.cbblma.Name = "cbblma";
            this.cbblma.Size = new System.Drawing.Size(187, 33);
            this.cbblma.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên món ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã món ăn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại món ăn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(460, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 396);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách món ăn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiMonAn,
            this.MaMonAn,
            this.TenMonAn});
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(779, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // MaLoaiMonAn
            // 
            this.MaLoaiMonAn.DataPropertyName = "MaLoaiMonAn";
            this.MaLoaiMonAn.HeaderText = "Mã loại món ăn";
            this.MaLoaiMonAn.MinimumWidth = 8;
            this.MaLoaiMonAn.Name = "MaLoaiMonAn";
            this.MaLoaiMonAn.Width = 150;
            // 
            // MaMonAn
            // 
            this.MaMonAn.DataPropertyName = "MaMonAn";
            this.MaMonAn.HeaderText = "Mã món ăn";
            this.MaMonAn.MinimumWidth = 8;
            this.MaMonAn.Name = "MaMonAn";
            this.MaMonAn.Width = 150;
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Tên món ăn";
            this.TenMonAn.MinimumWidth = 8;
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Width = 150;
            // 
            // frmmonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmmonan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmonan";
            this.Load += new System.EventHandler(this.frmmonan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttma;
        private System.Windows.Forms.TextBox txtmma;
        private System.Windows.Forms.ComboBox cbblma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
    }
}