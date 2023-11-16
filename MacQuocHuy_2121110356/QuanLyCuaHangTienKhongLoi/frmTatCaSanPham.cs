using QuanLyCuaHangTienKhongLoi.DAO;
using QuanLyCuaHangTienKhongLoi.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienKhongLoi
{
    public partial class frmTatCaSanPham : Form
    {
        SanPhamDao spDAO = new SanPhamDao();
        QLBanHangContext db = new QLBanHangContext();
        private string AddOrEdit = null;
        private byte[] selectedImageBytes;

        public frmTatCaSanPham()
        {
            InitializeComponent();
        }
        private void loaddingLoai()
        {
            cbLoai.DataSource = db.LoaiSanPhams.ToList();
            cbLoai.ValueMember = "MaLoai";
            cbLoai.DisplayMember = "TenLoai";
        }

        string[] listLoai = { "Đồ Nam", "Đồ Nữ", "Đồ Đôi", "Đồ Trẻ Em", "Phụ Kiện" };
        private void frmTatCaSanPham_Load(object sender, EventArgs e)
        {
            //cbLoai.DataSource = listLoai;
            dgvDanhSach.DataSource = spDAO.getList();
            lbltongsosp.Text = "" + db.SanPhams.Count();
            ShowAndHidden(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            loaddingLoai();
        }
        public bool checkMaSP(string masp)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSP"].Value.ToString() == masp)
                {
                    return false;
                }
            }
            return true;

        }

        public void ResetText1()
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtTenSanPham.Clear();
            mtxtMaSanPham.Clear();
            dtNgayNhap.ResetText();
            dtNgayXuat.ResetText();
        }
        private void ShowAndHidden(bool show)
        {
            mtxtMaSanPham.Enabled = false;
            txtTenSanPham.Enabled = show;
            txtDonGia.Enabled = show;
            txtSoLuong.Enabled = show;
            cbLoai.Enabled = show;
            dtNgayNhap.Enabled = show;
            dtNgayXuat.Enabled = show;
            btnOpenAnh.Enabled = show;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Add";
            ShowAndHidden(true);
            mtxtMaSanPham.Enabled = true;
            btnLuu.Enabled = true;
            ResetText1();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Edit";
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            ShowAndHidden(true);
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
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int gia, soluong;
                if (txtTenSanPham.Text.Length.Equals(0))
                {
                    throw new Exception("Tên sản phẩm không được để trống");
                }
                if (txtDonGia.Text.Length.Equals(0))
                {
                    throw new Exception("Giá không được để trống");
                }
                if (!int.TryParse(txtDonGia.Text.Trim(), out gia))
                {
                    throw new Exception("Giá bán không phải số");
                }
                if (!int.TryParse(txtSoLuong.Text.Trim(), out soluong))
                {
                    throw new Exception("Số lượng không phải số");
                }
                DateTime ngaynhap = DateTime.Parse(dtNgayNhap.Text.Trim());
                string ngayNhapChuyenDoii = ngaynhap.ToString("yyyy/MM/dd");
                DateTime ngaynhapchuyendoi = DateTime.Parse(ngayNhapChuyenDoii);
                DateTime ngayxuat = DateTime.Parse(dtNgayXuat.Text.Trim());
                string ngayXuatChuyenDoii = ngayxuat.ToString("yyyy/MM/dd");
                DateTime ngayxuatchuyendoi = DateTime.Parse(ngayXuatChuyenDoii);
                if (AddOrEdit == "Add")
                {
                    //Luu vào CSDL

                    SanPhamDao sanPhamDAO = new SanPhamDao();
                    SanPham sp = new SanPham();
                    if (this.checkMaSP(mtxtMaSanPham.Text.Trim()) == false)
                    {
                        throw new Exception("Mã sản phẩm đã tồn tại");
                    }
                    sp.MaSP = Convert.ToInt32(mtxtMaSanPham.Text);
                    sp.TenSP = txtTenSanPham.Text.Trim();
                    sp.Loai = cbLoai.Text.Trim();
                    sp.GiaBan = Convert.ToInt32(txtDonGia.Text);
                    sp.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                    sp.NgayNhap = ngaynhapchuyendoi;
                    sp.NgayXuat = ngayxuatchuyendoi;
                    sp.Hinh = selectedImageBytes;
                    sanPhamDAO.Insert(sp);
                    //db.SaveChanges();
                    dgvDanhSach.DataSource = sanPhamDAO.getList();
                    lbltongsosp.Text = "" + db.SanPhams.Count();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    ShowAndHidden(false);
                    ResetText1();
                }
                if (AddOrEdit == "Edit")
                {
                    SanPhamDao sanPhamDAO = new SanPhamDao();
                    //Update
                    int Masp = Convert.ToInt32(mtxtMaSanPham.Text);
                    //SanPham sp = SanPhamDao.getRow(maSP);
                    SanPham sp = db.SanPhams.Find(Masp);
                    sp.MaSP = Masp;
                    sp.TenSP = txtTenSanPham.Text.Trim();
                    sp.Loai = cbLoai.Text.Trim();
                    sp.GiaBan = Convert.ToInt32(txtDonGia.Text);
                    sp.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                    sp.NgayNhap = ngaynhapchuyendoi;
                    sp.NgayXuat = ngayxuatchuyendoi;
                    byte[] currentImage = sp.Hinh;
                    if (selectedImageBytes != null)
                    {
                        sp.Hinh = selectedImageBytes; // Cập nhật thông tin ảnh mới
                    }
                    else
                    {
                        sp.Hinh = currentImage; // Giữ nguyên thông tin ảnh cũ
                    }
                    sanPhamDAO.Update(sp);
                    //db.SaveChanges();
                    dgvDanhSach.DataSource = sanPhamDAO.getList();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm không ?", "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int Masp = int.Parse(mtxtMaSanPham.Text.Trim());
                SanPham sp = spDAO.getRow(Masp);
                spDAO.Delete(sp);
                dgvDanhSach.DataSource = spDAO.getList();
                ResetText1();
                lbltongsosp.Text = "" + db.SanPhams.Count();
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
            }
            
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

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 0)
                {
                    throw new Exception("Chưa chọn sản phẩm !");
                }
                mtxtMaSanPham.Text = dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString();
                txtTenSanPham.Text = dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value.ToString();
                txtSoLuong.Text = dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = dgvDanhSach.Rows[rowindex].Cells["GiaBan"].Value.ToString();
                dtNgayNhap.Text = dgvDanhSach.Rows[rowindex].Cells["NgayNhap"].Value.ToString();
                dtNgayXuat.Text = dgvDanhSach.Rows[rowindex].Cells["NgayXuat"].Value.ToString();
                cbLoai.Text = dgvDanhSach.Rows[rowindex].Cells["Loai"].Value.ToString();
                if (dgvDanhSach.Rows[rowindex].Cells["Hinh"].Value != null)
                {
                    byte[] imageData = (byte[])dgvDanhSach.Rows[rowindex].Cells["Hinh"].Value;
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

    }
}
