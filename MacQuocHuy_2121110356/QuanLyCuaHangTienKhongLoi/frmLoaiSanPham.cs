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
    public partial class frmLoaiSanPham : Form
    {
        LoaiSanPhamDAO LspDAO = new LoaiSanPhamDAO();
        QLBanHangContext db = new QLBanHangContext();
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = LspDAO.getList();
            btnXoa.Enabled = false;
            lblTongLoai.Text = "" + db.LoaiSanPhams.Count();
        }
        public bool checkMaLoaiSP(string maloaisp)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaLoai"].Value.ToString() == maloaisp)
                {
                    return false;
                }
            }
            return true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiSanPhamDAO loaiSPDAO = new LoaiSanPhamDAO();
                LoaiSanPham LoaiSp = new LoaiSanPham();
                if (this.checkMaLoaiSP(mtxtMaLoai.Text.Trim()) == false)
                {
                    throw new Exception("Mã sản phẩm đã tồn tại");
                }
                LoaiSp.MaLoai = Convert.ToInt32(mtxtMaLoai.Text);
                LoaiSp.TenLoai = txtTenLoaiSP.Text.Trim();
                loaiSPDAO.Insert(LoaiSp);
                dgvDanhSach.DataSource = loaiSPDAO.getList();
                lblTongLoai.Text = "" + db.LoaiSanPhams.Count();
                mtxtMaLoai.ResetText();
                txtTenLoaiSP.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 0)
                {
                    throw new Exception("Chưa chọn loại sản phẩm !");
                }
                mtxtMaLoai.Text = dgvDanhSach.Rows[rowindex].Cells["MaLoai"].Value.ToString();
                txtTenLoaiSP.Text = dgvDanhSach.Rows[rowindex].Cells["TenLoai"].Value.ToString();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnXoa.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm không ?", "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int MaLoaiSp = int.Parse(mtxtMaLoai.Text.Trim());
                LoaiSanPham lsp = LspDAO.getRow(MaLoaiSp);
                LspDAO.Delete(lsp);
                dgvDanhSach.DataSource = LspDAO.getList();
                mtxtMaLoai.ResetText();
                txtTenLoaiSP.ResetText();
                lblTongLoai.Text = "" + db.LoaiSanPhams.Count();
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
