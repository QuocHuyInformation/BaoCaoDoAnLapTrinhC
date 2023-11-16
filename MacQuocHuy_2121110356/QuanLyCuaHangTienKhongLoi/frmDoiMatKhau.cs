using QuanLyCuaHangTienKhongLoi.DAO;
using QuanLyCuaHangTienKhongLoi.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienKhongLoi
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ThanhVien thanhvien = frmMain.thanhvien;
                string matkhaucu = txtMatKhauCu.Text.Trim();
                if(!thanhvien.MatKhau.Equals(matkhaucu))
                {
                    throw new Exception("Mật khẩu cũ không chính xác");
                }    
                if(!txtNhapMKMoi.Text.Trim().Equals(txtNhapLaiMK.Text.Trim()))
                {
                    throw new Exception("Mật khẩu mới không khớp");
                }
                string matkhau = txtNhapMKMoi.Text.Trim();
                thanhvien.MatKhau = matkhau;//Cập nhật mật khẩu
                ThanhVienDAO tvDAO = new ThanhVienDAO();
                tvDAO.Update(thanhvien);
                MessageBox.Show("Cập nhật thành công");
                txtMatKhauCu.Clear();
                txtNhapMKMoi.Clear();
                txtNhapLaiMK.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !");
            }
        }
    }
}
