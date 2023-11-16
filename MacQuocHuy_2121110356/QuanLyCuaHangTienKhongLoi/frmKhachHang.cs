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
    public partial class frmKhachHang : Form
    {
        KhachHangDAO khDAO = new KhachHangDAO();
        QLBanHangContext db = new QLBanHangContext();
        private string AddOrEdit = null;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = khDAO.getList();
            ShowAndHidden(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void ShowAndHidden(bool show)
        {
            mtxtMaKhachHang.Enabled = false;
            txtTenKhachHang.Enabled = show;
            mtxtSoDienThoai.Enabled = show;
            txtDiaChi.Enabled = show;
        }
        public bool checkMaKH(string makh)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaKhachHang"].Value.ToString() == makh)
                {
                    return false;
                }
            }
            return true;

        }
        public void ResetText1()
        {
            mtxtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            mtxtSoDienThoai.Clear();
            txtDiaChi.Clear();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int makh;
                if (mtxtMaKhachHang.Text.Length == 0 || !int.TryParse(mtxtMaKhachHang.Text, out makh))
                {
                    throw new Exception("Mã khách hàng không được để trống !");
                }
                if (txtTenKhachHang.Text.Length.Equals(0))
                {
                    throw new Exception("Tên khách hàng không được để trống");
                }
                if (txtDiaChi.Text.Length.Equals(0))
                {
                    throw new Exception("Địa chỉ không được để trống");
                }
                if (AddOrEdit == "Add")
                {
                    //Luu vào CSDL
                    KhachHangDAO khachhangDAO = new KhachHangDAO();
                    KhachHang kh = new KhachHang();
                    if (this.checkMaKH(mtxtMaKhachHang.Text.Trim()) == false)
                    {
                        throw new Exception("Mã khách hàng đã tồn tại");
                    }
                    kh.MaKhachHang = Convert.ToInt32(mtxtMaKhachHang.Text.Trim());
                    kh.TenKhachHang = txtTenKhachHang.Text.Trim();
                    kh.SoDienThoai = mtxtSoDienThoai.Text.Trim();
                    kh.DiaChi = txtDiaChi.Text;
                    khachhangDAO.Insert(kh);
                    //db.SaveChanges();
                    dgvDanhSach.DataSource = khachhangDAO.getList();
                    //lbltongsosp.Text = "" + db.SanPhams.Count();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    ShowAndHidden(false);
                    ResetText1();
                }
                if (AddOrEdit == "Edit")
                {
                    KhachHangDAO khachhangDAO = new KhachHangDAO();
                    //Update
                    int Makh = Convert.ToInt32(mtxtMaKhachHang.Text);
                    //SanPham sp = SanPhamDao.getRow(maSP);
                    KhachHang kh = db.KhachHangs.Find(Makh);
                    kh.MaKhachHang = Makh;
                    kh.TenKhachHang = txtTenKhachHang.Text;
                    kh.SoDienThoai = mtxtSoDienThoai.Text.Trim();
                    kh.DiaChi = txtDiaChi.Text;
                    khachhangDAO.Update(kh);
                    //db.SaveChanges();
                    dgvDanhSach.DataSource = khachhangDAO.getList();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    ShowAndHidden(false);
                    ResetText1();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Add";
            ShowAndHidden(true);
            mtxtMaKhachHang.Enabled = true;
            btnLuu.Enabled = true;
            ResetText1();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 0)
                {
                    throw new Exception("Chưa chọn khách hàng !");
                }
                mtxtMaKhachHang.Text = dgvDanhSach.Rows[rowindex].Cells["MaKhachHang"].Value.ToString();
                txtTenKhachHang.Text = dgvDanhSach.Rows[rowindex].Cells["TenKhachhang"].Value.ToString();
                mtxtSoDienThoai.Text = dgvDanhSach.Rows[rowindex].Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = dgvDanhSach.Rows[rowindex].Cells["DiaChi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = false;
            ShowAndHidden(false);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Edit";
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            ShowAndHidden(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm không ?", "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int Makh = int.Parse(mtxtMaKhachHang.Text.Trim());
                KhachHang kh = khDAO.getRow(Makh);
                khDAO.Delete(kh);
                dgvDanhSach.DataSource = khDAO.getList();
                ResetText1();
                //lbltongsosp.Text = "" + db.SanPhams.Count();
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
