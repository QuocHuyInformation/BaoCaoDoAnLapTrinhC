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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //this.FormClosing += new FormClosingEventHandler(frmLogin_FormClosing);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //if (txtUsename.Text == "admin" && txtPassword.Text == "1234")
            //{
            //    // Thành Công
            //    frmMain.tentaikhoan = "admin";
            //    this.Close();
            //}
            //else
            //{
            //    lblThongBao.Text = "Tài khoản không chính xác !";
            //}
            string username = txtUsename.Text.Trim();
            string password = txtPassword.Text.Trim();//thêm mã hóa sau
            //Bổ Sung E
            ThanhVienDAO thanhvienDAO = new ThanhVienDAO();
            //ThanhVien tv = thanhvienDAO.getRow(username);
            ThanhVien tv = thanhvienDAO.GetRowBySomeProperty(username);
            if (tv == null)
            {
                lblThongBao.Text = "Tài khoản không chính xác !";
            }
            else
            {
                if (tv.MatKhau == password)
                {
                    frmMain.thanhvien = tv;
                    this.Close();
                }
                else
                {
                    lblThongBao.Text = "Tài khoản không chính xác !";
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult resulta = MessageBox.Show("Bạn muốn thoát không ?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resulta == DialogResult.Yes)
            {
                Form frm = new frmMain();
                frm.Close();
                Application.Exit();
            }
        }
        //148
        //private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    //Xử lý trước khi đóng form
        //    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng form không?", "Xác nhận đóng form",
        //    MessageBoxButtons.YesNo,
        //    MessageBoxIcon.Question);
        //    if (result == DialogResult.No)
        //    {
        //        // Ngăn chặn đóng form nếu người dùng chọn "No"
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        // Thực hiện các xử lý khác trước khi đóng form
        //        // Ví dụ: lưu dữ liệu, đóng kết nối, ...
        //        Form frm = new frmLogin();
        //        frm.Close();
        //        Application.Exit();
        //    }

        //}

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuenMatKhau();
            frm.Show();
        }
    }

}
