using Data.Modele;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DQLNhanVienDAL
    {
        CsdlDuAn1Context dbcontext = new CsdlDuAn1Context();
        public List <NhanVien> GetallNhanVien()
        {
            return dbcontext.NhanViens.ToList();
        }
        public NhanVien GetNhanVienByID(string id)
        {
            return dbcontext.NhanViens.Find(id);
        }
        public NhanVien GetbyId(string id)
        {
            return dbcontext.NhanViens.Find(id);
        }
        public bool Create(NhanVien nhanVien)
        {
            try
            {
                dbcontext.NhanViens.Add(nhanVien);
                dbcontext.SaveChanges();
                return true;
            }
            catch {  return false; }
        }


        //public bool Update(SanPham sanPham)
        //{

        //    try
        //    {
        //        var UpdateItem = dbContext.SanPhams.Find(sanPham.IdsanPham);

        //        UpdateItem.IdkhuyenMai = sanPham.IdkhuyenMai;
        //        UpdateItem.IdloaiSanPham = sanPham.IdloaiSanPham;
        //        UpdateItem.TenSanPham = sanPham.TenSanPham;
        //        UpdateItem.SoLuong = sanPham.SoLuong;
        //        UpdateItem.GiaNhap = sanPham.GiaNhap;
        //        UpdateItem.KhoiLuong = sanPham.KhoiLuong;
        //        UpdateItem.NguonGoc = sanPham.NguonGoc;
        //        UpdateItem.HanSuDung = sanPham.HanSuDung;
        //        UpdateItem.ChiSoSpf = sanPham.ChiSoSpf;
        //        UpdateItem.ChiSoFa = sanPham.ChiSoFa;
        //        UpdateItem.GiaBan = sanPham.GiaBan;

        //        dbContext.SanPhams.Update(UpdateItem);
        //        dbContext.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }

        //}


        public bool Update(NhanVien nhanVien)
        {
            try
            {
                    var find = dbcontext.NhanViens.Find(nhanVien.IdnhanVien);
                
                    find.IdchucVu = nhanVien.IdchucVu;
                    find.TenNhanVien = nhanVien.TenNhanVien;
                    find.Email = nhanVien.Email;
                    find.Sdt = nhanVien.Sdt;
                    find.GioiTinh = nhanVien.GioiTinh;
                    find.Taikhoan = nhanVien.Taikhoan;
                    //find.MatKhau = nhanVien.MatKhau;
                    find.TrangThaiLamViec = nhanVien.TrangThaiLamViec;
                
                dbcontext.NhanViens.Update(find);
                dbcontext.SaveChanges();
                return true;
            }
            catch(Exception) { return false; }
        }
        //public bool Delete(string id)
        //{
        //    try
        //    {
        //        var find = dbcontext.NhanViens.Find(id);
        //        if (find != null)
        //        {
        //            dbcontext.NhanViens.Remove(find);
        //            dbcontext.SaveChanges();
        //        }
        //        return true;
        //    }
        //    catch { return false; }
        //}


        //public bool Delete(string IdSanPham)
        //{
        //    try
        //    {
        //        var deleteItem = dbContext.SanPhams.Find(IdSanPham);
        //        dbContext.SanPhams.Remove(deleteItem);
        //        dbContext.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception) { return false; }

        //}

        //public bool UpdateTTLV(NhanVien nhanVien)
        //{
        //    try
        //    {
        //        var find = dbcontext.NhanViens.Find(nhanVien.IdnhanVien);
        //        if (find != null)
        //        {
        //            find.TrangThaiLamViec = false;
        //        }
        //        dbcontext.NhanViens.Update(find);
        //        dbcontext.SaveChanges();
        //        return true;
        //    }
        //    catch { return false; }
        //}

        public bool UpdateTTLV(NhanVien nhanVien)
        {
            try
            {
                var find = dbcontext.NhanViens.Find(nhanVien.IdnhanVien);
                if (find != null)
                {

                    find.TrangThaiLamViec = false;

                    dbcontext.NhanViens.Update(find);
                    dbcontext.SaveChanges();

                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }



    }
}
