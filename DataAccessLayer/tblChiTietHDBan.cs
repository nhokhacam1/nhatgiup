namespace QuanLyBanHang.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChiTietHDBan")]
    public partial class tblChiTietHDBan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string MaHDBan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaHang { get; set; }

        public double SoLuong { get; set; }

        public double DonGia { get; set; }

        public double GiamGia { get; set; }

        public double ThanhTien { get; set; }

        public virtual tblHang tblHang { get; set; }

        public virtual tblHDBan tblHDBan { get; set; }
    }
}
