using System;
using System.Collections.Generic;

namespace DTO.Modelsg
{
    public partial class SanPham
    {
        public SanPham()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public string IdsanPham { get; set; } = null!;
        public string? IdkhuyenMai { get; set; }
        public string? TenSanPham { get; set; }

        public virtual KhuyenMai? IdkhuyenMaiNavigation { get; set; }
        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
