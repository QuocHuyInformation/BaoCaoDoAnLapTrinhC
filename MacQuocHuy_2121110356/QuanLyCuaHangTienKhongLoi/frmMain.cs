using System;
using System.Collections.Generic;
using QuanLyCuaHangTienKhongLoi.EF;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienKhongLoi
{
    public partial class frmMain : Form
    {
        public static string tentaikhoan = null;
        public frmMain()
        {
            InitializeComponent();
        }
        public static ThanhVien thanhvien = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (thanhvien == null)//tentaikhoan
            {
                Form frm = new frmLogin();
                frm.ShowDialog();
                if(thanhvien != null)
                {
                    toolStripStatusLabel1.Text = thanhvien.HoTen;
                    pnButtom.Enabled = true;
                    toolStripDropDownButton1.Enabled = true;
                    toolStripStatusLabel2.Enabled = false;
                }
                else
                {
                    toolStripStatusLabel1.Text = "HƯ" ;
                    pnButtom.Enabled = false;
                    toolStripDropDownButton1.Enabled = false;
                    toolStripStatusLabel3.Enabled = false;
                }    
            }            
            //lblTenTaiKhoan.Text = thanhvien.HoTen;
            //toolStripStatusLabel1.Text = lblTenTaiKhoan.Text;
        }
        private void addFormToPanel(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(frm);
            frm.Show();
        }
        private Form currentFromChild;
        private void openChildForm(Form childForm)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //private void lblTatCaSanPham_Click(object sender, EventArgs e)
        //{
        //    Form frm = new frmTatCaSanPham();
        //    addFormToPanel(frm);
        //}

        //private void lblLoaiSanPham_Click(object sender, EventArgs e)
        //{
        //    Form frm = new frmLoaiSanPham();
        //    addFormToPanel(frm);
        //}

        private void btnTatCaSanPham_Click(object sender, EventArgs e)
        {
            //Form frm = new frmTatCaSanPham();
            ////frm.ShowDialog();
            //addFormToPanel(frm);
            openChildForm(new frmTatCaSanPham());
        }

        private void btnDanhMucSanPham_Click(object sender, EventArgs e)
        {
            //Form frm = new frmLoaiSanPham();
            ////frm.ShowDialog();
            //addFormToPanel(frm);
            openChildForm(new frmLoaiSanPham());
        }

        private void btnQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            //Form frm = new frmQuanLyNhanVien();
            ////frm.ShowDialog();
            //addFormToPanel(frm);
            openChildForm(new frmQuanLyNhanVien());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoaDon());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThanhVien());
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMatKhau());
        }

        private void thôngTinThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongTinThanhVien());
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            Form frm = new frmMain();
            frmMain.thanhvien = null;
            frmMain.ActiveForm.Hide();
            frm.ShowDialog();
        }
    }
}
