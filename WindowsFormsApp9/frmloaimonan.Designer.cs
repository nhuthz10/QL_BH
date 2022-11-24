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
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 415);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các loại món ăn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiMonAn,
            this.TenLoaiMonAn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(551, 369);
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
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btncapnhat);
            this.groupBox2.Controls.Add(this.cbbtlma);
            this.groupBox2.Controls.Add(this.cbbmlma);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(594, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 295);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các loại món ăn";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(25, 242);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(84, 47);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(296, 242);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 47);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(142, 242);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(123, 47);
            this.btncapnhat.TabIndex = 1;
            this.btncapnhat.Text = "Sửa";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // cbbtlma
            // 
            this.cbbtlma.FormattingEnabled = true;
            this.cbbtlma.Location = new System.Drawing.Point(202, 171);
            this.cbbtlma.Name = "cbbtlma";
            this.cbbtlma.Size = new System.Drawing.Size(174, 33);
            this.cbbtlma.TabIndex = 1;
            // 
            // cbbmlma
            // 
            this.cbbmlma.FormattingEnabled = true;
            this.cbbmlma.Location = new System.Drawing.Point(202, 62);
            this.cbbmlma.Name = "cbbmlma";
            this.cbbmlma.Size = new System.Drawing.Size(174, 33);
            this.cbbmlma.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại món ăn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại món ăn:";
            // 
            // frmloaimonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmloaimonan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmloaimonan";
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