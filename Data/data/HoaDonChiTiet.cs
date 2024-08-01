using System;
using System.Collections.Generic;

namespace Data.data;

public partial class HoaDonChiTiet
{
    public string IdhoaDonChiTiet { get; set; } = null!;

    public string? IdsanPham { get; set; }

    public string? IdhoaDon { get; set; }

    public string? IdkhuyenMai { get; set; }

    public int? SoLuong { get; set; }

    public decimal? Gia { get; set; }

    public virtual HoaDon? IdhoaDonNavigation { get; set; }

    public virtual SanPham? IdsanPhamNavigation { get; set; }
}
