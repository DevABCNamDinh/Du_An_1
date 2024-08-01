
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   
    public class DanhSachSanPhamDAL
    {
        CsdlDuAn1NewNewContext dbContext = new CsdlDuAn1NewNewContext();


        
        public List<SanPham> GetAllSanPhams()
        {
            return dbContext.SanPhams.ToList();
        }

        public SanPham? GetSanPhamById(string idSanPham)
        {
            return dbContext.SanPhams.FirstOrDefault(sp => sp.IdsanPham == idSanPham);
        }


       

        public void UpdateSoLuong(SanPham sp)
        {
            var spctOld = GetSanPhamById(sp.IdsanPham);
            if (spctOld != null)
            {
                spctOld.SoLuong = sp.SoLuong;
            }
            dbContext.SaveChanges();
        }

      

        public LoaiSanPham? GetLoaiSanPhamById(string IDLoaiSP)
        {
            return dbContext.LoaiSanPhams.FirstOrDefault(ms => ms.IdloaiSanPham == IDLoaiSP);
        }

      
        public KhuyenMai? GetKhuyenMaiById(string IDKhuyenMai)
        {
            return dbContext.KhuyenMais.FirstOrDefault(ms => ms.IdkhuyenMai == IDKhuyenMai);
        }



      
    }
}
