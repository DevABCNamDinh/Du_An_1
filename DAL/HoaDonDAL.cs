

using Data.DataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        CsdlDuAn1NewNew2Context dbContext = new CsdlDuAn1NewNew2Context();

        public HoaDon? GetHoaDonbyMaHoaDon(string maHoaDon)
        {
            return dbContext.HoaDons.Find(maHoaDon);
        }

        public List<HoaDon> GetHoaDonByALl(string timkiem, int trangThai, string idNhanvien,string khachhang,DateTime? startDate, DateTime? endDate)
        {
            var hoaDons = dbContext.HoaDons.AsQueryable();
            if (!string.IsNullOrEmpty(timkiem))
            {
                hoaDons = hoaDons.Where(x => x.IdhoaDon.Contains(timkiem));
            }

            if (trangThai != 3)
            {
                hoaDons = hoaDons.Where(x => x.TrangThaiThanhToan == trangThai);
            }
            //if (idNhanvien != null||idNhanvien!=string.Empty || idNhanvien.Equals("NV00")==false)
            //{
            //    hoaDons = hoaDons.Where(x => x.IdnhanVien == idNhanvien);
            //}
            if (idNhanvien == "All")
            {

            }else
            {
                hoaDons = hoaDons.Where(x => x.IdnhanVien == idNhanvien);
            }
           var khachHangX = dbContext.KhachHangs.FirstOrDefault(k => k.Sdt == khachhang);
            if (khachHangX != null && khachhang != string.Empty)
            {
                hoaDons = hoaDons.Where(x => x.IdkhachHang==khachHangX.IdkhachHang);
            }

           
                hoaDons = hoaDons.Where(hd => hd.NgayDatHang >= startDate.Value && hd.NgayDatHang <= endDate.Value);
            
            return hoaDons.ToList();
        }

        public List<HoaDon> GetAllHoaDonsByTrangThai()
        {
            return dbContext.HoaDons.Where(x=>x.TrangThaiThanhToan==1||x.TrangThaiThanhToan==2).ToList();
        }
        public List<HoaDon> GetAllHoaDons()
        {
            return dbContext.HoaDons.ToList();
        }


        public List<HoaDon> GetAllHoaDonsByNhanVien(string idNhanvien)
        {
            return dbContext.HoaDons.Where(id=>id.IdnhanVien==idNhanvien).ToList();
        }
        public void TaoHoaDonCho(HoaDon hoaDon)
        {
            dbContext.HoaDons.Add(hoaDon);
            dbContext.SaveChanges();
        }

        public void SuaTrangThai(string maHoaDon, int trangThai)
        {
            var hoaDonSua = dbContext.HoaDons.Find(maHoaDon);
            if (hoaDonSua != null)
            {
                hoaDonSua.TrangThaiThanhToan = trangThai;
            }
            dbContext.SaveChanges();
        }
    }
}
