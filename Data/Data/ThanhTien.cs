using System;
using System.Collections.Generic;

namespace Data.Data;

public partial class ThanhTien
{
    public string IdthanhTien { get; set; } = null!;

    public string? IdhoaDon { get; set; }

    public decimal? TongHoaDon { get; set; }

    public decimal? KhuyenMai { get; set; }

    public decimal? ThanhTien1 { get; set; }

    public decimal? TienKhachDua { get; set; }

    public decimal? TienThua { get; set; }

    public virtual HoaDon? IdhoaDonNavigation { get; set; }
}
