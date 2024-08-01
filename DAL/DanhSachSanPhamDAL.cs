using Data.DataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   
    public class DanhSachSanPhamDAL
    {
        CsdlDuAn1NewNew2Context dbContext = new CsdlDuAn1NewNew2Context();


        // Bảng sản phẩm
        public List<SanPham> GetAllSanPhams()
        {
            return dbContext.SanPhams.ToList();
        }

        public SanPham? GetSanPhamById(string idSanPham)
        {
            return dbContext.SanPhams.FirstOrDefault(sp => sp.IdsanPham == idSanPham);
        }


        //Bảng sản phẩm chi tiết
        //public List<SanPhamChiTiet> GetAllSanPhamChiTiets()
        //{
        //    return dbContext.SanPhamChiTiets.ToList();
        //}

        //public SanPhamChiTiet GetAllSanPhamChiTietById(string maSPCT)
        //{
        //    return dbContext.SanPhamChiTiets.Find(maSPCT);
        //}

        public void UpdateSoLuong(SanPham sp)
        {
            var spctOld = GetSanPhamById(sp.IdsanPham);
            if (spctOld != null)
            {
                spctOld.SoLuong = sp.SoLuong;
            }
            dbContext.SaveChanges();
        }

        //Loại sản phẩm

        public LoaiSanPham? GetLoaiSanPhamById(string IDLoaiSP)
        {
            return dbContext.LoaiSanPhams.FirstOrDefault(ms => ms.IdloaiSanPham == IDLoaiSP);
        }

        //khuyến mại
        public KhuyenMai? GetKhuyenMaiById(string IDKhuyenMai)
        {
            return dbContext.KhuyenMais.FirstOrDefault(ms => ms.IdkhuyenMai == IDKhuyenMai);
        }



        //chức vụ
      
    }
}
