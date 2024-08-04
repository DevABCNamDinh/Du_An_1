using Data.Model;



using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class KhachHangRepository
    {

        CsdlDuAn1Context context;
        public KhachHangRepository()
        {
            context = new CsdlDuAn1Context();
        }
        public List<KhachHang> GetAllKhachHang()
        {
            return context.KhachHangs.ToList();
        }
        public bool ThemKhachHang(KhachHang kh)
        {
            if(kh == null)
            {
                return false;
            }
            context.KhachHangs.Add(kh);
            context.SaveChanges();
            return true;
        }
        public bool SuaNhanVien(KhachHang kh)
        {
            if(kh == null)
            {
                return false;
            }
            context.KhachHangs.Update(kh);
            context.SaveChanges();
            return true;
        }
        public bool XoaNhanVien(KhachHang kh)
        {
            if(kh == null)
            {
                return false;
            }
            context.KhachHangs.Remove(kh);
            context.SaveChanges();
            return true;
        }
    }

}
