using System;
using System.Collections.Generic;

namespace Data.Data;

public partial class HoaDon
{
    public string IdhoaDon { get; set; } = null!;

    public string? IdnhanVien { get; set; }

    public string? IdkhachHang { get; set; }

    public DateTime? NgayDatHang { get; set; }

    public int? TrangThaiThanhToan { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual KhachHang? IdkhachHangNavigation { get; set; }

    public virtual NhanVien? IdnhanVienNavigation { get; set; }

    public virtual ICollection<ThanhTien> ThanhTiens { get; set; } = new List<ThanhTien>();
}
