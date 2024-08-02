using System;
using System.Collections.Generic;

namespace Data.Data;

public partial class KhachHang
{
    public string IdkhachHang { get; set; } = null!;

    public string? Ten { get; set; }

    public bool? GioiTinh { get; set; }

    public string? Email { get; set; }

    public string? Sdt { get; set; }

    public string Diachi { get; set; } = null!;

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
