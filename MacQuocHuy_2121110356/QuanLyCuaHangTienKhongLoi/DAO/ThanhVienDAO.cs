using QuanLyCuaHangTienKhongLoi.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienKhongLoi.DAO
{
    class ThanhVienDAO
    {
        QLBanHangContext db = new QLBanHangContext();
        public ThanhVienDAO()
        {
            db = new QLBanHangContext();
        }
        public List<ThanhVien> getList()
        {
            List<ThanhVien> list = db.ThanhViens.ToList();
            return list;
        }
        public int getCount()
        {
            return db.ThanhViens.Count();
        }
        public void Insert(ThanhVien tv)
        {
            db.ThanhViens.Add(tv);
            db.SaveChanges();
        }
        public void Update(ThanhVien tv)
        {
            db.Entry(tv).State = EntityState.Modified;
            db.SaveChanges();
        }
        public ThanhVien getRow(int tv)
        {
            return db.ThanhViens.Find(tv);
        }
        public ThanhVien GetRowBySomeProperty(string someValue)
        {
            return db.ThanhViens.FirstOrDefault(tv => tv.TenDangNhap == someValue);
        }
        public ThanhVien GetRowBySomeProperty1(string someValue)
        {
            return db.ThanhViens.FirstOrDefault(tv => tv.DienThoai == someValue);
        }
        public void Delete(ThanhVien tv)
        {
            db.ThanhViens.Remove(tv);
            db.SaveChanges();
        }

    }
}
