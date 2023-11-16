using QuanLyCuaHangTienKhongLoi.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienKhongLoi.DAO
{
    class LoaiSanPhamDAO
    {
        QLBanHangContext db = null;
        public LoaiSanPhamDAO()
        {
            db = new QLBanHangContext();
        }
        public List<LoaiSanPham> getList()
        {
            return db.LoaiSanPhams.ToList();
        }
        public void Insert(LoaiSanPham LoaiSanPham)
        {
            db.LoaiSanPhams.Add(LoaiSanPham);
            db.SaveChanges();
        }
        public LoaiSanPham getRow(int maLoaiSanPham)
        {
            return db.LoaiSanPhams.Find(maLoaiSanPham);
        }
        public void Delete(LoaiSanPham LoaiSanPham)
        {
            db.LoaiSanPhams.Remove(LoaiSanPham);
            db.SaveChanges();
        }
    }
}
