namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class qlsieuthiModels : DbContext
    {
        public qlsieuthiModels()
            : base("name=qlsieuthiModels")
        {
        }

        public virtual DbSet<chitiethoadon> chitiethoadons { get; set; }
        public virtual DbSet<chitietphieugiaoca> chitietphieugiaocas { get; set; }
        public virtual DbSet<chitietphieuxuat> chitietphieuxuats { get; set; }
        public virtual DbSet<chucvu> chucvus { get; set; }
        public virtual DbSet<hoadon> hoadons { get; set; }
        public virtual DbSet<khachhang> khachhangs { get; set; }
        public virtual DbSet<khohang> khohangs { get; set; }
        public virtual DbSet<mathang> mathangs { get; set; }
        public virtual DbSet<nhacungcap> nhacungcaps { get; set; }
        public virtual DbSet<nhanvien> nhanviens { get; set; }
        public virtual DbSet<phieugiaoca> phieugiaocas { get; set; }
        public virtual DbSet<phieuxuatkho> phieuxuatkhoes { get; set; }
        public virtual DbSet<quayhang> quayhangs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<chucvu>()
            //    .HasMany(e => e.nhanviens)
            //    .WithOptional(e => e.chucvu)
            //    .HasForeignKey(e => e.machucvu);

            //modelBuilder.Entity<hoadon>()
            //    .HasMany(e => e.chitiethoadons)
            //    .WithOptional(e => e.hoadon)
            //    .HasForeignKey(e => e.mahoadon);

            //modelBuilder.Entity<hoadon>()
            //    .HasMany(e => e.khachmuahangs)
            //    .WithOptional(e => e.hoadon)
            //    .HasForeignKey(e => e.mahoadon);

            //modelBuilder.Entity<khachhang>()
            //    .HasMany(e => e.khachmuahangs)
            //    .WithOptional(e => e.khachhang)
            //    .HasForeignKey(e => e.makhachhang);

            //modelBuilder.Entity<khohang>()
            //    .HasMany(e => e.phieukiemkes)
            //    .WithOptional(e => e.khohang)
            //    .HasForeignKey(e => e.makhohang);

            //modelBuilder.Entity<khohang>()
            //    .HasMany(e => e.phieunhapkhoes)
            //    .WithOptional(e => e.khohang)
            //    .HasForeignKey(e => e.makhohang);

            //modelBuilder.Entity<khohang>()
            //    .HasMany(e => e.phieuxuatkhoes)
            //    .WithOptional(e => e.khohang)
            //    .HasForeignKey(e => e.makhohang);

            //modelBuilder.Entity<mathang>()
            //    .HasMany(e => e.chitiepphieunhaps)
            //    .WithOptional(e => e.mathang)
            //    .HasForeignKey(e => e.mamathang);

            //modelBuilder.Entity<mathang>()
            //    .HasMany(e => e.chitiethoadons)
            //    .WithOptional(e => e.mathang)
            //    .HasForeignKey(e => e.mamathang);

            //modelBuilder.Entity<mathang>()
            //    .HasMany(e => e.chitietphieugiaocas)
            //    .WithOptional(e => e.mathang)
            //    .HasForeignKey(e => e.mamathang);

            //modelBuilder.Entity<mathang>()
            //    .HasMany(e => e.chitietphieuxuats)
            //    .WithOptional(e => e.mathang)
            //    .HasForeignKey(e => e.maxuat);

            //modelBuilder.Entity<mathang>()
            //    .HasMany(e => e.hoadons)
            //    .WithOptional(e => e.mathang)
            //    .HasForeignKey(e => e.mamathang);

            //modelBuilder.Entity<mathang>()
            //    .HasMany(e => e.phieukiemkes)
            //    .WithOptional(e => e.mathang)
            //    .HasForeignKey(e => e.mamathang);

            //modelBuilder.Entity<nhacungcap>()
            //    .HasMany(e => e.phieunhapkhoes)
            //    .WithOptional(e => e.nhacungcap)
            //    .HasForeignKey(e => e.manhacungcap);

            //modelBuilder.Entity<nhanvien>()
            //    .HasMany(e => e.hoadons)
            //    .WithOptional(e => e.nhanvien)
            //    .HasForeignKey(e => e.manhanvien);

            //modelBuilder.Entity<nhanvien>()
            //    .HasMany(e => e.phieugiaocas)
            //    .WithOptional(e => e.nhanvien)
            //    .HasForeignKey(e => e.manhanvien);

            //modelBuilder.Entity<nhanvien>()
            //    .HasMany(e => e.phieukiemkes)
            //    .WithOptional(e => e.nhanvien)
            //    .HasForeignKey(e => e.manhanvien);

            //modelBuilder.Entity<nhanvien>()
            //    .HasMany(e => e.phieunhapkhoes)
            //    .WithOptional(e => e.nhanvien)
            //    .HasForeignKey(e => e.manhanvien);

            //modelBuilder.Entity<nhanvien>()
            //    .HasMany(e => e.phieuxuatkhoes)
            //    .WithOptional(e => e.nhanvien)
            //    .HasForeignKey(e => e.manhanvien);

            //modelBuilder.Entity<phieugiaoca>()
            //    .HasMany(e => e.chitietphieugiaocas)
            //    .WithOptional(e => e.phieugiaoca)
            //    .HasForeignKey(e => e.magiaoca);

            //modelBuilder.Entity<phieunhapkho>()
            //    .HasMany(e => e.chitiepphieunhaps)
            //    .WithOptional(e => e.phieunhapkho)
            //    .HasForeignKey(e => e.manhap);

            //modelBuilder.Entity<phieuxuatkho>()
            //    .HasMany(e => e.chitietphieuxuats)
            //    .WithOptional(e => e.phieuxuatkho)
            //    .HasForeignKey(e => e.maxuat);

            //modelBuilder.Entity<quayhang>()
            //    .HasMany(e => e.mathangs)
            //    .WithOptional(e => e.quayhang)
            //    .HasForeignKey(e => e.maquay);

            //modelBuilder.Entity<quayhang>()
            //    .HasMany(e => e.phieugiaocas)
            //    .WithOptional(e => e.quayhang)
            //    .HasForeignKey(e => e.maquay);

            //modelBuilder.Entity<quayhang>()
            //    .HasMany(e => e.phieuxuatkhoes)
            //    .WithOptional(e => e.quayhang)
            //    .HasForeignKey(e => e.maquay);
        }
    }
}
