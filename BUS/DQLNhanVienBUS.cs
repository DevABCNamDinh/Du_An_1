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
    public class DQLNhanVienBUS
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


        //    public string UpdateSanPham(string IdSanPham, string IdKhuyenMai, string Idlsp,
    //      string TenSanPham, int SoLuong, decimal GiaNhap, double KhoiLuong, string NguonGoc,
    //      DateOnly HanSuDung, string Spf, string Fa, decimal GiaBan)

    //    {
    //        SanPham sanphamList = new SanPham()
    //        {

    //            IdsanPham = IdSanPham,
    //            IdkhuyenMai = IdKhuyenMai,
    //            IdloaiSanPham = Idlsp,
    //            TenSanPham = TenSanPham,
    //            SoLuong = SoLuong,
    //            GiaNhap = GiaNhap,
    //            KhoiLuong = KhoiLuong,
    //            NguonGoc = NguonGoc,
    //            HanSuDung = HanSuDung,
    //            ChiSoSpf = Spf,
    //            ChiSoFa = Fa,
    //            GiaBan = GiaBan

    //        };

    //        if (sanPhamDAL.Update(sanphamList))
    //        {
    //            return "Sua  thành công";
    //        }
    //        else
    //            return "Sua  thất bại";

    //    }

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

            //return QLNVDAL.Update(nhanvien);
        }


        //public bool UpdateTTLV(NhanVien nhanvien)
        //{
        //    return QLNVDAL.UpdateTTLV(nhanvien);
        //}

        public bool UpdateTTLV(NhanVien nhanvien)
        {
            return QLNVDAL.UpdateTTLV(nhanvien);
        }

        public NhanVien GetById(string id)
        {
            return QLNVDAL.GetbyId(id);
        }

        public List<NhanVien> CNTim(string Id)
        {
            if (Id == null || Id == string.Empty)
            {
                return QLNVDAL.GetallNhanVien();

            }
            return QLNVDAL.GetallNhanVien().Where(x => x.IdnhanVien.Contains(Id) || x.IdnhanVien.Contains(Id)).ToList();
        }



        



    }
        
}
