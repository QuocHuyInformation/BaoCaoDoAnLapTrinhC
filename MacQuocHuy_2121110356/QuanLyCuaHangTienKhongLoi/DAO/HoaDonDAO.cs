using QuanLyCuaHangTienKhongLoi.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienKhongLoi.DAO
{
    class HoaDonDAO
    {
        QLBanHangContext db = null;
        public HoaDonDAO()
        {
            db = new QLBanHangContext();
        }
        public List<HoaDon> getList()
        {
            return db.HoaDons.ToList();
        }
        public void Insert(HoaDon hd)
        {
            db.HoaDons.Add(hd);
            db.SaveChanges();
        }
        public HoaDon getRow(int mahd)
        {
            return db.HoaDons.Find(mahd);
        }
        public void Delete(HoaDon hd)
        {
            db.HoaDons.Remove(hd);
            db.SaveChanges();
        }
        public void Update(HoaDon hd)
        {
            db.Entry(hd).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
