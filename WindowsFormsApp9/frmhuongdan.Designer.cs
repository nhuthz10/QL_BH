namespace WindowsFormsApp9
{
    partial class frm_HuongDanCaiDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HuongDanCaiDat));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.btn_tieptuc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(993, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_import
            // 
            this.btn_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_import.Location = new System.Drawing.Point(210, 38);
            this.btn_import.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(148, 71);
            this.btn_import.TabIndex = 3;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_quaylai.Location = new System.Drawing.Point(426, 38);
            this.btn_quaylai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(148, 71);
            this.btn_quaylai.TabIndex = 4;
            this.btn_quaylai.Text = "<<";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // btn_tieptuc
            // 
            this.btn_tieptuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_tieptuc.Location = new System.Drawing.Point(648, 38);
            this.btn_tieptuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_tieptuc.Name = "btn_tieptuc";
            this.btn_tieptuc.Size = new System.Drawing.Size(148, 71);
            this.btn_tieptuc.TabIndex = 5;
            this.btn_tieptuc.Text = ">>";
            this.btn_tieptuc.UseVisualStyleBackColor = true;
            this.btn_tieptuc.Click += new System.EventHandler(this.btn_tieptuc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // frm_HuongDanCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp9.Properties.Resources.gradient_blue_color1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 657);
            this.Controls.Add(this.btn_tieptuc);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HuongDanCaiDat";
            this.Text = "Hướng Dẫn Sử Dụng";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button btn_tieptuc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}