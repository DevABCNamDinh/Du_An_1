using System;
using System.Collections.Generic;

namespace DTO.Modelsg
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string IdnhanVien { get; set; } = null!;
        public string? IdchucVu { get; set; }
        public string? TenNhanVien { get; set; }
        
        public string? Email { get; set; }
        public string? Sdt { get; set; }
        public bool? GioiTinh { get; set; }
        public string? Taikhoan { get; set; }
        public string? MatKhau { get; set; }

        public virtual ChucVu? IdchucVuNavigation { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
