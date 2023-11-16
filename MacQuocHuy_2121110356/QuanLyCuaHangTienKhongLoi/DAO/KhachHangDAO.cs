using QuanLyCuaHangTienKhongLoi.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienKhongLoi.DAO
{
    class KhachHangDAO
    {
        QLBanHangContext db = null;
        public KhachHangDAO()
        {
            db = new QLBanHangContext();
        }
        public List<KhachHang> getList()
        {
            return db.KhachHangs.ToList();
        }
        public void Insert(KhachHang KhachHang)
        {
            db.KhachHangs.Add(KhachHang);
            db.SaveChanges();
        }
        public void Update(KhachHang KhachHang)
        {
            db.Entry(KhachHang).State = EntityState.Modified;
            db.SaveChanges();
        }
        public KhachHang getRow(int maKhachHang)
        {
            return db.KhachHangs.Find(maKhachHang);
        }
        public void Delete(KhachHang KhachHang)
        {
            db.KhachHangs.Remove(KhachHang);
            db.SaveChanges();
        }
    }
}
