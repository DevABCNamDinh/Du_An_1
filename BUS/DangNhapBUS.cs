using DAL;

using Data.Data;




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhapBUS
    {
        DangNhapDAL dangNhapDAL = new DangNhapDAL();

        public NhanVien? DangNhap(string username, string password)
        {
            return dangNhapDAL.DangNhap(username, password);
        }
    }
}
