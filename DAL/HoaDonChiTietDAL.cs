

using Data.DataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonChiTietDAL
    {
        CsdlDuAn1NewNew2Context dbContext = new CsdlDuAn1NewNew2Context();
        public List<HoaDonChiTiet> GetAllHoaDonCT()
        {
            return dbContext.HoaDonChiTiets.ToList();
        }
        public List<HoaDonChiTiet> GetAllHoaDonCTByMaHoaDon(string maHoaDon)
        {
            return dbContext.HoaDonChiTiets.Where(hdct => hdct.IdhoaDon == maHoaDon).ToList();
        }

        public HoaDonChiTiet? GetHDCTById(string maHoaDon, string maSPCT)
        {
            return dbContext.HoaDonChiTiets
                .FirstOrDefault(hdct => hdct.IdhoaDon == maHoaDon && hdct.IdsanPham == maSPCT);
        }

        public HoaDonChiTiet? GetHDCTByIdHDCT( string maSPCT)
        {
            return dbContext.HoaDonChiTiets
                .Find(maSPCT);
        }
        public void ThemMoiHDCT(HoaDonChiTiet hdct)
        {
            dbContext.HoaDonChiTiets.Add(hdct);
            dbContext.SaveChanges();
        }

        public void UpdateSoLuong(HoaDonChiTiet hdctNew)
        {
            var hdctOld = GetHDCTById(hdctNew.IdhoaDon, hdctNew.IdsanPham);
            if (hdctOld != null)
            {
                hdctOld.SoLuong = hdctNew.SoLuong;
            }
            dbContext.SaveChanges();
        }
        public void XoaHDCT(HoaDonChiTiet hoaDonChiTiet)
        {
            dbContext.HoaDonChiTiets.Remove(hoaDonChiTiet);
            dbContext.SaveChanges();
        }
    }
}
