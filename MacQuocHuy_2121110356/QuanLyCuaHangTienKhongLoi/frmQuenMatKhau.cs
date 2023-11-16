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
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string sodienthoai = txtSoDienThoai.Text.Trim();
                string passwordnew = txtMatKhauMoi.Text.Trim();
                string enteranewpassword = txtNhapLaiMkMoi.Text.Trim();
                ThanhVienDAO thanhvienDAO = new ThanhVienDAO();
                ThanhVien tv = thanhvienDAO.GetRowBySomeProperty1(sodienthoai);
                if (tv == null)
                {
                    throw new Exception("Số điện thoại không chính xác");
                }
                if (!passwordnew.Equals(enteranewpassword))
                {
                    throw new Exception("Mật khẩu mới không khớp");
                }
                string matkhau = txtMatKhauMoi.Text.Trim();
                tv.MatKhau = matkhau;//Cập nhật mật khẩu
                ThanhVienDAO tvDAO = new ThanhVienDAO();
                tvDAO.Update(tv);
                MessageBox.Show("Cập nhật thành công");
                txtSoDienThoai.Clear();
                txtMatKhauMoi.Clear();
                txtNhapLaiMkMoi.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !");
            }
        }
    }
}
