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
    public partial class frmHoaDon : Form
    {
        //int rowindex = -1;
        QLBanHangContext db = new QLBanHangContext();
        //KhachHangDAO khDAO = new KhachHangDAO();
        NhanVienDAO nvDAO = new NhanVienDAO();
        //SanPhamDao spDAO = new SanPhamDao();
        HoaDonDAO hdDAO = new HoaDonDAO();
        //KhachHangDAO khDAO = new KhachHangDAO();
        private string AddOrEdit = null;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void LoadKhachHang()
        {
            cbTenKhachHang.DataSource = db.KhachHangs.ToList();
            cbTenKhachHang.ValueMember = "MaKhachHang";
            cbTenKhachHang.DisplayMember = "TenKhachHang";
        }
        private void loaddingNhanVien()
        {
            cbTenNhanVien.DataSource = db.NhanViens.ToList();
            cbTenNhanVien.ValueMember = "MaNV";
            cbTenNhanVien.DisplayMember = "TenNV"; 
        }
        private void LoadSanPham()
        {
            cbTenSanPham.DataSource = db.SanPhams.ToList();
            cbTenSanPham.ValueMember = "MaSP";
            cbTenSanPham.DisplayMember = "TenSP"; // Thiết lập thành phần hiển thị để hiển thị tên sản phẩm
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvDanhSachSQL.DataSource = hdDAO.getList();
            loaddingNhanVien();
            LoadKhachHang();
            LoadSanPham();
            ShowAndHidden(false);
            ResetText1();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }


        public void ResetText1()
        {
            txtMaSanPham.Text="";
            cbTenSanPham.Text ="";
            txtGia.Text ="";
            cbTenNhanVien.Text ="";
            txtMaKhachHang.Text ="";
            cbTenKhachHang.Text ="";
            mtxtSoDienThoai.Text ="";
            txtDiaChi.Text ="";
        }
        private void ShowAndHidden(bool show)
        {
            mtxtMaHoaDon.Enabled = false;
            txtMaSanPham.Enabled = show;
            cbTenSanPham.Enabled = show;
            txtSoLuong.Enabled = show;
            txtGia.Enabled = show;
            cbTenNhanVien.Enabled = show;
            txtMaKhachHang.Enabled = show;
            cbTenKhachHang.Enabled = show;
            mtxtSoDienThoai.Enabled = show;
            mtxtSoDienThoai.Enabled = show;
            txtDiaChi.Enabled = show;
            dtNgayBan.Enabled = show;
            txtThanhTien.Enabled = show;
        }




        private void cbTenKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbTenKH.Text = "";
            if (cbTenKhachHang.SelectedItem != null)
            {

                // Lấy đối tượng KhachHang từ ComboBox
                KhachHang selectedKhachHang = (KhachHang)cbTenKhachHang.SelectedItem;

                // Hiển thị thông tin vào các ô thông tin tương ứng
                txtMaKhachHang.Text = selectedKhachHang.MaKhachHang.ToString();
                mtxtSoDienThoai.Text = selectedKhachHang.SoDienThoai;
                txtDiaChi.Text = selectedKhachHang.DiaChi.ToString();
            }
            /* else
             {
                 // Nếu không tìm thấy thông tin khách hàng, xóa dữ liệu trong các ô thông tin

                 mkDienThoai.Text = "";
                 txtMaKH.Text = "";
                 txtDiaChi.Text = "";
             }*/
        }

        private void cbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện SelectedIndexChanged
            string tenSanPhamDuocChon = cbTenSanPham.Text;
            // Lấy sản phẩm được chọn từ cơ sở dữ liệu
            SanPham sanPhamDuocChon = db.SanPhams.FirstOrDefault(p => p.TenSP == tenSanPhamDuocChon);

            // Cập nhật textbox giá bán
            if (sanPhamDuocChon != null)
            {
                txtGia.Text = sanPhamDuocChon.GiaBan.ToString();
                txtMaSanPham.Text = sanPhamDuocChon.SoLuong.ToString();

            }
            //else
            //{
            //    // Xử lý trường hợp khi không tìm thấy sản phẩm được chọn
            //    txtDonGia.Text = "";
            //    txtSoLuong.Text = "";

            //}
        }
        private void TinhThanhTien()
        {
            int soLuong, donGia;
            // Kiểm tra xem có thể chuyển đổi sang số nguyên không
            if (int.TryParse(txtSoLuong.Text.Trim(), out soLuong) && int.TryParse(txtGia.Text.Trim(), out donGia))
            {
                // Tính toán tổng tiền và cập nhật vào txtTongTien
                int soluonggg = Convert.ToInt32(txtSoLuong.Text.Trim());
                int dongiaa = Convert.ToInt32(txtGia.Text.Trim());
                int tongTien = soluonggg * dongiaa;
                txtThanhTien.Text = tongTien.ToString();
            }
            else
            {
                // Xử lý trường hợp không thể chuyển đổi sang số nguyên
                txtThanhTien.Text = "";
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }
        public bool checkMaHD(string maHD)
        {
            if (dgvDanhSachSQL.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSachSQL.Rows.Count - 1; row++)
            {
                if (dgvDanhSachSQL.Rows[row].Cells["MaHoaDon"].Value.ToString() == maHD)
                {
                    return false;
                }
            }
            return true;

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int soluong;
            try
            {
                HoaDonDAO hoadonDAO = new HoaDonDAO();
                if (mtxtMaHoaDon.Text.Length.Equals(0))
                {
                    throw new Exception("Mã hóa đơn không được để trống");
                }
                if (!int.TryParse(txtSoLuong.Text.Trim(), out soluong))
                {
                    throw new Exception("Số Lượng không phải số");
                }
                int masp = Convert.ToInt32(txtMaSanPham.Text.Trim());
                string tensanpham = cbTenSanPham.Text.Trim();
                int soluongg = Convert.ToInt32(txtSoLuong.Text.Trim());
                int gia = Convert.ToInt32(txtGia.Text.Trim());
                string tennhanvien = cbTenNhanVien.Text.Trim();
                int makh = Convert.ToInt32(txtMaKhachHang.Text.Trim());
                string tenkhachhang = cbTenKhachHang.Text;
                string sodienthoai = mtxtSoDienThoai.Text.Trim();
                string diachi = txtDiaChi.Text;
                DateTime ngayban = DateTime.Parse(dtNgayBan.Text.Trim());
                string ngayBanChuyenDoii = ngayban.ToString("yyyy/MM/dd");
                DateTime ngaybanchuyendoi = DateTime.Parse(ngayBanChuyenDoii);
                int tongtien = Convert.ToInt32(txtThanhTien.Text.Trim());
                if (AddOrEdit == "Add")
                {
                    //KhachHang kh = new KhachHang();
                    HoaDon hd = new HoaDon();
                    if (this.checkMaHD(mtxtMaHoaDon.Text.Trim()) == false)
                    {
                        throw new Exception("Mã hóa đơn đã tồn tại !");
                    }
                    hd.MaHoaDon = Convert.ToInt32(mtxtMaHoaDon.Text.Trim());
                    hd.MaSanPham = masp;
                    hd.TenSanPham = tensanpham;
                    hd.SoLuong = soluong;
                    hd.Gia = gia;
                    hd.TenNhanVien = tennhanvien;
                    hd.MaKhachHang = makh;
                    hd.TenKhachHang = tenkhachhang;
                    hd.SoDienThoai = sodienthoai;
                    hd.DiaChi = diachi;
                    hd.NgayBan = ngaybanchuyendoi;
                    hd.ThanhTien = tongtien;
                    hoadonDAO.Insert(hd);
                    dgvDanhSachSQL.DataSource = hoadonDAO.getList();
                    //txtTongThanhVien.Text = thanhvienvDAO.getCount().ToString();
                    //if(makh != kh.MaKhachHang)
                    //{
                    //    kh.MaKhachHang = makh;
                    //    kh.TenKhachHang = tenkhachhang;
                    //    kh.SoDienThoai = sodienthoai;
                    //    kh.DiaChi = diachi;
                    //    khDAO.Insert(kh);
                    //}    
                }
                if (AddOrEdit == "Edit")
                {
                    int mahd = Convert.ToInt32(mtxtMaHoaDon.Text.Trim());
                    HoaDon hd = db.HoaDons.Find(mahd);
                    hd.MaSanPham = masp;
                    hd.TenSanPham = tensanpham;
                    hd.SoLuong = soluong;
                    hd.Gia = gia;
                    hd.TenNhanVien = tennhanvien;
                    hd.MaKhachHang = makh;
                    hd.TenKhachHang = tenkhachhang;
                    hd.SoDienThoai = sodienthoai;
                    hd.DiaChi = diachi;
                    hd.NgayBan = ngaybanchuyendoi;
                    hd.ThanhTien = tongtien;
                    hoadonDAO.Update(hd);
                    dgvDanhSachSQL.DataSource = hoadonDAO.getList();
                    //txtTongThanhVien.Text = thanhvienvDAO.getCount().ToString();
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = false;
                }
                ShowAndHidden(false);
                ResetText1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void dgvDanhSachSQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachSQL.Rows.Count)
            {
                int vt = e.RowIndex;
                mtxtMaHoaDon.Text = dgvDanhSachSQL.Rows[vt].Cells["MaHoaDon"].Value.ToString();
                txtMaSanPham.Text = dgvDanhSachSQL.Rows[vt].Cells["MaSanPham"].Value.ToString();
                cbTenSanPham.Text = dgvDanhSachSQL.Rows[vt].Cells["TenSanPham"].Value.ToString();
                txtSoLuong.Text = dgvDanhSachSQL.Rows[vt].Cells["SoLuong"].Value.ToString();
                txtGia.Text = dgvDanhSachSQL.Rows[vt].Cells["Gia"].Value.ToString();
                cbTenNhanVien.Text = dgvDanhSachSQL.Rows[vt].Cells["TenNhanVien"].Value.ToString();
                txtMaKhachHang.Text = dgvDanhSachSQL.Rows[vt].Cells["MaKhachHang"].Value.ToString();
                cbTenKhachHang.Text = dgvDanhSachSQL.Rows[vt].Cells["TenKhachHang"].Value.ToString();
                mtxtSoDienThoai.Text = dgvDanhSachSQL.Rows[vt].Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = dgvDanhSachSQL.Rows[vt].Cells["DiaChi"].Value.ToString();
                dtNgayBan.Text = dgvDanhSachSQL.Rows[vt].Cells["NgayBan"].Value.ToString();
                txtThanhTien.Text = dgvDanhSachSQL.Rows[vt].Cells["ThanhTien"].Value.ToString();
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Add";
            btnLuu.Enabled = true;
            ShowAndHidden(true);
            ResetText1();
            mtxtMaHoaDon.Enabled = true;
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
            DialogResult result = MessageBox.Show("Bạn có muốn xóa hóa đơn không ?", "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int mahd = Convert.ToInt32(mtxtMaHoaDon.Text.Trim());
                HoaDon hd = hdDAO.getRow(mahd);
                hdDAO.Delete(hd);
                dgvDanhSachSQL.DataSource = hdDAO.getList();
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
            }
        }
    }
}
