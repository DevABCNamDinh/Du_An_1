using DAL;



using Data.Data;



using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LSanPhamDAL;

namespace BUS
{
    public class LSanPhamBLL
    {
        LSanPhamDAL sanPhamDAL = new LSanPhamDAL();
       

     
        //public LoaiSanPham? GetLoaiSanPhamById(string IdLoaiSanPham)
        //{
        //    return sanPhamDAL.GetLoaiSanPhamById(IdLoaiSanPham);
        //}

        public List<SanPham> GetAllSanPham(string timKiem,int trangThai)
        {
            var sanpham = sanPhamDAL.GetAllSanPham().AsQueryable();

            if (!string.IsNullOrEmpty(timKiem))
            {
               sanpham = sanpham.Where(sp => sp.TenSanPham.Contains(timKiem));
            }

            if (trangThai == 1)
            {
                sanpham = sanpham.Where(sp => sp.TrangThai==false);

            }
            else  if (trangThai == 2)
                {
                    sanpham = sanpham.Where(sp => sp.TrangThai == true&&sp.SoLuong!=0);

            }
            else if (trangThai == 3)
            {
                sanpham = sanpham.Where(sp => sp.TrangThai == true && sp.SoLuong == 0) ;

            }
            return sanpham.ToList();

        }
            
        
      





      
        public List<SanPham> GetAllSP()
        {
            var sanPham = sanPhamDAL.GetSP();
            return sanPham;
        } // cái này của add sản phẩm

        
      public List<KhuyenMai> GetAllKhuyenMai()
        {
            var khuyenMai = sanPhamDAL.GetAllKhuyenMai();
            return khuyenMai;
        }
       



       
        public bool CreateSanPham (SanPham sanPham)
        {

           return sanPhamDAL.Create(sanPham);
         

        }
        public void CreateSp(SanPham sanPham)
        {
            sanPhamDAL.Create2(sanPham);
        }



        public string UpdateSanPham(  string IdSP, string IdLoaiSanPham,
            string TenSanPham, int SoLuong, decimal GiaNhap, double KhoiLuong, string NguonGoc,
            DateOnly HanSuDung, string Spf, string Fa, decimal GiaBan, bool TrangThai)

        {
            SanPham sanphamList = new SanPham()
            {

                IdsanPham = IdSP,
                IdloaiSanPham = IdLoaiSanPham,
                TenSanPham = TenSanPham,
                SoLuong = SoLuong,
                GiaNhap = GiaNhap,
                KhoiLuong = KhoiLuong,
                NguonGoc = NguonGoc,
                HanSuDung = HanSuDung,
                ChiSoSpf = Spf,
                ChiSoFa = Fa,
                GiaBan = GiaBan,
                TrangThai = TrangThai

            };
          
            if (sanPhamDAL.Update(sanphamList))
            {
                return "Sửa  thành công";
            }
            else
            {
                return "Sửa thất bại";

            }
                
        }
  


        public SanPham GetById(string Id)
        {
            return sanPhamDAL.GetById(Id);
        }

       
        public List<SanPham> LocTrangThai(bool trangThai)
        {
            return sanPhamDAL.LocTheoTrangThai(trangThai);
        }


        public string SuaSP(SanPham sanPham)
        {
            if (sanPhamDAL.SuaSanPham(sanPham))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }

    }
}

