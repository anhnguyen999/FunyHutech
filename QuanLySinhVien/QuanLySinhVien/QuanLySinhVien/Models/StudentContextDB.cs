namespace QuanLySinhVien.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StudentContextDB : DbContext
    {
        public StudentContextDB()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ChuyenNganh> ChuyenNganhs { get; set; }
        public virtual DbSet<DangKyMonHoc> DangKyMonHocs { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DangKyMonHoc>()
                .Property(e => e.MaSV)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSV)
                .IsUnicode(false);
        }
    }
}
