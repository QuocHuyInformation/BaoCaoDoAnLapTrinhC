
namespace QuanLyCuaHangTienKhongLoi
{
    partial class frmMain
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
            this.lblTenTaiKhoan = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.thôngTinThànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnTatCaSanPham = new System.Windows.Forms.Button();
            this.btnDanhMucSanPham = new System.Windows.Forms.Button();
            this.pnButtom = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuanLyNhanSu = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblTenTaiKhoan.SuspendLayout();
            this.pnButtom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lblTenTaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(0, 566);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(1228, 26);
            this.lblTenTaiKhoan.TabIndex = 1;
            this.lblTenTaiKhoan.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 20);
            this.toolStripStatusLabel1.Text = "Mạc Quốc Huy";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinThànhViênToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::QuanLyCuaHangTienKhongLoi.Properties.Resources.user;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // thôngTinThànhViênToolStripMenuItem
            // 
            this.thôngTinThànhViênToolStripMenuItem.Name = "thôngTinThànhViênToolStripMenuItem";
            this.thôngTinThànhViênToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.thôngTinThànhViênToolStripMenuItem.Text = "Thông Tin Thành Viên";
            this.thôngTinThànhViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinThànhViênToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(88, 20);
            this.toolStripStatusLabel2.Text = "Đăng Nhập";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(83, 20);
            this.toolStripStatusLabel3.Text = "Đăng Xuất";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // btnTatCaSanPham
            // 
            this.btnTatCaSanPham.Location = new System.Drawing.Point(3, 4);
            this.btnTatCaSanPham.Name = "btnTatCaSanPham";
            this.btnTatCaSanPham.Size = new System.Drawing.Size(142, 43);
            this.btnTatCaSanPham.TabIndex = 4;
            this.btnTatCaSanPham.Text = "Tất cả sản phẩm";
            this.btnTatCaSanPham.UseVisualStyleBackColor = true;
            this.btnTatCaSanPham.Click += new System.EventHandler(this.btnTatCaSanPham_Click);
            // 
            // btnDanhMucSanPham
            // 
            this.btnDanhMucSanPham.Location = new System.Drawing.Point(3, 53);
            this.btnDanhMucSanPham.Name = "btnDanhMucSanPham";
            this.btnDanhMucSanPham.Size = new System.Drawing.Size(142, 43);
            this.btnDanhMucSanPham.TabIndex = 4;
            this.btnDanhMucSanPham.Text = "Loại sản phẩm";
            this.btnDanhMucSanPham.UseVisualStyleBackColor = true;
            this.btnDanhMucSanPham.Click += new System.EventHandler(this.btnDanhMucSanPham_Click);
            // 
            // pnButtom
            // 
            this.pnButtom.Controls.Add(this.button2);
            this.pnButtom.Controls.Add(this.btnHoaDon);
            this.pnButtom.Controls.Add(this.button1);
            this.pnButtom.Controls.Add(this.btnQuanLyNhanSu);
            this.pnButtom.Controls.Add(this.btnTatCaSanPham);
            this.pnButtom.Controls.Add(this.btnDanhMucSanPham);
            this.pnButtom.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnButtom.Location = new System.Drawing.Point(0, 0);
            this.pnButtom.Name = "pnButtom";
            this.pnButtom.Size = new System.Drawing.Size(153, 566);
            this.pnButtom.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 49);
            this.button2.TabIndex = 0;
            this.button2.Text = "QL Thành Viên";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(3, 204);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(142, 47);
            this.btnHoaDon.TabIndex = 0;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "QL Khách Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuanLyNhanSu
            // 
            this.btnQuanLyNhanSu.Location = new System.Drawing.Point(3, 102);
            this.btnQuanLyNhanSu.Name = "btnQuanLyNhanSu";
            this.btnQuanLyNhanSu.Size = new System.Drawing.Size(142, 44);
            this.btnQuanLyNhanSu.TabIndex = 5;
            this.btnQuanLyNhanSu.Text = "Quản Lý Nhân Sự";
            this.btnQuanLyNhanSu.UseVisualStyleBackColor = true;
            this.btnQuanLyNhanSu.Click += new System.EventHandler(this.btnQuanLyNhanSu_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(151, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1077, 566);
            this.panelContainer.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 592);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.pnButtom);
            this.Controls.Add(this.lblTenTaiKhoan);
            this.Name = "frmMain";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chính";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.lblTenTaiKhoan.ResumeLayout(false);
            this.lblTenTaiKhoan.PerformLayout();
            this.pnButtom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip lblTenTaiKhoan;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnTatCaSanPham;
        private System.Windows.Forms.Button btnDanhMucSanPham;
        private System.Windows.Forms.Panel pnButtom;
        private System.Windows.Forms.Button btnQuanLyNhanSu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinThànhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}