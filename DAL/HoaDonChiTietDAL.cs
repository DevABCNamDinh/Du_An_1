
using Data.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonChiTietDAL
    {
        CsdlDuAn1NewNewContext dbContext = new CsdlDuAn1NewNewContext();
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
    }
}
