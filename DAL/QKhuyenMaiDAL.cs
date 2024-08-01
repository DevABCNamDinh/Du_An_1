using DTO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QKhuyenMaiDAL
    {
        CsdlDuAn1NewNewContext dbcontex = new CsdlDuAn1NewNewContext();

  
        public List<KhuyenMai> GetAll()
        {
            return dbcontex.KhuyenMais.ToList();
        }
  
        public bool AddKM(KhuyenMai km)
        {
            try
            {
                dbcontex.KhuyenMais.Add(km);
                dbcontex.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool UpdateKm(KhuyenMai km)
        {
            try
            {
                var UpdateItem = dbcontex.KhuyenMais.Find(km.IdkhuyenMai);

                if (UpdateItem != null)
                {

                    UpdateItem.TenKhuyenMai = km.TenKhuyenMai;
                    UpdateItem.NgayBatDau = km.NgayBatDau;
                    UpdateItem.NgayKetThuc = km.NgayKetThuc;
                    UpdateItem.PhanTramGiamGia = km.PhanTramGiamGia;
                    UpdateItem.MoTa = km.MoTa;
                    UpdateItem.TrangThai = km.TrangThai;
                    dbcontex.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool ChangeStatus(string idKM)
        {
            try
            {
                var item = dbcontex.KhuyenMais.Find(idKM);
                if (item != null)
                {

                    item.TrangThai = false;
                    dbcontex.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

     
        public KhuyenMai GetByID(string id)
        {
            return dbcontex.KhuyenMais.FirstOrDefault(km => km.IdkhuyenMai == id);
        }



        public List<KhuyenMai> GetKhuyenMaisByDate(DateTime date)
        {
            return dbcontex.KhuyenMais.Where(km => km.NgayBatDau <= date && km.NgayKetThuc >= date).ToList();
        }

        public List<KhuyenMai> GetKhuyenMaisById(string id)
        {
            return dbcontex.KhuyenMais.Where(km => km.IdkhuyenMai.Equals(id)).ToList();
        }

        public List<KhuyenMai> GetKhuyenMaisByDiscount(double discount)
        {
            return dbcontex.KhuyenMais.Where(km => km.PhanTramGiamGia.Equals(discount)).ToList();
        }
        public List<KhuyenMai> GetTrangThai(bool status)
        {

            return dbcontex.KhuyenMais.Where(km => km.TrangThai == status).ToList();

        }
        public List<KhuyenMai> GetAllKm()
        {
            return dbcontex.KhuyenMais.ToList();
        }
        public List<KhuyenMai> LocHan(bool conHan)
        {
            DateTime now = DateTime.Now;

           
            if (conHan)
            {
                return dbcontex.KhuyenMais
                    .Where(km => km.NgayKetThuc.HasValue && km.NgayKetThuc.Value > now)
                    .ToList();
            }
            else
            {
                return dbcontex.KhuyenMais
                    .Where(km => km.NgayKetThuc.HasValue && km.NgayKetThuc.Value <= now)
                    .ToList();
            }
        }

    }
}