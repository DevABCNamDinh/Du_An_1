using DAL;


using Data.Data;



using Microsoft.EntityFrameworkCore;







namespace BUS
{
    public class DanhSachSanPhamBUS
    {
        DanhSachSanPhamDAL DanhSachSanPhamDAL = new DanhSachSanPhamDAL();
        // sản phẩm
        public List<SanPham> GetAllSanPhams(string search,string loaiSP)
        {
            var hoaDons = DanhSachSanPhamDAL.GetAllSanPhams().AsQueryable();
            if (search != null || search != string.Empty)
            {
               hoaDons= hoaDons.Where(x => x.IdsanPham.Contains(search) || x.TenSanPham.Contains(search));
            }

            if (loaiSP =="0")
            {

            }
            else
            {
                hoaDons = hoaDons.Where(x => x.IdloaiSanPham == loaiSP);
            }

            return hoaDons.ToList();
        }

        public List<LoaiSanPham> getAllLoaiSP()
        {
            return DanhSachSanPhamDAL.GetAllLoaiSP();
        }
        public SanPham? GetSanPhamById(string maSanPham)
        {
            return DanhSachSanPhamDAL.GetSanPhamById(maSanPham);
        }

        //sản phẩm chi tiết
        //public List<SanPhamChiTiet> GetAllSanPhamChiTiets()
        //{
        //    return DanhSachSanPhamDAL.GetAllSanPhamChiTiets();
        //}

        //public SanPhamChiTiet GetAllSanPhamChiTietById(string maSPCT)
        //{
        //    return DanhSachSanPhamDAL.GetAllSanPhamChiTietById(maSPCT);
        //}

        public void UpdateSoLuong(SanPham sp)
        {
            DanhSachSanPhamDAL.UpdateSoLuong(sp);
        }

        //loại sản phẩm
        public LoaiSanPham? GetLoaiSanPhamById(string idLoaiSanPham)
        {
            return DanhSachSanPhamDAL.GetLoaiSanPhamById(idLoaiSanPham);
        }
        //khuyến mãi
        public KhuyenMai? GetKhuyenMaiById(string idKhuyenMai)
        {
            return DanhSachSanPhamDAL.GetKhuyenMaiById(idKhuyenMai);
        }





        // chức vụ
      
    }
}
