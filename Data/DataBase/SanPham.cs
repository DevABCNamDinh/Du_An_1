using System;
using System.Collections.Generic;

namespace Data.DataBase;

public partial class SanPham
{
    public string IdsanPham { get; set; } = null!;

    public string? IdloaiSanPham { get; set; }

    public string? TenSanPham { get; set; }

    public int SoLuong { get; set; }

    public decimal? GiaNhap { get; set; }

    public double? KhoiLuong { get; set; }

    public string? NguonGoc { get; set; }

    public DateOnly? HanSuDung { get; set; }

    public string? ChiSoSpf { get; set; }

    public string? ChiSoFa { get; set; }

    public decimal? GiaBan { get; set; }

    public bool? TrangThai { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual LoaiSanPham? IdloaiSanPhamNavigation { get; set; }
}
