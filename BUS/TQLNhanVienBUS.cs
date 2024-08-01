using DAL;

using Data.DataBase;


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TQLNhanVienBUS
    {

        private CsdlDuAn1NewNew2Context dbcontext = new CsdlDuAn1NewNew2Context();
        DQLNhanVienDAL QLNVDAL = new DQLNhanVienDAL();

        public List <NhanVien> Getallnhanvien()
        {
            var nhanvien = QLNVDAL.GetallNhanVien();
            return nhanvien;
        }


        public NhanVien GetnhanvienByID(string IdNhanvien)
        {
            var nhanvien = QLNVDAL.GetNhanVienByID(IdNhanvien);
            return nhanvien;

        }
        public bool  Create(NhanVien nhanVien)
        {
            return QLNVDAL.Create(nhanVien);
        }


 

        public string Update(string idnhanvien, string idchucvu, string tennhanvien, string email, string sdt, 
            bool gioitinh, string taikhoan, /*string matkhau,*/ bool trangthailamviec)
        {
            NhanVien nv = new NhanVien()
            {
                IdnhanVien = idnhanvien,
                IdchucVu = idchucvu,
                TenNhanVien = tennhanvien,
                Email = email,
                Sdt = sdt,
                GioiTinh = gioitinh,
                Taikhoan = taikhoan,
                //MatKhau = matkhau,
                TrangThaiLamViec = trangthailamviec
            };

            if(QLNVDAL.Update(nv))
            {
                return "Sửa thành công!";
            }
            else
            {
                return "Sửa thất bại!";
            }

        }







        public string Update2(NhanVien nv)
        {
            

            if (QLNVDAL.Update2(nv))
            {
                return "Sửa thành công!";
            }
            else
            {
                return "Sửa thất bại!";
            }

        }






        public bool UpdateTTLV(NhanVien nhanvien)
        {
            return QLNVDAL.UpdateTTLV(nhanvien);
        }

        public NhanVien GetById(string id)
        {
            return QLNVDAL.GetbyId(id);
        }

       


        public List<NhanVien> GetAllNV(string timkiem)
        {
            if (timkiem == null || timkiem == string.Empty)
            {
                return QLNVDAL.GetTimKiem();

            }
            return QLNVDAL.GetTimKiem().Where(x => x.IdnhanVien.StartsWith(timkiem) || x.TenNhanVien.Contains(timkiem)).ToList();

        }



        public List<NhanVien> CNLocTheoTrangThai(bool trangThai)
        {
            return QLNVDAL.LocTheoTrangThai(trangThai);
        }


    }

}
