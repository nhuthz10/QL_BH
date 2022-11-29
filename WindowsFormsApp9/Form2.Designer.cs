namespace WindowsFormsApp9
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiMónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp9.Properties.Resources.Cac_mau_trang_tri_PowerPoint4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Moccasin;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangToolStripMenuItem,
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 36);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangToolStripMenuItem
            // 
            this.trangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem,
            this.thựcĐơnToolStripMenuItem,
            this.thôngTinNhânViênToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.trangToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangToolStripMenuItem.Image = global::WindowsFormsApp9.Properties.Resources.Home1;
            this.trangToolStripMenuItem.Name = "trangToolStripMenuItem";
            this.trangToolStripMenuItem.Size = new System.Drawing.Size(132, 32);
            this.trangToolStripMenuItem.Text = "Trang chủ";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem,
            this.chiTiếtHóaĐơnToolStripMenuItem});
            this.thanhToánToolStripMenuItem.Image = global::WindowsFormsApp9.Properties.Resources.icons8_thanhtoan;
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.btnThanhtoan);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Image = global::WindowsFormsApp9.Properties.Resources.icons8_thanhtoan;
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(254, 36);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // chiTiếtHóaĐơnToolStripMenuItem
            // 
            this.chiTiếtHóaĐơnToolStripMenuItem.Image = global::WindowsFormsApp9.Properties.Resources.icons_hoadon;
            this.chiTiếtHóaĐơnToolStripMenuItem.Name = "chiTiếtHóaĐơnToolStripMenuItem";
            this.chiTiếtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(254, 36);
            this.chiTiếtHóaĐơnToolStripMenuItem.Text = "Chi tiết hóa đơn";
            this.chiTiếtHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtHóaĐơnToolStripMenuItem_Click);
            // 
            // thựcĐơnToolStripMenuItem
            // 
            this.thựcĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiMónĂnToolStripMenuItem,
            this.mónĂnToolStripMenuItem});
            this.thựcĐơnToolStripMenuItem.Image = global::WindowsFormsApp9.Properties.Resources.icons8_restaurant_menu_32;
            this.thựcĐơnToolStripMenuItem.Name = "thựcĐơnToolStripMenuItem";
            this.thựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.thựcĐơnToolStripMenuItem.Text = "Thực đơn";
            this.thựcĐơnToolStripMenuItem.Click += new System.EventHandler(this.btnThucdon);
            // 
            // loạiMónĂnToolStripMenuItem
            // 
            this.loạiMónĂnToolStripMenuItem.Image = global::WindowsFormsApp9.Properties.Resources.icons8_type_food_32;
            this.loạiMónĂnToolStripMenuItem.Name = "loạiMónĂnToolStripMenuItem";
            this.loạiMónĂnToolStripMenuItem.Size = new System.Drawing.Size(221, 36);
            this.loạiMónĂnToolStripMenuItem.Text = "Loại món ăn";
            this.loạiMónĂnToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.loạiMónĂnToolStripMenuItem.Click += new System.EventHandler(this.loạiMónĂnToolStripMenuItem_Click);
            // 
            // mónĂnToolStripMenuItem
            // 
            this.mónĂnToolStripMenuItem.Image = global::WindowsFormsApp9.Properties.Resources.icons8_halal_food_32;
            this.mónĂnToolStripMenuItem.Name = "mónĂnToolStripMenuItem";
            this.mónĂnToolStripMenuItem.Size = new System.Drawing.Size(221, 36);
            this.mónĂnToolStripMenuItem.Text = "Món ăn";
            this.mónĂnToolStripMenuItem.Click += new System.EventHandler(this.mónĂnToolStripMenuItem_Click);
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            this.thôngTinNhânViênToolStripMenuItem.Image = global::WindowsFormsApp9.Properties.Resources.icons8_staff_32;
            this.thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            this.thôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.thôngTinNhânViênToolStripMenuItem.Text = "Thông tin nhân viên";
            this.thôngTinNhânViênToolStripMenuItem.Click += new System.EventHandler(this.btnTTNV);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Image = global::WindowsFormsApp9.Properties.Resources.Golden_key_icon_svg;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.btn_DSTaikhoan);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::WindowsFormsApp9.Properties.Resources._312_3120740_logout_hd_png_download;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.btnThoat);
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hướngDẫnSửDụngToolStripMenuItem.Image = global::WindowsFormsApp9.Properties.Resources.icons8_restaurant_menu_321;
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(223, 32);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp9.Properties.Resources.abstract_gradient_wallpaper_desktop_mattbirchler_idownloadblog_purple_1536x864_11;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiMónĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mónĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
    }
}