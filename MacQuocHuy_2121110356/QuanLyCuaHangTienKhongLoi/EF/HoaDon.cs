namespace QuanLyCuaHangTienKhongLoi.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        public int MaSanPham { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSanPham { get; set; }

        public int SoLuong { get; set; }

        public int Gia { get; set; }

        public int ThanhTien { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNhanVien { get; set; }

        public int MaKhachHang { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKhachHang { get; set; }

        [Required]
        [StringLength(50)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayBan { get; set; }
    }
}
