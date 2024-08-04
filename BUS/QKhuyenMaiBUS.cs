using DAL;


using Data.Data;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QKhuyenMaiBUS
    {
        QKhuyenMaiDAL KmDAL = new QKhuyenMaiDAL();

        public List<KhuyenMai> CNHien()
        {
            return KmDAL.GetAll();
        }

        public List<KhachHang> ShowKH()
        {
            return KmDAL.GetAllKH();
        }

        public string CNThem(string IdKm, string TenKM, DateTime NgayBD, DateTime NgayKT, double GiamGia, string MoTa , bool TrangThai)
        {
            KhuyenMai km = new KhuyenMai()
            {
                IdkhuyenMai = IdKm,
                TenKhuyenMai = TenKM,
                NgayBatDau = NgayBD,
                NgayKetThuc = NgayKT,
                PhanTramGiamGia = GiamGia,
                MoTa = MoTa , 
                TrangThai = TrangThai 

            };

            

            


            if (KmDAL.AddKM(km))
            {
                return "Thêm Thành Công";
            }
            else
            {
                return "Thêm Thất Bại";
            }
        }


       
        public string CNSua(string IdKm, string TenKM, DateTime NgayBD, DateTime NgayKT, double GiamGia, string MoTa, bool TrangThai)
        {
            KhuyenMai km = new KhuyenMai()
            {

                IdkhuyenMai = IdKm,
                TenKhuyenMai = TenKM,
                NgayBatDau = NgayBD,
                NgayKetThuc = NgayKT,
                PhanTramGiamGia = GiamGia,
                MoTa = MoTa,
                TrangThai = TrangThai

            };

           
           

            if (KmDAL.UpdateKm(km))
            {
                return "Sửa Thành Công";
            }
            else
            {
                return "Sửa Thất Bại";
            }
        }


      
        public string CNXoa(string IdKM)
        {
            if (KmDAL.ChangeStatus(IdKM))
            {
                return "Cập nhật trạng thái thành công (đã tắt)";
            }
            else
            {
                return "Cập nhật trạng thái thất bại";
            }
        }



        public List<KhuyenMai> CNTimByPartialTen(string searchTerm)
        {
            return KmDAL.GetKhuyenMaisByPartialTen(searchTerm);
        }

        public List<KhuyenMai> LocDate(DateTime startDate, DateTime endDate)
        {
            return KmDAL.LocTheoNgay(startDate, endDate);
        }

        public List<KhuyenMai> GetKhuyenMaisById(string id)
        {
            return KmDAL.GetKhuyenMaisById(id);
        }

        public List<KhuyenMai> LocGiamGia(double discount)
        {
            return KmDAL.GetKhuyenMaisByDiscount(discount);
        }
        public List<KhuyenMai> LocTrangThai(bool status)
        {
            return KmDAL.GetTrangThai(status);
        }
        public List<KhuyenMai> ExportKhuyenMaiData()
        {
            return KmDAL.GetAll();
        }

       
        
    }
}
