using QuanLyCuaHangTienKhongLoi.DAO;
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
    public partial class frmThanhVien : Form
    {
        ThanhVienDAO tvDAO = new ThanhVienDAO();
        QLBanHangContext db = new QLBanHangContext();
        private string AddOrEdit = null;
        string[] listQuen = { "1", "2", "3" };
        private byte[] selectedImageBytes;
        public frmThanhVien()
        {
            InitializeComponent();
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Edit";
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            ShowAndHidden(true);
        }

        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = tvDAO.getList();
            cbQuyen.DataSource = listQuen;
            txtTongThanhVien.Text = tvDAO.getCount().ToString();
            ShowAndHidden(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Add";
            ShowAndHidden(true);
            btnLuu.Enabled = true;
            mtxtMaThanhVien.Enabled = true;
        }
        //Check Mã thành viên
        public bool checkMaTV(string maTV)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaThanhVien"].Value.ToString() == maTV)
                {
                    return false;
                }
            }
            return true;

        }

        public void ResetText1()
        {
            mtxtMaThanhVien.Clear();
            txtHoTen.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            mtxtDienThoai.Clear();
            txtEmail.Clear();
            cbQuyen.ResetText();
        }
        private void ShowAndHidden(bool show)
        {
            mtxtMaThanhVien.Enabled = false;
            txtHoTen.Enabled = show;
            txtTenDangNhap.Enabled = show;
            txtMatKhau.Enabled = show;
            mtxtDienThoai.Enabled = show;
            txtEmail.Enabled = show;
            cbQuyen.Enabled = show;
            btnOpenAnh.Enabled = show;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ThanhVienDAO thanhvienvDAO = new ThanhVienDAO();
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên không được để trống");
                }
                if (txtTenDangNhap.Text.Length.Equals(0))
                {
                    throw new Exception("Tên đăng nhập được để trống");
                }
                if (txtMatKhau.Text.Length.Equals(0))
                {
                    throw new Exception("Mật khẩu không được để trống");
                }
                if (txtEmail.Text.Length.Equals(0))
                {
                    throw new Exception("Email không được để trống");
                }
                string tendangnhap = txtTenDangNhap.Text.Trim();
                string matkhau = txtMatKhau.Text.Trim();
                string hoten = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string dienthoai = mtxtDienThoai.Text.Trim();
                string quyen = cbQuyen.Text;
                int matv = Convert.ToInt32(mtxtMaThanhVien.Text.Trim());
                if (AddOrEdit == "Add")
                {
                    ThanhVien tv = new ThanhVien();
                    if (this.checkMaTV(mtxtMaThanhVien.Text.Trim()) == false)
                    {
                        throw new Exception("Mã thành viên đã tồn tại !");
                    }
                    tv.MaThanhVien = matv;
                    tv.TenDangNhap = tendangnhap;
                    tv.MatKhau = matkhau;
                    tv.HoTen = hoten;
                    tv.Email = email;
                    tv.DienThoai = dienthoai;
                    tv.Quyen = quyen;
                    tv.Hinh = selectedImageBytes;
                    thanhvienvDAO.Insert(tv);
                    dgvDanhSach.DataSource = thanhvienvDAO.getList();
                    txtTongThanhVien.Text = thanhvienvDAO.getCount().ToString();
                    ShowAndHidden(false);
                    ResetText1();
                }
                if(AddOrEdit == "Edit")
                {
                    ThanhVien tv = db.ThanhViens.Find(matv);
                    tv.TenDangNhap = tendangnhap;
                    tv.MatKhau = matkhau;
                    tv.HoTen = hoten;
                    tv.Email = email;
                    tv.DienThoai = dienthoai;
                    tv.Quyen = quyen;
                    byte[] currentImage = tv.Hinh;
                    if (selectedImageBytes != null)
                    {
                        tv.Hinh = selectedImageBytes; // Cập nhật thông tin ảnh mới
                    }
                    else
                    {
                        tv.Hinh = currentImage; // Giữ nguyên thông tin ảnh cũ
                    }
                    thanhvienvDAO.Update(tv);
                    dgvDanhSach.DataSource = thanhvienvDAO.getList();
                    txtTongThanhVien.Text = thanhvienvDAO.getCount().ToString();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = false;
                    ShowAndHidden(false);
                    ResetText1();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm không ?", "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int matv = Convert.ToInt32(mtxtMaThanhVien.Text.Trim());
                ThanhVien tv = tvDAO.getRow(matv);
                tvDAO.Delete(tv);
                dgvDanhSach.DataSource = tvDAO.getList();
                txtTongThanhVien.Text = tvDAO.getCount().ToString();

                ResetText1();
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
            }
        }        
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex>=0 &&e.RowIndex < dgvDanhSach.Rows.Count)
            {
                int vt = e.RowIndex;
                mtxtMaThanhVien.Text = dgvDanhSach.Rows[vt].Cells["MaThanhVien"].Value.ToString();
                txtTenDangNhap.Text = dgvDanhSach.Rows[vt].Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = dgvDanhSach.Rows[vt].Cells["MatKhau"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[vt].Cells["HoTen"].Value.ToString();
                mtxtDienThoai.Text = dgvDanhSach.Rows[vt].Cells["DienThoai"].Value.ToString();
                txtEmail.Text = dgvDanhSach.Rows[vt].Cells["Email"].Value.ToString();
                cbQuyen.Text = dgvDanhSach.Rows[vt].Cells["Quyen"].Value.ToString();
                if (dgvDanhSach.Rows[vt].Cells["Hinh"].Value != null)
                {
                    byte[] imageData = (byte[])dgvDanhSach.Rows[vt].Cells["Hinh"].Value;
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
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = false;
            ShowAndHidden(false);
        }

        private void btnOpenAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagePath = openFileDialog.FileName;
                    pbAnh.Image = Image.FromFile(imagePath);
                    selectedImageBytes = File.ReadAllBytes(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
