namespace QuanLyCuaHangTienKhongLoi.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayNhap { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayXuat { get; set; }

        public int SoLuong { get; set; }

        public int GiaBan { get; set; }

        [Required]
        [StringLength(50)]
        public string Loai { get; set; }

        [Column(TypeName = "image")]
        public byte[] Hinh { get; set; }
    }
}
