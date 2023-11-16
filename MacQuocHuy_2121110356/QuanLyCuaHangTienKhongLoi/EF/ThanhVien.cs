namespace QuanLyCuaHangTienKhongLoi.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]
    public partial class ThanhVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaThanhVien { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string DienThoai { get; set; }

        [Required]
        [StringLength(50)]
        public string Quyen { get; set; }

        [Column(TypeName = "image")]
        public byte[] Hinh { get; set; }
    }
}
