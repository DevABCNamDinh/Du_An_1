using System;
using System.Collections.Generic;

namespace DTO.Modelsg
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string IdkhuyenMai { get; set; } = null!;
        public string? IdsanPham { get; set; }
        public string? TenKhuyenMai { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public double? PhanTramGiamGia { get; set; }
        public string? MoTa { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
