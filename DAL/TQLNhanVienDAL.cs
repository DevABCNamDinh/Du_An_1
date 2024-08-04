using Data.Model;


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TQLNhanVienDAL
    {
        CsdlDuAn1Context dbcontext = new CsdlDuAn1Context();
        public List <NhanVien> GetallNhanVien()
        {
            return dbcontext.NhanViens.ToList();
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


        public NhanVien? getNhanVienById(string idNhanVien)
        {
            return dbcontext.NhanViens.Find(idNhanVien);
        }



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




        public bool Update2(NhanVien nhanVien)
        {
            try
            {

                dbcontext.NhanViens.Update(nhanVien);
                dbcontext.SaveChanges();
                return true;
            }
            catch (Exception) { return false; }
        }






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



        public List<NhanVien> GetTimKiem()
        {
            return dbcontext.NhanViens.ToList();
        }



        public List<NhanVien> LocTheoTrangThai(bool trangThai)
        {
            return dbcontext.NhanViens.Where(nv => nv.TrangThaiLamViec == trangThai).ToList();
        }


    }
}
