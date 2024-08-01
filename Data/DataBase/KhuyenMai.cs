using System;
using System.Collections.Generic;

namespace Data.DataBase;

public partial class KhuyenMai
{
    public string IdkhuyenMai { get; set; } = null!;

    public string? TenKhuyenMai { get; set; }

    public DateTime? NgayBatDau { get; set; }

    public DateTime? NgayKetThuc { get; set; }

    public double? PhanTramGiamGia { get; set; }

    public string? MoTa { get; set; }

    public bool? TrangThai { get; set; }

    public virtual ICollection<LoaiSanPham> LoaiSanPhams { get; set; } = new List<LoaiSanPham>();
}
