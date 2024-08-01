using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DTO.Modelsg
{
    public partial class CSDL_DuAn_1_HoanChinhContext : DbContext
    {
        public CSDL_DuAn_1_HoanChinhContext()
        {
        }

        public CSDL_DuAn_1_HoanChinhContext(DbContextOptions<CSDL_DuAn_1_HoanChinhContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; } = null!;
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<SanPhamChiTiet> SanPhamChiTiets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-6F71DIH\\SQLEXPRESS;Database=CSDL_DuAn_1_HoanChinh;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.IdchucVu)
                    .HasName("PK__ChucVu__70FCCF650B537EB4");

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
                entity.HasKey(e => e.IdhoaDon)
                    .HasName("PK__HoaDon__5B896F4940D1A17A");

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

                entity.Property(e => e.NgayDatHang).HasColumnType("date");

                entity.Property(e => e.TrangThaiThanhToan).HasMaxLength(20);

                entity.HasOne(d => d.IdkhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdkhachHang)
                    .HasConstraintName("FK__HoaDon__IDKhachH__44FF419A");

                entity.HasOne(d => d.IdnhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdnhanVien)
                    .HasConstraintName("FK__HoaDon__IDNhanVi__45F365D3");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.IdhoaDonChiTiet)
                    .HasName("PK__HoaDonCh__21C23677CB80F4D6");

                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.IdhoaDonChiTiet)
                    .HasMaxLength(10)
                    .HasColumnName("IDHoaDonChiTiet");

                entity.Property(e => e.IdhoaDon)
                    .HasMaxLength(10)
                    .HasColumnName("IDHoaDon");

                entity.Property(e => e.IdkhuyenMai)
                    .HasMaxLength(10)
                    .HasColumnName("IDKhuyenMai");

                entity.Property(e => e.IdsanPhamChiTiet)
                    .HasMaxLength(10)
                    .HasColumnName("IDSanPhamChiTiet");

                entity.HasOne(d => d.IdhoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdhoaDon)
                    .HasConstraintName("FK__HoaDonChi__Thanh__4CA06362");

                entity.HasOne(d => d.IdsanPhamChiTietNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdsanPhamChiTiet)
                    .HasConstraintName("FK__HoaDonChi__IDSan__4D94879B");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.IdkhachHang)
                    .HasName("PK__KhachHan__5A7167B5BA3235FD");

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
                entity.HasKey(e => e.IdkhuyenMai)
                    .HasName("PK__KhuyenMa__FFAC14004A2C0705");

                entity.ToTable("KhuyenMai");

                entity.Property(e => e.IdkhuyenMai)
                    .HasMaxLength(10)
                    .HasColumnName("IDKhuyenMai");

                entity.Property(e => e.IdsanPham)
                    .HasMaxLength(10)
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.MoTa).HasMaxLength(100);

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");

                entity.Property(e => e.TenKhuyenMai).HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.IdloaiSanPham)
                    .HasName("PK__LoaiSanP__6CB987C5433223E8");

                entity.ToTable("LoaiSanPham");

                entity.Property(e => e.IdloaiSanPham)
                    .HasMaxLength(10)
                    .HasColumnName("IDLoaiSanPham");

                entity.Property(e => e.LoaiSanPham1)
                    .HasMaxLength(50)
                    .HasColumnName("LoaiSanPham");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.IdnhanVien)
                    .HasName("PK__NhanVien__7AC2D9F7BBFBE011");

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

                entity.HasOne(d => d.IdchucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdchucVu)
                    .HasConstraintName("FK__NhanVien__IDChuc__403A8C7D");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.IdsanPham)
                    .HasName("PK__SanPham__9D45E58A919CEB87");

                entity.ToTable("SanPham");

                entity.Property(e => e.IdsanPham)
                    .HasMaxLength(10)
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.IdkhuyenMai)
                    .HasMaxLength(10)
                    .HasColumnName("IDKhuyenMai");

                entity.Property(e => e.TenSanPham).HasMaxLength(100);

                entity.HasOne(d => d.IdkhuyenMaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdkhuyenMai)
                    .HasConstraintName("FK__SanPham__IDKhuye__398D8EEE");
            });

            modelBuilder.Entity<SanPhamChiTiet>(entity =>
            {
                entity.HasKey(e => e.IdsanPhamChiTiet)
                    .HasName("PK__SanPhamC__2873C60B29155009");

                entity.ToTable("SanPhamChiTiet");

                entity.Property(e => e.IdsanPhamChiTiet)
                    .HasMaxLength(10)
                    .HasColumnName("IDSanPhamChiTiet");

                entity.Property(e => e.ChiSoFa)
                    .HasMaxLength(20)
                    .HasColumnName("ChiSoFA");

                entity.Property(e => e.ChiSoSpf)
                    .HasMaxLength(20)
                    .HasColumnName("ChiSoSPF");

                entity.Property(e => e.GiaBan).HasColumnType("money");

                entity.Property(e => e.GiaNhap).HasColumnType("money");

                entity.Property(e => e.HanSuDung).HasColumnType("date");

                entity.Property(e => e.IdloaiSanPham)
                    .HasMaxLength(10)
                    .HasColumnName("IDLoaiSanPham");

                entity.Property(e => e.IdsanPham)
                    .HasMaxLength(10)
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.NguonGoc).HasMaxLength(50);

                entity.HasOne(d => d.IdloaiSanPhamNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.IdloaiSanPham)
                    .HasConstraintName("FK__SanPhamCh__IDLoa__49C3F6B7");

                entity.HasOne(d => d.IdsanPhamNavigation)
                    .WithMany(p => p.SanPhamChiTiets)
                    .HasForeignKey(d => d.IdsanPham)
                    .HasConstraintName("FK__SanPhamCh__IDSan__48CFD27E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
