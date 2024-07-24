using System;
using System.Collections.Generic;

namespace DTO.Modelsg
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string IdkhachHang { get; set; } = null!;
        public string? Ten { get; set; }
        public bool? GioiTinh { get; set; }
        public string? Email { get; set; }
        public string? Sdt { get; set; }
        public string Diachi { get; set; } = null!;

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
