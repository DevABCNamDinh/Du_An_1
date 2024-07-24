using System;
using System.Collections.Generic;

namespace DTO.Modelsg
{
    public partial class HoaDonChiTiet
    {
        public string IdhoaDonChiTiet { get; set; } = null!;
        public string? IdsanPhamChiTiet { get; set; }
        public string? IdhoaDon { get; set; }
        public string? IdkhuyenMai { get; set; }
        public int? SoLuong { get; set; }
        public double? Gia { get; set; }
        public double? ThanhTien { get; set; }

        public virtual HoaDon? IdhoaDonNavigation { get; set; }
        public virtual SanPhamChiTiet? IdsanPhamChiTietNavigation { get; set; }
    }
}
