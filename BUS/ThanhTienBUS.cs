using DAL;
using Data.Modele;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThanhTienBUS
    {
        ThanhTienDAL ThanhTienDAL = new ThanhTienDAL();
        public ThanhTien? GetThanhtienbyMaHoaDon(string maHoaDon)
        {
            return ThanhTienDAL.GetThanhTienbyMaHoaDon(maHoaDon);
        }
        public List<ThanhTien> GetAllThanhtien()
        {
            return ThanhTienDAL.GetAllThanhtien();
        }
        public void TaoThanhTien(ThanhTien thanhTien)
        {
            ThanhTienDAL.TaoThanhTien(thanhTien);
        }

    }
}
