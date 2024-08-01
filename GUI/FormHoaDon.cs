using BUS;
using DAL;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormHoaDon : Form
    {
        NhanVien _nhanVien { get; set; }
        DanhSachSanPhamBUS DSSP = new DanhSachSanPhamBUS();
        ChucVuBUS ChucVuBUS = new ChucVuBUS();
        ThongTinKhachHangBUS ThongTinKhachHangBUS = new ThongTinKhachHangBUS();
        HoaDonBUS HoaDonBUS = new HoaDonBUS();
        HoaDonChiTietBUS HoaDonChiTietBUS = new HoaDonChiTietBUS();
        private bool daThanhToanDu = false;
        public FormHoaDon(NhanVien nv)
        {
            _nhanVien = nv;

            InitializeComponent();
            dtgDisplay();
            LoadData_cbbHoaDonCho();


        }

        public void dtgDisplay()
        {

            dtgview_danhSachSP.ColumnCount = 6;
            dtgview_danhSachSP.Columns[0].Name = "IDSanPham";
            dtgview_danhSachSP.Columns[1].Name = "TenSP";
            dtgview_danhSachSP.Columns[2].Name = "LoaiSP";
            dtgview_danhSachSP.Columns[3].Name = "KhuyenMai";
            dtgview_danhSachSP.Columns[4].Name = "DonGia";
            dtgview_danhSachSP.Columns[5].Name = "SoLuong";


            LoadData_dgvSanPhamChiTiet();
            dtgview_thongTinHoaDon.ColumnCount = 6;
            dtgview_thongTinHoaDon.Columns[0].Name = "STT";
            dtgview_thongTinHoaDon.Columns[1].Name = "IDSanPham";
            dtgview_thongTinHoaDon.Columns[2].Name = "TenSp";
            dtgview_thongTinHoaDon.Columns[3].Name = "DonGia";
            dtgview_thongTinHoaDon.Columns[4].Name = "KhuyenMai";
            dtgview_thongTinHoaDon.Columns[5].Name = "SoLuong";

            if (cbx_chonHoaDon.SelectedValue != null)
            {
                LoadData_dgvHoaDonChiTiet(HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(cbx_chonHoaDon.SelectedValue.ToString()));
            }


            dtg_LichSuHoaDon.ColumnCount = 5;
            dtg_LichSuHoaDon.Columns[0].Name = "IDHoaDon";
            dtg_LichSuHoaDon.Columns[1].Name = "TenKhachHang";
            dtg_LichSuHoaDon.Columns[2].Name = "SoDienThoai";
            dtg_LichSuHoaDon.Columns[3].Name = "TrangThai";
            dtg_LichSuHoaDon.Columns[4].Name = "NgayMuaHang";
           

            LoadData_LichSuHoaDonByNhanVien(_nhanVien.IdnhanVien);

            dtg_lichSuChiTietHoaDon.ColumnCount = 6;
            dtg_lichSuChiTietHoaDon.Columns[0].Name = "STT";
            dtg_lichSuChiTietHoaDon.Columns[1].Name = "IDSanPham";
            dtg_lichSuChiTietHoaDon.Columns[2].Name = "TenSp";
            dtg_lichSuChiTietHoaDon.Columns[3].Name = "DonGia";
            dtg_lichSuChiTietHoaDon.Columns[4].Name = "KhuyenMai";
            dtg_lichSuChiTietHoaDon.Columns[5].Name = "SoLuong";
        }
        private void LoadData_dgvSanPhamChiTiet()
        {
            dtgview_danhSachSP.Rows.Clear();
            foreach (SanPham sp in DSSP.GetAllSanPhams(txt_timkiem.Text))
            {
                string khuyenmai;
                if (DSSP.GetLoaiSanPhamById((DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham)).IdkhuyenMai != null)
                {
                    khuyenmai = DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById(DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham).IdkhuyenMai).PhanTramGiamGia + "%";

                }
                else
                {
                    khuyenmai = "";
                }
                dtgview_danhSachSP.Rows.Add(sp.IdsanPham,
                    sp.TenSanPham,
                    DSSP.GetLoaiSanPhamById(sp.IdloaiSanPham).LoaiSanPham1,
                    khuyenmai,
                   Convert.ToDecimal(sp.GiaBan).ToString("#,##0.00 'VND'"),

                   sp.SoLuong
                    );
            }
        }

        private void LoadData_LichSuHoaDonByNhanVien(string idnhanvien) 
        {
            dtg_LichSuHoaDon.Rows.Clear();
            foreach (var item in HoaDonBUS.GetAllHoaDonsbyNhanvien(idnhanvien).OrderByDescending(h => h.NgayDatHang))
            {
                string TrangThai="";
                if (item.TrangThaiThanhToan==0)
                {
                    TrangThai = "Chưa thanh toán";
                }else if(item.TrangThaiThanhToan==1)
                {
                    TrangThai = "Đã thanh toán";
                }else if (item.TrangThaiThanhToan == 2)
                {
                    TrangThai = "Hủy";
                }
                dtg_LichSuHoaDon.Rows.Add(item.IdhoaDon, ThongTinKhachHangBUS.GetTenKHByID(item.IdkhachHang).Ten, ThongTinKhachHangBUS.GetTenKHByID(item.IdkhachHang).Sdt,TrangThai,item.NgayDatHang);
                
            }
           
        }
        private void LoadData_dgvHoaDonChiTiet(List<HoaDonChiTiet> hoaDonChiTiets)
        {
            dtgview_thongTinHoaDon.Rows.Clear();

            int i = 1;

            foreach (HoaDonChiTiet sp in hoaDonChiTiets)
            {
                string khuyenmai;
                if (DSSP.GetLoaiSanPhamById((DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham)).IdkhuyenMai != null)
                {
                    khuyenmai = DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById((DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham)).IdkhuyenMai).PhanTramGiamGia + "%";

                }
                else
                {
                    khuyenmai = "";
                }
                dtgview_thongTinHoaDon.Rows.Add(i++,
                    sp.IdsanPham,
                   DSSP.GetSanPhamById(sp.IdsanPham).TenSanPham,
                   Convert.ToDecimal(DSSP.GetSanPhamById(sp.IdsanPham).GiaBan).ToString("#,##0.00 'VND'"),
                   khuyenmai,
                  sp.SoLuong
                   ); ;
            }
            //dgvHoaDonChiTiet.DataSource = dataTableHDCT;
            if (cbx_chonHoaDon.SelectedValue != null)
            {
                lbl_giaTriHoaDon.Text = TinhTongTienHoaDon(cbx_chonHoaDon.SelectedValue.ToString()).ToString("#,##0.00 'VND'");
                lbl_khuyenMai.Text = khuyenMai(cbx_chonHoaDon.SelectedValue.ToString()).ToString("#,##0.00 'VND'");
                lbl_thanhtien.Text = thanhTien(cbx_chonHoaDon.SelectedValue.ToString()).ToString("#,##0.00 'VND'");

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            lbl_tenNhanVien.Text = _nhanVien.TenNhanVien;
            lbl_chucVu.Text = ChucVuBUS.GetChucVuById(_nhanVien.IdchucVu).ChucVu1;
        }

        private void txt_sodienthoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var khachHang = ThongTinKhachHangBUS.GetTenKHBySdt(txt_sodienthoai.Text);
                if (khachHang == null)
                {
                    MessageBox.Show("SĐT khách hàng không hợp lệ!");
                }
                else
                {
                    txt_tenkhachhang.Text = khachHang.Ten;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dtgDisplay();
        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            var khachHang = ThongTinKhachHangBUS.GetTenKHBySdt(txt_sodienthoai.Text);
            if (khachHang == null)
            {
                MessageBox.Show("SĐT khách hàng không hợp lệ!");
            }
            else
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.IdhoaDon = "HD" + (HoaDonBUS.GetAllHoaDons().Count + 1);
                hoaDon.IdnhanVien = _nhanVien.IdnhanVien;
                hoaDon.IdkhachHang = ThongTinKhachHangBUS.GetTenKHBySdt(txt_sodienthoai.Text).IdkhachHang;
                hoaDon.NgayDatHang = DateTime.Now;
                hoaDon.TrangThaiThanhToan = 0; // 0: hóa đơn chờ, 1: đã thanh toán, 2: đã hủy 

                HoaDonBUS.TaoHoaDonCho(hoaDon);

                MessageBox.Show("Tạo hóa đơn chờ thành công!");

                LoadData_cbbHoaDonCho();
            }
        }
        private void LoadData_cbbHoaDonCho()
        {
            cbx_chonHoaDon.DataSource = null;
            cbx_chonHoaDon.Items.Clear();

            // Load dữ liệu lên combobox
            var listHoaDonCho = HoaDonBUS.GetAllHoaDonChos(_nhanVien.IdnhanVien);
            cbx_chonHoaDon.DataSource = listHoaDonCho; // nguồn dữ liệu combobox
            cbx_chonHoaDon.DisplayMember = "IdhoaDon"; // mỗi item hiển thị mã hóa đơn
            cbx_chonHoaDon.ValueMember = "IdhoaDon"; // mỗi item có giá trị là mã hóa đơn
            cbx_chonHoaDon.SelectedItem = listHoaDonCho.FirstOrDefault();
            if (listHoaDonCho.Count == 0)
            {
                cbx_chonHoaDon.SelectedIndex = -1; // Không chọn mục nào cả
            }
            else


                LoadData_dgvHoaDonChiTiet(HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(cbx_chonHoaDon.SelectedValue.ToString()));

        }

        private void cbx_chonHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hoaDonDangChon = cbx_chonHoaDon.SelectedItem as HoaDon;
            if (hoaDonDangChon != null)
            {
                txt_sodienthoai.Text = ThongTinKhachHangBUS.GetTenKHByID(hoaDonDangChon.IdkhachHang).Sdt;
                txt_tenkhachhang.Text = ThongTinKhachHangBUS.GetTenKHByID(hoaDonDangChon.IdkhachHang).Ten;
                //LoadData_dgvHoaDonChiTiet(hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(hoaDonDangChon.MaHoaDon));
                LoadData_dgvHoaDonChiTiet(HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(hoaDonDangChon.IdhoaDon));

            }
        }

        private void dtgview_danhSachSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowHienTai = dtgview_danhSachSP.Rows[e.RowIndex];
            var IdSanPham = rowHienTai.Cells[0].Value.ToString();
            var spDangTao = DSSP.GetSanPhamById(IdSanPham);

            var hoaDonDangChon = cbx_chonHoaDon.SelectedItem as HoaDon;

            FormSoLuongMua formSoLuongMua = new FormSoLuongMua();
            formSoLuongMua.ShowDialog();

            string x = "HDCT" + (HoaDonChiTietBUS.GetAllHoaDonCT().Count + 1);
            if (hoaDonDangChon== null)
            {
                MessageBox.Show("Vui lòng tạo hóa đơn.");
            }
            else
            {
                var hoaDonChiTietTonTai = HoaDonChiTietBUS.GetHDCTById(hoaDonDangChon.IdhoaDon, IdSanPham);

                // chưa tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> thêm mới
                if (hoaDonChiTietTonTai == null)
                {
                    HoaDonChiTiet hoaDonChiTietDangTao = new HoaDonChiTiet();
                    hoaDonChiTietDangTao.IdhoaDonChiTiet = x;
                    hoaDonChiTietDangTao.IdsanPham = IdSanPham;
                    hoaDonChiTietDangTao.IdhoaDon = hoaDonDangChon.IdhoaDon;
                    //hoaDonChiTietDangTao.IdkhuyenMai = spDangTao.IdkhuyenMai;
                    hoaDonChiTietDangTao.Gia = spDangTao.GiaBan;
                    hoaDonChiTietDangTao.SoLuong = formSoLuongMua.SoLuongMua;
                    HoaDonChiTietBUS.ThemMoiHDCT(hoaDonChiTietDangTao);
                }
                // nếu đã tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> cập nhật số lượng
                else
                {
                    HoaDonChiTiet hoaDonChiTietDangUpdate = new HoaDonChiTiet();
                    hoaDonChiTietDangUpdate.IdhoaDonChiTiet = x;
                    hoaDonChiTietDangUpdate.IdsanPham = IdSanPham;

                    hoaDonChiTietDangUpdate.IdhoaDon = hoaDonDangChon.IdhoaDon;
                    //hoaDonChiTietDangUpdate.IdkhuyenMai = spDangTao.IdkhuyenMai;
                    hoaDonChiTietDangUpdate.Gia = spDangTao.GiaBan;
                    hoaDonChiTietDangUpdate.SoLuong = hoaDonChiTietTonTai.SoLuong + formSoLuongMua.SoLuongMua;

                    HoaDonChiTietBUS.UpdateSoLuong(hoaDonChiTietDangUpdate);
                }

                spDangTao.SoLuong -= formSoLuongMua.SoLuongMua;
                DSSP.UpdateSoLuong(spDangTao);

                // load lại dữ liệu trên 2 data grid view
                //txt_timkiem.Text = string.Empty;
                LoadData_dgvSanPhamChiTiet();
                LoadData_dgvHoaDonChiTiet(HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(cbx_chonHoaDon.SelectedValue.ToString()));

            }


        }
        private decimal TinhTongTienHoaDon(string maHoaDon)
        {
            var listHDCT = HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            decimal tongTien = 0;

            foreach (var hdct in listHDCT)
            {
                tongTien += Convert.ToDecimal(hdct.Gia) * Convert.ToDecimal(hdct.SoLuong);
            }

            return tongTien;
        }

        private decimal khuyenMai(string maHoaDon)
        {
            var listHDCT = HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            decimal khuyenmai = 0;


            foreach (var hdct in listHDCT)
            {
                decimal phanTramKhuyenmai;
                if (DSSP.GetKhuyenMaiById(hdct.IdkhuyenMai) != null)
                {
                    phanTramKhuyenmai = Convert.ToDecimal(DSSP.GetKhuyenMaiById(hdct.IdkhuyenMai).PhanTramGiamGia / 100);

                }
                else
                {
                    phanTramKhuyenmai = 0;
                }
                khuyenmai += Convert.ToDecimal(hdct.Gia) * phanTramKhuyenmai
                    * Convert.ToDecimal(hdct.SoLuong);
            }

            return khuyenmai;
        }

        private decimal thanhTien(string maHoaDon)
        {
            var listHDCT = HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            decimal thanhTien = 0;

            foreach (var hdct in listHDCT)
            {
                decimal phanTramKhuyenmai;
                if (DSSP.GetKhuyenMaiById(hdct.IdkhuyenMai) != null)
                {
                    phanTramKhuyenmai = Convert.ToDecimal(DSSP.GetKhuyenMaiById(hdct.IdkhuyenMai).PhanTramGiamGia / 100);

                }
                else
                {
                    phanTramKhuyenmai = 0;
                }
                thanhTien += (Convert.ToDecimal(hdct.Gia) -
                    Convert.ToDecimal(hdct.Gia) * phanTramKhuyenmai)
                    * Convert.ToDecimal(hdct.SoLuong);
            }

            return thanhTien;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_tinKhachDua_TextChanged(object sender, EventArgs e)
        {
            decimal tienKhachDua = 0;
            var tongSoTien = thanhTien(cbx_chonHoaDon.SelectedValue.ToString());

            if (decimal.TryParse(txt_tinKhachDua.Text, out tienKhachDua))
            {
                lb_tienThua.Text = (tienKhachDua - tongSoTien).ToString("#,##0.00 'VND'");
                if (tienKhachDua >= tongSoTien)
                {
                    daThanhToanDu = true;
                }
                else
                {
                    daThanhToanDu = false;
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng số tiền!");
            }
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            if (thanhTien(cbx_chonHoaDon.SelectedValue.ToString()) > 0)
            {
                if (daThanhToanDu)
                {
                    HoaDonBUS.SuaTrangThai(cbx_chonHoaDon.SelectedValue.ToString(), 1);
                    MessageBox.Show("Đã thanh toán hóa đơn!");
                    RefreshToanBoForm();
                }
                else
                {
                    MessageBox.Show("Tiền khách đưa chưa đủ!");
                }
            }
            else
            {
                MessageBox.Show("Hóa đơn trống!");
            }
        }

        private void RefreshToanBoForm()
        {
            txt_sodienthoai.Text = string.Empty;
            txt_tenkhachhang.Text = string.Empty;
            txt_timkiem.Text = string.Empty;
            lbl_giaTriHoaDon.Text = "0";
            txt_tinKhachDua.Text = "0";
            lb_tienThua.Text = "0";
            lbl_khuyenMai.Text = "0";
            lbl_thanhtien.Text = "0";
            lb_tienThua.Text = "0";
            LoadData_LichSuHoaDonByNhanVien(_nhanVien.IdnhanVien);
            LoadData_cbbHoaDonCho();
            LoadData_dgvSanPhamChiTiet();
            
            if (cbx_chonHoaDon.SelectedValue != null)
            {
                LoadData_dgvHoaDonChiTiet(HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(cbx_chonHoaDon.SelectedValue.ToString()));
            }
            else
            {
                LoadData_dgvHoaDonChiTiet(new List<HoaDonChiTiet>());
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            var listHDCT = HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(cbx_chonHoaDon.SelectedValue.ToString());
            foreach (var hdct in listHDCT)
            {
                var spct = DSSP.GetSanPhamById(hdct.IdsanPham);
                // hoàn lại số lượng sản phẩm đã chọn trong hóa đơn vào lại danh sách sản phẩm
               spct.SoLuong += Convert.ToInt32(hdct.SoLuong);

                DSSP.UpdateSoLuong(spct);
            }

            HoaDonBUS.SuaTrangThai(cbx_chonHoaDon.SelectedValue.ToString(), 2);
            MessageBox.Show("Đã hủy hóa đơn!");
            RefreshToanBoForm();
        }
    }
}
