using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data.Data;

public partial class CsdlDuAn1Context : DbContext
{
    public CsdlDuAn1Context()
    {
    }

    public CsdlDuAn1Context(DbContextOptions<CsdlDuAn1Context> options)
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

    public virtual DbSet<ThanhTien> ThanhTiens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6F71DIH\\SQLEXPRESS;Database=CSDL_DuAn_1;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.IdchucVu).HasName("PK__ChucVu__70FCCF6575380A7B");

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
            entity.HasKey(e => e.IdhoaDon).HasName("PK__HoaDon__5B896F49AAB9A637");

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
                .HasConstraintName("FK__HoaDon__IDKhachH__5535A963");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdnhanVien)
                .HasConstraintName("FK__HoaDon__IDNhanVi__5629CD9C");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.IdhoaDonChiTiet).HasName("PK__HoaDonCh__21C23677EBC90804");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.IdhoaDonChiTiet)
                .HasMaxLength(10)
                .HasColumnName("IDHoaDonChiTiet");
            entity.Property(e => e.Gia).HasColumnType("money");
            entity.Property(e => e.IdhoaDon)
                .HasMaxLength(10)
                .HasColumnName("IDHoaDon");
            entity.Property(e => e.IdsanPham)
                .HasMaxLength(10)
                .HasColumnName("IDSanPham");
            entity.Property(e => e.KhuyenMai).HasMaxLength(10);

            entity.HasOne(d => d.IdhoaDonNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdhoaDon)
                .HasConstraintName("FK__HoaDonChi__IDHoa__5EBF139D");

            entity.HasOne(d => d.IdsanPhamNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdsanPham)
                .HasConstraintName("FK__HoaDonChi__IDSan__5FB337D6");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.IdkhachHang).HasName("PK__KhachHan__5A7167B5F4553D76");

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
            entity.HasKey(e => e.IdkhuyenMai).HasName("PK__KhuyenMa__FFAC140028E455BE");

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
            entity.HasKey(e => e.IdloaiSanPham).HasName("PK__LoaiSanP__6CB987C502692B2F");

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
                .HasConstraintName("FK__LoaiSanPh__IDKhu__4BAC3F29");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.IdnhanVien).HasName("PK__NhanVien__7AC2D9F753DE7605");

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
                .HasConstraintName("FK__NhanVien__IDChuc__5070F446");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.IdsanPham).HasName("PK__SanPham__9D45E58A643DF533");

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
                .HasConstraintName("FK__SanPham__IDLoaiS__5BE2A6F2");
        });

        modelBuilder.Entity<ThanhTien>(entity =>
        {
            entity.HasKey(e => e.IdthanhTien).HasName("PK__ThanhTie__34C64E685744273A");

            entity.ToTable("ThanhTien");

            entity.Property(e => e.IdthanhTien)
                .HasMaxLength(10)
                .HasColumnName("IDThanhTien");
            entity.Property(e => e.IdhoaDon)
                .HasMaxLength(10)
                .HasColumnName("IDHoaDon");
            entity.Property(e => e.KhuyenMai).HasColumnType("money");
            entity.Property(e => e.ThanhTien1)
                .HasColumnType("money")
                .HasColumnName("ThanhTien");
            entity.Property(e => e.TienKhachDua).HasColumnType("money");
            entity.Property(e => e.TienThua).HasColumnType("money");
            entity.Property(e => e.TongHoaDon).HasColumnType("money");

            entity.HasOne(d => d.IdhoaDonNavigation).WithMany(p => p.ThanhTiens)
                .HasForeignKey(d => d.IdhoaDon)
                .HasConstraintName("FK__ThanhTien__IDHoa__59063A47");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
