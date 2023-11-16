using QuanLyCuaHangTienKhongLoi.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienKhongLoi.DAO
{
    class SanPhamDao
    {
        QLBanHangContext db = null;
        public SanPhamDao()
        {
            db = new QLBanHangContext();
        }
        public List<SanPham> getList()
        {
            return db.SanPhams.ToList();
        }
        public void Insert(SanPham SanPham)
        {
            db.SanPhams.Add(SanPham);
            db.SaveChanges();
        }
        public void Update(SanPham SanPham)
        {
            db.Entry(SanPham).State = EntityState.Modified;
            db.SaveChanges();
        }
        public SanPham getRow(int maSanPham)
        {
            return db.SanPhams.Find(maSanPham);
        }
        public void Delete(SanPham SanPham)
        {
            db.SanPhams.Remove(SanPham);
            db.SaveChanges();
        }
    }
}
