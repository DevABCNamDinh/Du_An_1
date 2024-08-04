using DAL;

using Data.Models;



using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongTinKhachHangBUS
    {
        ThongTinKhachHangDAL ThongTinKhachHangDAL = new ThongTinKhachHangDAL();
        public KhachHang? GetTenKHBySdt(string sdt)
        {
            return ThongTinKhachHangDAL.GetkhachHangBySDT(sdt);
        }


        public KhachHang? GetTenKHByID(string id)
        {
            return ThongTinKhachHangDAL.GetkhachHangByID(id);
        }
    }
}
