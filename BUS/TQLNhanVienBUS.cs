using DAL;




using Data.Modee;



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

        private CsdlDuAn1Context dbcontext = new CsdlDuAn1Context();
        DQLNhanVienDAL QLNVDAL = new DQLNhanVienDAL();
        //TQLNhanVienDAL TQLNhanVienDAL = new TQLNhanVienDAL();

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

       


        public List<NhanVien> GetAllNV(string timkiem,int trangThai,string chucVu)
        {
            var nv = QLNVDAL.GetTimKiem().AsQueryable();
            if (!string.IsNullOrEmpty(timkiem))
            {
                nv=nv.Where(x => x.IdnhanVien.StartsWith(timkiem) || x.TenNhanVien.Contains(timkiem));
            }

            if (trangThai==1)
            {
                nv=nv.Where(x=>x.TrangThaiLamViec==true);
            }
            else if(trangThai ==2)
            {
                nv = nv.Where(x => x.TrangThaiLamViec == false);
            }

            if (chucVu=="Admin")
            {
                nv = nv.Where(x => x.IdchucVu == "CV001");
            }
            else if (chucVu=="Nhân viên")
            {
                nv = nv.Where(x => x.IdchucVu == "CV002");

            }

            return nv.ToList();

        }



        public List<NhanVien> CNLocTheoTrangThai(bool trangThai)
        {
            return QLNVDAL.LocTheoTrangThai(trangThai);
        }


        public List<NhanVien> CNLocTheoChucVu(string chucVu)
        {
            return QLNVDAL.LocTheoChucVu(chucVu);

        }

    }

}
