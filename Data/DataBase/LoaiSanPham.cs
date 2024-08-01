using System;
using System.Collections.Generic;

namespace Data.DataBase;

public partial class LoaiSanPham
{
    public string IdloaiSanPham { get; set; } = null!;

    public string? IdkhuyenMai { get; set; }

    public string? LoaiSanPham1 { get; set; }

    public virtual KhuyenMai? IdkhuyenMaiNavigation { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
