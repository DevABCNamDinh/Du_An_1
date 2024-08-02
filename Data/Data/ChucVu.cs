using System;
using System.Collections.Generic;

namespace Data.Data;

public partial class ChucVu
{
    public string IdchucVu { get; set; } = null!;

    public string? ChucVu1 { get; set; }

    public string? GhiChu { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
