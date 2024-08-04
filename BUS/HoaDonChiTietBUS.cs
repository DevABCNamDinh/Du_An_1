using DAL;


using Data.Models;



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonChiTietBUS
    {
        HoaDonChiTietDAL hoaDonChiTietDAL = new HoaDonChiTietDAL();

        public List<HoaDonChiTiet> GetAllHoaDonCT()
        {
            return hoaDonChiTietDAL.GetAllHoaDonCT();
        }
        public List<HoaDonChiTiet> GetAllHoaDonCTByMaHoaDon(string maHoaDon)
        {
            return hoaDonChiTietDAL.GetAllHoaDonCTByMaHoaDon(maHoaDon);
        }

        public HoaDonChiTiet? GetHDCTById(string maHoaDon, string maSPCT)
        {
            return hoaDonChiTietDAL.GetHDCTById(maHoaDon, maSPCT);
        }
        public HoaDonChiTiet? GetHDCTByIdHDCT( string maSPCT)
        {
            return hoaDonChiTietDAL.GetHDCTByIdHDCT( maSPCT);
        }

        public void ThemMoiHDCT(HoaDonChiTiet hdct)
        {
            hoaDonChiTietDAL.ThemMoiHDCT(hdct);
        }

        public void UpdateSoLuong(HoaDonChiTiet hdctNew)
        {
            hoaDonChiTietDAL.UpdateSoLuong(hdctNew);
        }
        public void XoaHDCT(HoaDonChiTiet hoaDonChiTiet)
        {
            hoaDonChiTietDAL.XoaHDCT(hoaDonChiTiet);
        }
    }
    
}
