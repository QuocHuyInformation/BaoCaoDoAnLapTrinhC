using QuanLyCuaHangTienKhongLoi.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienKhongLoi.DAO
{
    class NhanVienDAO
    {
        QLBanHangContext db = null;
        public NhanVienDAO ()
        {
            db = new QLBanHangContext();
        }
        public List<NhanVien> getList()
        {
            return db.NhanViens.ToList();
        }
        public void Insert(NhanVien NhanVien)
        {
            db.NhanViens.Add(NhanVien);
            db.SaveChanges();
        }
        public void Update(NhanVien NhanVien)
        {
            db.Entry(NhanVien).State = EntityState.Modified;
            db.SaveChanges();
        }
        public NhanVien getRow(int maNhanVien)
        {
            return db.NhanViens.Find(maNhanVien);
        }
        public void Delete(NhanVien NhanVien)
        {
            db.NhanViens.Remove(NhanVien);
            db.SaveChanges();
        }

    }
}
