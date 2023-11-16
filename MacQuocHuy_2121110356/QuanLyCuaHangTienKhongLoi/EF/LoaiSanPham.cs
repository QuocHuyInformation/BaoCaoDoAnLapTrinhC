namespace QuanLyCuaHangTienKhongLoi.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiSanPham")]
    public partial class LoaiSanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLoai { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoai { get; set; }
    }
}
