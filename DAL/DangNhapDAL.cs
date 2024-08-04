using Data.Modele;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangNhapDAL
    {
        CsdlDuAn1Context dbContext = new CsdlDuAn1Context();



        public NhanVien? DangNhap(string username, string password)
        {
            return dbContext.NhanViens.FirstOrDefault(nv => nv.Taikhoan == username
            && nv.MatKhau == password);
        }
    }
}
