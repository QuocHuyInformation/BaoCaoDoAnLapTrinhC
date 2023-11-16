
namespace QuanLyCuaHangTienKhongLoi
{
    partial class frmHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaSanPham = new System.Windows.Forms.MaskedTextBox();
            this.mtxtMaHoaDon = new System.Windows.Forms.MaskedTextBox();
            this.cbTenNhanVien = new System.Windows.Forms.ComboBox();
            this.cbTenSanPham = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaKhachHang = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.mtxtSoDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.cbTenKhachHang = new System.Windows.Forms.ComboBox();
            this.dtNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDanhSachSQL = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaSanPham);
            this.groupBox1.Controls.Add(this.mtxtMaHoaDon);
            this.groupBox1.Controls.Add(this.cbTenNhanVien);
            this.groupBox1.Controls.Add(this.cbTenSanPham);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn và sản phẩm";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(147, 119);
            this.txtMaSanPham.Mask = "00000";
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(170, 26);
            this.txtMaSanPham.TabIndex = 9;
            this.txtMaSanPham.ValidatingType = typeof(int);
            // 
            // mtxtMaHoaDon
            // 
            this.mtxtMaHoaDon.Location = new System.Drawing.Point(147, 30);
            this.mtxtMaHoaDon.Mask = "00000";
            this.mtxtMaHoaDon.Name = "mtxtMaHoaDon";
            this.mtxtMaHoaDon.Size = new System.Drawing.Size(170, 26);
            this.mtxtMaHoaDon.TabIndex = 8;
            this.mtxtMaHoaDon.ValidatingType = typeof(int);
            // 
            // cbTenNhanVien
            // 
            this.cbTenNhanVien.FormattingEnabled = true;
            this.cbTenNhanVien.Location = new System.Drawing.Point(146, 252);
            this.cbTenNhanVien.Name = "cbTenNhanVien";
            this.cbTenNhanVien.Size = new System.Drawing.Size(171, 28);
            this.cbTenNhanVien.TabIndex = 7;
            // 
            // cbTenSanPham
            // 
            this.cbTenSanPham.FormattingEnabled = true;
            this.cbTenSanPham.Location = new System.Drawing.Point(147, 74);
            this.cbTenSanPham.Name = "cbTenSanPham";
            this.cbTenSanPham.Size = new System.Drawing.Size(171, 28);
            this.cbTenSanPham.TabIndex = 7;
            this.cbTenSanPham.SelectedIndexChanged += new System.EventHandler(this.cbTenSanPham_SelectedIndexChanged);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(146, 211);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(171, 26);
            this.txtGia.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(146, 167);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(171, 26);
            this.txtSoLuong.TabIndex = 6;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên nhân viên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaKhachHang);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.mtxtSoDienThoai);
            this.groupBox2.Controls.Add(this.cbTenKhachHang);
            this.groupBox2.Controls.Add(this.dtNgayBan);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(355, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(161, 73);
            this.txtMaKhachHang.Mask = "00000";
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(171, 26);
            this.txtMaKhachHang.TabIndex = 11;
            this.txtMaKhachHang.ValidatingType = typeof(int);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(502, 29);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(171, 26);
            this.txtDiaChi.TabIndex = 10;
            // 
            // mtxtSoDienThoai
            // 
            this.mtxtSoDienThoai.Location = new System.Drawing.Point(161, 114);
            this.mtxtSoDienThoai.Mask = "000000000";
            this.mtxtSoDienThoai.Name = "mtxtSoDienThoai";
            this.mtxtSoDienThoai.Size = new System.Drawing.Size(171, 26);
            this.mtxtSoDienThoai.TabIndex = 9;
            this.mtxtSoDienThoai.ValidatingType = typeof(int);
            // 
            // cbTenKhachHang
            // 
            this.cbTenKhachHang.FormattingEnabled = true;
            this.cbTenKhachHang.Location = new System.Drawing.Point(161, 29);
            this.cbTenKhachHang.Name = "cbTenKhachHang";
            this.cbTenKhachHang.Size = new System.Drawing.Size(171, 28);
            this.cbTenKhachHang.TabIndex = 7;
            this.cbTenKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbTenKhachHang_SelectedIndexChanged);
            // 
            // dtNgayBan
            // 
            this.dtNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBan.Location = new System.Drawing.Point(502, 71);
            this.dtNgayBan.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dtNgayBan.Name = "dtNgayBan";
            this.dtNgayBan.Size = new System.Drawing.Size(171, 26);
            this.dtNgayBan.TabIndex = 7;
            this.dtNgayBan.Value = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(502, 112);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(171, 26);
            this.txtThanhTien.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Địa chỉ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(366, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Tổng tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ngày bán";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(491, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 39);
            this.label7.TabIndex = 2;
            this.label7.Text = "Hóa Đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(355, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(704, 71);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(572, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 39);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(412, 17);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 39);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(246, 17);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 39);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(75, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 39);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDanhSachSQL
            // 
            this.dgvDanhSachSQL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSQL.Location = new System.Drawing.Point(12, 355);
            this.dgvDanhSachSQL.Name = "dgvDanhSachSQL";
            this.dgvDanhSachSQL.RowHeadersWidth = 51;
            this.dgvDanhSachSQL.RowTemplate.Height = 24;
            this.dgvDanhSachSQL.Size = new System.Drawing.Size(1047, 205);
            this.dgvDanhSachSQL.TabIndex = 6;
            this.dgvDanhSachSQL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSQL_CellContentClick);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 575);
            this.Controls.Add(this.dgvDanhSachSQL);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtNgayBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDanhSachSQL;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.MaskedTextBox mtxtMaHoaDon;
        private System.Windows.Forms.ComboBox cbTenNhanVien;
        private System.Windows.Forms.ComboBox cbTenSanPham;
        private System.Windows.Forms.ComboBox cbTenKhachHang;
        private System.Windows.Forms.MaskedTextBox mtxtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtMaSanPham;
        private System.Windows.Forms.MaskedTextBox txtMaKhachHang;
    }
}