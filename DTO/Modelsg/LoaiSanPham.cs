using System;
using System.Collections.Generic;

namespace DTO.Modelsg
{
    public partial class LoaiSanPham
    {
        public LoaiSanPham()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public string IdloaiSanPham { get; set; } = null!;
        public string? LoaiSanPham1 { get; set; }

        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
