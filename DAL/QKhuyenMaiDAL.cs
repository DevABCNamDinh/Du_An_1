

﻿using Data.Data;

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
        CsdlDuAn1Context dbcontex = new CsdlDuAn1Context();

  
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

        public void UpdateKMTheoThoiGian(KhuyenMai km)
        {
            dbcontex.KhuyenMais.Update(km);
            dbcontex.SaveChanges();
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

        public List<KhuyenMai> GetKhuyenMaisByPartialTen(string searchTerm)
        {
            
            return dbcontex.KhuyenMais
                .Where(km => km.TenKhuyenMai.Contains(searchTerm))
                .ToList();
        }

        public KhuyenMai GetByID(string id)
        {
            return dbcontex.KhuyenMais.Find(id);
        }

        public List<KhachHang> GetAllKH()
        {
            return dbcontex.KhachHangs.ToList();
        }

        public List<KhuyenMai> LocTheoNgay(DateTime startDate, DateTime endDate)
        {
            return dbcontex.KhuyenMais
                .Where(km => km.NgayBatDau >= startDate && km.NgayBatDau <= endDate)
                .ToList();
        }

        public List<KhuyenMai> GetKhuyenMaisById(string id)
        {
            return dbcontex.KhuyenMais
                           .Where(km => km.IdkhuyenMai.Contains(id))
                           .ToList();
        }

        public List<KhuyenMai> GetKhuyenMaisByDiscount(double discount)
        {
            return dbcontex.KhuyenMais.Where(km => km.PhanTramGiamGia.Equals(discount)).ToList();
        }
        public List<KhuyenMai> GetTrangThai(bool status)
        {

            return dbcontex.KhuyenMais
                      .Where(km => km.TrangThai == status)
                      .ToList();

        }
        public List<KhuyenMai> GetAllKm()
        {
            return dbcontex.KhuyenMais.ToList();
        }
      
      
    }
}