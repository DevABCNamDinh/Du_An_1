using Data.Model;


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LSanPhamDAL;

namespace DAL
{
    public  class LSanPhamDAL
    {
        
                CsdlDuAn1Context dbContext = new CsdlDuAn1Context();
        public List<SanPham> GetAllSanPham()
        {
         return dbContext.SanPhams.ToList();
    
        }


        public SanPham GetById(string Id)
        {
            return dbContext.SanPhams.Find(Id);
        }
      
        public bool Create(SanPham sanPham)
        {

            try
            {
                dbContext.SanPhams.Add(sanPham);
                dbContext.SaveChanges();
                return true;
            } catch 
            {
                return false;
            }
            

        }
        public void Create2(SanPham sanPham)
        {
            dbContext.SanPhams.Add(sanPham);
            dbContext.SaveChanges();
        }




        public bool Update(SanPham sanPham)
        {

            try
            {
                var UpdateItem = dbContext.SanPhams.Find(sanPham.IdsanPham);

             
                UpdateItem.IdloaiSanPham = sanPham.IdloaiSanPham;
                UpdateItem.TenSanPham = sanPham.TenSanPham;
                UpdateItem.SoLuong = sanPham.SoLuong;
                UpdateItem.GiaNhap = sanPham.GiaNhap;
                UpdateItem.KhoiLuong = sanPham.KhoiLuong;
                UpdateItem.NguonGoc = sanPham.NguonGoc;
                UpdateItem.HanSuDung = sanPham.HanSuDung;
                UpdateItem.ChiSoSpf = sanPham.ChiSoSpf;
                UpdateItem.ChiSoFa = sanPham.ChiSoFa;
                UpdateItem.GiaBan = sanPham.GiaBan;
                UpdateItem.TrangThai = sanPham.TrangThai;

                dbContext.SanPhams.Update(UpdateItem);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
          
        }



      



        public List<SanPham> GetTimKiem()
        {
            return dbContext.SanPhams.ToList();
        }
       public List<SanPham> GetSP()
        {
            return dbContext.SanPhams.ToList();
        }

        public LoaiSanPham? GetLoaiSanPhamById(string IdLoaiSanPham) {
         return dbContext.LoaiSanPhams.FirstOrDefault(x=>x.IdloaiSanPham == IdLoaiSanPham);
        }


   
       public List<KhuyenMai> GetAllKhuyenMai()
        {
            return dbContext.KhuyenMais.ToList();
        }

        public List<SanPham> LocTheoTrangThai(bool trangThai)
        {
            return dbContext.SanPhams.Where(sp => sp.TrangThai == trangThai).ToList();
        }
        public bool SuaSanPham(SanPham nv)
        {
            if (nv == null)
            {
                return false;
            }
            dbContext.SanPhams.Update(nv);
            dbContext.SaveChanges();
            return true;
        }
    }
}
