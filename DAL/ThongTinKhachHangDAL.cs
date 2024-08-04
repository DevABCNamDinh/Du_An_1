
using Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongTinKhachHangDAL
    {
        CsdlDuAn1Context dbContext = new CsdlDuAn1Context();

        public KhachHang? GetkhachHangBySDT(string Sdt)
        {
            return dbContext.KhachHangs.FirstOrDefault(kh => kh.Sdt == Sdt);
        }

        public KhachHang? GetkhachHangByID(string ID)
        {
            return dbContext.KhachHangs.FirstOrDefault(kh => kh.IdkhachHang == ID);
        }

    }
}
