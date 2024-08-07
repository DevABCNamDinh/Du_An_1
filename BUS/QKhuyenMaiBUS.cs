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

        public string CNThem(string IdKm, string TenKM, DateTime NgayBD, DateTime NgayKT, double GiamGia, string MoTa , bool TrangThai,bool tamNgung)
        {
            KhuyenMai km = new KhuyenMai()
            {
                IdkhuyenMai = IdKm,
                TenKhuyenMai = TenKM,
                NgayBatDau = NgayBD,
                NgayKetThuc = NgayKT,
                PhanTramGiamGia = GiamGia,
                MoTa = MoTa , 
                TrangThai = TrangThai,
                TamNgung = tamNgung
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

        public void UpdateKhuyenMaiTheoThoiGian(KhuyenMai km)
        {
            KmDAL.UpdateKMTheoThoiGian(km);
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
        public KhuyenMai GetKMByID_M(string id)
        {
            return KmDAL.GetByID(id);
        }
       

        public List<KhuyenMai> getAllKM(string timkiem, int trangThai, DateTime? TGStart,DateTime? TGEnd)
        {
            var km = KmDAL.GetAllKm().AsQueryable();
            if (!string.IsNullOrEmpty(timkiem))
            {
                km = km.Where(x => x.TenKhuyenMai.Contains(timkiem));
            }

            if (trangThai == 2)
            {
                km = km.Where(x => x.TrangThai == true && x.TamNgung == false);
            }else if (trangThai == 3)
            {
                km = km.Where(x => x.TrangThai == true && x.TamNgung == true);

            }
            else if (trangThai==4)
            {
                km = km.Where(x => x.TrangThai == false && x.NgayKetThuc < DateTime.Now);
            }else if (trangThai == 5)
            {
                km = km.Where(x => x.TrangThai == false && x.NgayBatDau > DateTime.Now);
            }

            //km = km.Where(x => x.NgayBatDau <= TGStart.Value && x.NgayKetThuc >= TGStart.Value); ;

            //km = km.Where(x => x.NgayBatDau <= TGEnd.Value && x.NgayKetThuc.Value >= TGEnd);

            //km = km.Where(x => x.NgayBatDau>=TGStart&&x.NgayKetThuc<=TGEnd )
            //    .Where(x => x.NgayBatDau <= TGStart.Value && x.NgayKetThuc >= TGStart.Value)
            //    .Where(x => x.NgayBatDau <= TGEnd.Value && x.NgayKetThuc.Value >= TGEnd);


            km = km.Where(x => (x.NgayBatDau >= TGStart && x.NgayKetThuc <= TGEnd)?true
                :(x.NgayBatDau <= TGStart.Value && x.NgayKetThuc >= TGStart.Value)
                ?true:(x.NgayBatDau <= TGEnd.Value && x.NgayKetThuc.Value >= TGEnd)
                );
               
            return km.ToList();
            

        }
        
    }
}
