
﻿using Data.DataBase;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangNhapDAL
    {
        CsdlDuAn1NewNew2Context dbContext = new CsdlDuAn1NewNew2Context();



        public NhanVien? DangNhap(string username, string password)
        {
            return dbContext.NhanViens.FirstOrDefault(nv => nv.Taikhoan == username
            && nv.MatKhau == password);
        }
    }
}
