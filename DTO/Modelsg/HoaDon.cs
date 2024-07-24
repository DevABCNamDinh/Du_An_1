using System;
using System.Collections.Generic;

namespace DTO.Modelsg
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public string IdhoaDon { get; set; } = null!;
        public string? IdnhanVien { get; set; }
        public string? IdkhachHang { get; set; }
        public DateTime? NgayDatHang { get; set; }
        public double? TongGiaTriDonHang { get; set; }
        public string? TrangThaiThanhToan { get; set; }

        public virtual KhachHang? IdkhachHangNavigation { get; set; }
        public virtual NhanVien? IdnhanVienNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
