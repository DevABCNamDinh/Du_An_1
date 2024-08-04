using DAL.Repository;
using Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhacHangBUS
    {
        KhachHangRepository repos;
        public KhacHangBUS()
        {
            repos = new KhachHangRepository();

        }
    
        public List<KhachHang> GetKhachHangs(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAllKhachHang();
            }
            else
            {
                return repos.GetAllKhachHang().Where(x => x.Ten.Contains(search)).ToList();
            }
        }
        public string themNV(KhachHang kh)
        {
            if (repos.ThemKhachHang(kh))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string xoaNV(KhachHang kh)
        {
            if (repos.XoaNhanVien(kh))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
        public string suaNV(KhachHang kh)
        {
            if (repos.SuaNhanVien(kh))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
