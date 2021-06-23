namespace QuanLyBanHang.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHDBan")]
    public partial class tblHDBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHDBan()
        {
            tblChiTietHDBans = new HashSet<tblChiTietHDBan>();
        }

        [Key]
        [StringLength(30)]
        public string MaHDBan { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNhanVien { get; set; }

        public DateTime NgayBan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKhach { get; set; }

        public double TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietHDBan> tblChiTietHDBans { get; set; }

        public virtual tblKhach tblKhach { get; set; }

        public virtual tblNhanVien tblNhanVien { get; set; }
    }
}
