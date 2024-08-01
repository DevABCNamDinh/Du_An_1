using System;
using System.Collections.Generic;

namespace DTO.Modelsg
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public string IdchucVu { get; set; } = null!;
        public string? ChucVu1 { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
