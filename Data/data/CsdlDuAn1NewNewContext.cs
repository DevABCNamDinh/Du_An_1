using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data.data;

public partial class CsdlDuAn1NewNewContext : DbContext
{
    public CsdlDuAn1NewNewContext()
    {
    }

    public CsdlDuAn1NewNewContext(DbContextOptions<CsdlDuAn1NewNewContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6F71DIH\\SQLEXPRESS;Database=CSDL_DuAn_1_NewNew;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.IdchucVu).HasName("PK__ChucVu__70FCCF65BF7D0027");

            entity.ToTable("ChucVu");

            entity.Property(e => e.IdchucVu)
                .HasMaxLength(10)
                .HasColumnName("IDChucVu");
            entity.Property(e => e.ChucVu1)
                .HasMaxLength(100)
                .HasColumnName("ChucVu");
            entity.Property(e => e.GhiChu).HasMaxLength(100);
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.IdhoaDon).HasName("PK__HoaDon__5B896F49134A3158");

            entity.ToTable("HoaDon");

            entity.Property(e => e.IdhoaDon)
                .HasMaxLength(10)
                .HasColumnName("IDHoaDon");
            entity.Property(e => e.IdkhachHang)
                .HasMaxLength(10)
                .HasColumnName("IDKhachHang");
            entity.Property(e => e.IdnhanVien)
                .HasMaxLength(10)
                .HasColumnName("IDNhanVien");
            entity.Property(e => e.NgayDatHang).HasColumnType("datetime");

            entity.HasOne(d => d.IdkhachHangNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdkhachHang)
                .HasConstraintName("FK__HoaDon__IDKhachH__46E78A0C");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdnhanVien)
                .HasConstraintName("FK__HoaDon__IDNhanVi__47DBAE45");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.IdhoaDonChiTiet).HasName("PK__HoaDonCh__21C23677AD6524CC");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.IdhoaDonChiTiet)
                .HasMaxLength(10)
                .HasColumnName("IDHoaDonChiTiet");
            entity.Property(e => e.Gia).HasColumnType("money");
            entity.Property(e => e.IdhoaDon)
                .HasMaxLength(10)
                .HasColumnName("IDHoaDon");
            entity.Property(e => e.IdkhuyenMai)
                .HasMaxLength(10)
                .HasColumnName("IDKhuyenMai");
            entity.Property(e => e.IdsanPham)
                .HasMaxLength(10)
                .HasColumnName("IDSanPham");

            entity.HasOne(d => d.IdhoaDonNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdhoaDon)
                .HasConstraintName("FK__HoaDonChi__IDHoa__4D94879B");

            entity.HasOne(d => d.IdsanPhamNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdsanPham)
                .HasConstraintName("FK__HoaDonChi__IDSan__4E88ABD4");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.IdkhachHang).HasName("PK__KhachHan__5A7167B5AECCEDE4");

            entity.ToTable("KhachHang");

            entity.Property(e => e.IdkhachHang)
                .HasMaxLength(10)
                .HasColumnName("IDKhachHang");
            entity.Property(e => e.Diachi).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Sdt).HasMaxLength(12);
            entity.Property(e => e.Ten).HasMaxLength(100);
        });

        modelBuilder.Entity<KhuyenMai>(entity =>
        {
            entity.HasKey(e => e.IdkhuyenMai).HasName("PK__KhuyenMa__FFAC1400DC109ACA");

            entity.ToTable("KhuyenMai");

            entity.Property(e => e.IdkhuyenMai)
                .HasMaxLength(10)
                .HasColumnName("IDKhuyenMai");
            entity.Property(e => e.MoTa).HasMaxLength(100);
            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            entity.Property(e => e.TenKhuyenMai).HasMaxLength(50);
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.IdloaiSanPham).HasName("PK__LoaiSanP__6CB987C5280ABCA4");

            entity.ToTable("LoaiSanPham");

            entity.Property(e => e.IdloaiSanPham)
                .HasMaxLength(10)
                .HasColumnName("IDLoaiSanPham");
            entity.Property(e => e.IdkhuyenMai)
                .HasMaxLength(10)
                .HasColumnName("IDKhuyenMai");
            entity.Property(e => e.LoaiSanPham1)
                .HasMaxLength(50)
                .HasColumnName("LoaiSanPham");

            entity.HasOne(d => d.IdkhuyenMaiNavigation).WithMany(p => p.LoaiSanPhams)
                .HasForeignKey(d => d.IdkhuyenMai)
                .HasConstraintName("FK__LoaiSanPh__IDKhu__3D5E1FD2");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.IdnhanVien).HasName("PK__NhanVien__7AC2D9F73C1E14F3");

            entity.ToTable("NhanVien");

            entity.Property(e => e.IdnhanVien)
                .HasMaxLength(10)
                .HasColumnName("IDNhanVien");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdchucVu)
                .HasMaxLength(10)
                .HasColumnName("IDChucVu");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Taikhoan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TenNhanVien).HasMaxLength(100);

            entity.HasOne(d => d.IdchucVuNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdchucVu)
                .HasConstraintName("FK__NhanVien__IDChuc__4222D4EF");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.IdsanPham).HasName("PK__SanPham__9D45E58AD9FCD5A9");

            entity.ToTable("SanPham");

            entity.Property(e => e.IdsanPham)
                .HasMaxLength(10)
                .HasColumnName("IDSanPham");
            entity.Property(e => e.ChiSoFa)
                .HasMaxLength(20)
                .HasColumnName("ChiSoFA");
            entity.Property(e => e.ChiSoSpf)
                .HasMaxLength(20)
                .HasColumnName("ChiSoSPF");
            entity.Property(e => e.GiaBan).HasColumnType("money");
            entity.Property(e => e.GiaNhap).HasColumnType("money");
            entity.Property(e => e.IdloaiSanPham)
                .HasMaxLength(10)
                .HasColumnName("IDLoaiSanPham");
            entity.Property(e => e.NguonGoc).HasMaxLength(50);
            entity.Property(e => e.TenSanPham).HasMaxLength(100);

            entity.HasOne(d => d.IdloaiSanPhamNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdloaiSanPham)
                .HasConstraintName("FK__SanPham__IDLoaiS__4AB81AF0");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
