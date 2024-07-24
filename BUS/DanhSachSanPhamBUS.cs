using DAL;
using Data.data;


namespace BUS
{
    public class DanhSachSanPhamBUS
    {
        DanhSachSanPhamDAL DanhSachSanPhamDAL = new DanhSachSanPhamDAL();
        // sản phẩm
        public List<SanPham> GetAllSanPhams(string search)
        {
            if (search == null || search == string.Empty)
            {
                return DanhSachSanPhamDAL.GetAllSanPhams();
            }
            return DanhSachSanPhamDAL.GetAllSanPhams().Where(x => x.IdsanPham.Contains(search) || x.TenSanPham.Contains(search)).ToList();

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
