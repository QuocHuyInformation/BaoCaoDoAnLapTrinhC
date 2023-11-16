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
    public partial class frmQuanLyNhanVien : Form
    {
        NhanVienDAO nvDAO = new NhanVienDAO();
        QLBanHangContext db = new QLBanHangContext();
        private string AddOrEdit = null;

        string[] listChucVu = { "Quản lý", "Nhân viên" };
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            cbChucVu.DataSource = listChucVu;
            dgvDanhSachNhanVien.DataSource = nvDAO.getList();
            lbltongsonhanvien.Text = "" + db.NhanViens.Count();
            ShowAndHidden(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }
        
        public bool checkMaNV(string manv)
        {
            if (dgvDanhSachNhanVien.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSachNhanVien.Rows.Count - 1; row++)
            {
                if (dgvDanhSachNhanVien.Rows[row].Cells["MaNV"].Value.ToString() == manv)
                {
                    return false;
                }
            }
            return true;

        }
        public void ResetText1()
        {
            mtxtMaNV.Clear();
            mtxtSDT.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            dtNgaySinh.ResetText();
        }
        private void ShowAndHidden(bool show)
        {
            mtxtMaNV.Enabled = false;
            mtxtSDT.Enabled = show;
            txtTenNV.Enabled = show;
            txtDiaChi.Enabled = show;
            txtEmail.Enabled = show;
            dtNgaySinh.Enabled = show;
            cbChucVu.Enabled = show;
            cbCai.Enabled = show;
            cbDuc.Enabled = show;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {                
                if (this.checkMaNV(mtxtMaNV.Text.Trim()) == false)
                {
                    throw new Exception("Mã nhân viên đã tồn tại");
                }
                if (txtTenNV.Text.Length.Equals(0))
                {
                    throw new Exception("Tên sản phẩm không được để trống");
                }
                if (mtxtSDT.Text.Length < 9)
                {
                    throw new Exception("Số điện thoại ít nhất 9 số !");
                }
                if (txtDiaChi.Text.Length.Equals(0))
                {
                    throw new Exception("Địa chỉ không được để trống");
                }
                if (txtEmail.Text.Length.Equals(0))
                {
                    throw new Exception("Email không được để trống");
                }
                DateTime ngaysinh = DateTime.Parse(dtNgaySinh.Text.Trim());
                string NgaysinhChuyenDoii = ngaysinh.ToString("yyyy/MM/dd"); 
                DateTime ngaysinhchuyendoi = DateTime.Parse(NgaysinhChuyenDoii);
                if(AddOrEdit == "Add")
                {
                    NhanVienDAO nhanvienDAO = new NhanVienDAO();
                    NhanVien nv = new NhanVien();
                    nv.MaNV = Convert.ToInt32(mtxtMaNV.Text);
                    nv.TenNV = txtTenNV.Text.Trim();
                    nv.SoDienThoai = mtxtSDT.Text.Trim();
                    nv.DiaChi = txtDiaChi.Text.Trim();
                    nv.Email = txtEmail.Text.Trim();
                    nv.GioiTinh = cbDuc.Checked ? "Nam" : "Nữ";
                    nv.ChucVu = cbChucVu.Text.Trim();
                    nv.NgaySinh = ngaysinhchuyendoi;
                    nhanvienDAO.Insert(nv);
                    //db.SaveChanges();
                    dgvDanhSachNhanVien.DataSource = nhanvienDAO.getList();
                    lbltongsonhanvien.Text = "" + db.NhanViens.Count();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    ShowAndHidden(false);
                    ResetText1();
                }
                if(AddOrEdit == "Edit")
                {
                    NhanVienDAO nhavienDAO = new NhanVienDAO();
                    //Update
                    int manv = Convert.ToInt32(mtxtMaNV.Text);
                    //SanPham sp = SanPhamDao.getRow(maSP);
                    NhanVien nv = db.NhanViens.Find(manv);
                    nv.MaNV = manv;
                    nv.TenNV = txtTenNV.Text.Trim();
                    nv.SoDienThoai = mtxtSDT.Text.Trim();
                    nv.DiaChi = txtDiaChi.Text.Trim();
                    nv.Email = txtEmail.Text.Trim();
                    nv.GioiTinh = cbDuc.Checked ? "Nam" : "Nữ";
                    nv.ChucVu = cbChucVu.Text.Trim();
                    nv.NgaySinh = ngaysinhchuyendoi;
                    nhavienDAO.Update(nv);
                    //db.SaveChanges();
                    dgvDanhSachNhanVien.DataSource = nhavienDAO.getList();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    ShowAndHidden(false);
                    ResetText1();
                }    

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Add";
            ShowAndHidden(true);
            mtxtMaNV.Enabled = true;
            btnLuu.Enabled = true;
            ResetText1();
        }

        private void dgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSachNhanVien.Rows.Count - 0)
                {
                    throw new Exception("Chưa chọn nhân viên");
                }
                mtxtMaNV.Text = dgvDanhSachNhanVien.Rows[rowindex].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgvDanhSachNhanVien.Rows[rowindex].Cells["TenNV"].Value.ToString();
                txtDiaChi.Text = dgvDanhSachNhanVien.Rows[rowindex].Cells["DiaChi"].Value.ToString();
                mtxtSDT.Text = dgvDanhSachNhanVien.Rows[rowindex].Cells["SoDienThoai"].Value.ToString();
                txtEmail.Text = dgvDanhSachNhanVien.Rows[rowindex].Cells["Email"].Value.ToString();
                string gioiTinh = dgvDanhSachNhanVien.Rows[rowindex].Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    cbDuc.Checked = true;
                    cbCai.Checked = false;
                }
                else if (gioiTinh == "Nữ")
                {
                    cbDuc.Checked = false;
                    cbCai.Checked = true;
                }
                dtNgaySinh.Text = dgvDanhSachNhanVien.Rows[rowindex].Cells["NgaySinh"].Value.ToString();
                cbChucVu.Text = dgvDanhSachNhanVien.Rows[rowindex].Cells["ChucVu"].Value.ToString();

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
            DialogResult result = MessageBox.Show("Bạn có muốn đuổi nhân viên này không ?", "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int masp = int.Parse(mtxtMaNV.Text.Trim());
                NhanVien nv = nvDAO.getRow(masp);
                nvDAO.Delete(nv);
                dgvDanhSachNhanVien.DataSource = nvDAO.getList();
                ResetText1();
                lbltongsonhanvien.Text = "" + db.NhanViens.Count();
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
            }
        }
    }
}
