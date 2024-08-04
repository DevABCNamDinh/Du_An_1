using DAL;
using Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public  class LLoaiSanPhamBLL
    {
        public LLoaiSanPhamDAL _loaispDAL = new LLoaiSanPhamDAL();

        public List<LoaiSanPham> Getallloaisp()
        {
            return _loaispDAL.GetallLoaiSanPham();
        }

        public LoaiSanPham Getbyid(string id)
        {
            return _loaispDAL.GetbyId(id);
        }
        public bool CreateLoaiSP(LoaiSanPham loaisp)
        {

            return _loaispDAL.CreateLSP(loaisp);


        }

        public void createLSP(LoaiSanPham loaiSanPham)
        {
            _loaispDAL.createLSP(loaiSanPham);
        }

        public string Update( string IdLoaiSanPham, string IdKhuyenMai, string LoaiSanPham)
        {


            LoaiSanPham lspList = new LoaiSanPham()
            {
                IdloaiSanPham = IdLoaiSanPham,
                IdkhuyenMai = IdKhuyenMai,
                LoaiSanPham1 = LoaiSanPham,
            };

            if (_loaispDAL.Update(lspList))
            {
                return "Sửa  thành công";
            }
            else
                return "Sửa thất bại";

        }

      
        public string SuaLSP(LoaiSanPham sanPham)
        {
            if (_loaispDAL.SuaLoaiSanPham(sanPham))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }

    }
}
