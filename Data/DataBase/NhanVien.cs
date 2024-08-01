using System;
using System.Collections.Generic;

namespace Data.DataBase;

public partial class NhanVien
{
    public string IdnhanVien { get; set; } = null!;

    public string? IdchucVu { get; set; }

    public string? TenNhanVien { get; set; }

    public string? Email { get; set; }

    public string? Sdt { get; set; }

    public bool? GioiTinh { get; set; }

    public string? Taikhoan { get; set; }

    public string? MatKhau { get; set; }

    public bool? TrangThaiLamViec { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ChucVu? IdchucVuNavigation { get; set; }
}
