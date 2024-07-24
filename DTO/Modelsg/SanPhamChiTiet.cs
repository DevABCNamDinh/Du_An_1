using System;
using System.Collections.Generic;

namespace DTO.Modelsg
{
    public partial class SanPhamChiTiet
    {
        public SanPhamChiTiet()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public string IdsanPhamChiTiet { get; set; } = null!;
        public string? IdsanPham { get; set; }
        public string? IdloaiSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal? GiaNhap { get; set; }
        public double? KhoiLuong { get; set; }
        public string? NguonGoc { get; set; }
        public DateTime? HanSuDung { get; set; }
        public string? ChiSoSpf { get; set; }
        public string? ChiSoFa { get; set; }
        public decimal? GiaBan { get; set; }

        public virtual LoaiSanPham? IdloaiSanPhamNavigation { get; set; }
        public virtual SanPham? IdsanPhamNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
