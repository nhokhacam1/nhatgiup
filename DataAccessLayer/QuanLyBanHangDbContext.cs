namespace QuanLyBanHang.DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyBanHangDbContext : DbContext
    {
        public QuanLyBanHangDbContext()
            : base("name=QuanLyBanHangDbContext")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblChiTietHDBan> tblChiTietHDBans { get; set; }
        public virtual DbSet<tblHang> tblHangs { get; set; }
        public virtual DbSet<tblHangSX> tblHangSXes { get; set; }
        public virtual DbSet<tblHDBan> tblHDBans { get; set; }
        public virtual DbSet<tblKhach> tblKhaches { get; set; }
        public virtual DbSet<tblNhanVien> tblNhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblHang>()
                .HasMany(e => e.tblChiTietHDBans)
                .WithRequired(e => e.tblHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblHangSX>()
                .HasMany(e => e.tblHangs)
                .WithRequired(e => e.tblHangSX)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblHDBan>()
                .HasMany(e => e.tblChiTietHDBans)
                .WithRequired(e => e.tblHDBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblKhach>()
                .HasMany(e => e.tblHDBans)
                .WithRequired(e => e.tblKhach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblNhanVien>()
                .HasMany(e => e.tblHDBans)
                .WithRequired(e => e.tblNhanVien)
                .WillCascadeOnDelete(false);
        }
    }
}
