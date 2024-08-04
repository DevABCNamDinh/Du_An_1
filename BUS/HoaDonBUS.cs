using DAL;



using Data.Models;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAL hoaDonDAL = new HoaDonDAL();

        public HoaDon? GetHoaDonbyMaHoaDon(string maHoaDon)
        {
            return hoaDonDAL.GetHoaDonbyMaHoaDon(maHoaDon);
        }

        public List<HoaDon> GetAllHoaDonByAll(string timkiem,int trangThai, string idNhanvien,string khachHang,DateTime? startDate, DateTime?endDate)
        {
            return hoaDonDAL.GetHoaDonByALl(timkiem,trangThai,idNhanvien,khachHang,startDate,endDate);



        }
        public List<HoaDon> GetAllHoaDonsByTrangThai()
        {
            return hoaDonDAL.GetAllHoaDonsByTrangThai();
        }
        public List<HoaDon> GetAllHoaDons()
        {
            return hoaDonDAL.GetAllHoaDons();
        }
        public List<HoaDon> GetAllHoaDonsbyNhanvien(string idnhanvien)
        {
            return hoaDonDAL.GetAllHoaDonsByNhanVien(idnhanvien);
        }

        public List<HoaDon> GetAllHoaDonChos(string idNhanVien)
        {
            return hoaDonDAL.GetAllHoaDons().Where(hd => hd.TrangThaiThanhToan == 0&&hd.IdnhanVien==idNhanVien).ToList();
        }

        public void TaoHoaDonCho(HoaDon hoaDon)
        {
            hoaDonDAL.TaoHoaDonCho(hoaDon);
        }

        public void SuaTrangThai(string maHoaDon, int trangThai)
        {
            hoaDonDAL.SuaTrangThai(maHoaDon, trangThai);
        }
    }
}
