

using Data.DataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongTinKhachHangDAL
    {
        CsdlDuAn1NewNew2Context dbContext = new CsdlDuAn1NewNew2Context();

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
