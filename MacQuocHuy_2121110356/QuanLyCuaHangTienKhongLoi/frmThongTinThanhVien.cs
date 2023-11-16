using QuanLyCuaHangTienKhongLoi.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienKhongLoi
{
    public partial class frmThongTinThanhVien : Form
    {
        private byte[] selectedImageBytes;
        public frmThongTinThanhVien()
        {
            InitializeComponent();
        }

        private void frmThongTinThanhVien_Load(object sender, EventArgs e)
        {
            ThanhVien thanhvien = frmMain.thanhvien;
            txtTenDangNhap.Text = thanhvien.TenDangNhap;
            txtMatKhau.Text = thanhvien.MatKhau;
            txthoTen.Text = thanhvien.HoTen;
            txtEmail.Text = thanhvien.Email;
            txtSoDienThoai.Text = thanhvien.DienThoai;
            txtQuyen.Text = thanhvien.Quyen;
            if (thanhvien.Hinh != null)
            {
                byte[] imageData = (byte[])thanhvien.Hinh;
                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbAnh.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbAnh.Image = null; // Nếu không có hình ảnh, PictureBox sẽ hiển thị rỗng.
                }
            }
            else
            {
                pbAnh.Image = null; // Nếu không có hình ảnh, PictureBox sẽ hiển thị rỗng.
            }


        }
    }
}
