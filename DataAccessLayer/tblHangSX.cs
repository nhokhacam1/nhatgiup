namespace QuanLyBanHang.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHangSX")]
    public partial class tblHangSX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHangSX()
        {
            tblHangs = new HashSet<tblHang>();
        }

        [Key]
        [StringLength(50)]
        public string MaHangSX { get; set; }

        [StringLength(50)]
        public string TenHangSX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHang> tblHangs { get; set; }
    }
}
