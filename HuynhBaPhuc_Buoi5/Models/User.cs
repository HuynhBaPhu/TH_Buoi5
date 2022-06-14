namespace HuynhBaPhuc_Buoi5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [StringLength(50)]
        public string HoTen { get; set; }

        [Key]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [StringLength(50)]
        public string Mk { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        public DateTime? NgaySinh { get; set; }
    }
}
