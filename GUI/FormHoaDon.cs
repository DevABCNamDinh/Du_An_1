﻿using BUS;
using DAL;




using Data.Modee;



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.Xml;
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
        ThanhTienBUS ThanhTienBUS = new ThanhTienBUS();
        LLoaiSanPhamBLL LoaiSanPhamBLL = new LLoaiSanPhamBLL();
        private bool daThanhToanDu = false;
        string idhoaDonIN;
        public FormHoaDon(NhanVien nv)
        {
            _nhanVien = nv;
          
            InitializeComponent();
            txt_tienKhachDua1.TextChanged += txt_tienKhachDua1_TextChanged;
            dtgDisplay();
            LoadData_cbbHoaDonCho();



        }

        public void dtgDisplay()
        {

            dtgview_danhSachSP.ColumnCount = 6;
            dtgview_danhSachSP.Columns[0].Name = "IDSanPham";
            dtgview_danhSachSP.Columns[0].Visible = false;
            dtgview_danhSachSP.Columns[1].Name = "TenSP";
            dtgview_danhSachSP.Columns[2].Name = "LoaiSP";
            dtgview_danhSachSP.Columns[3].Name = "KhuyenMai";
            dtgview_danhSachSP.Columns[4].Name = "DonGia";
            dtgview_danhSachSP.Columns[5].Name = "SoLuong";
            dtgview_danhSachSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dtgview_danhSachSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadCBX_LoaiSP();
            LoadData_dgvSanPhamChiTiet();
            dtgview_thongTinHoaDon1.ColumnCount = 7;
            dtgview_thongTinHoaDon1.Columns[0].Name = "STT";
            dtgview_thongTinHoaDon1.Columns[1].Name = "IDHDCT";
            dtgview_thongTinHoaDon1.Columns[1].Visible = false;
            dtgview_thongTinHoaDon1.Columns[2].Name = "IDSanPham";
            dtgview_thongTinHoaDon1.Columns[2].Visible = false;
            dtgview_thongTinHoaDon1.Columns[3].Name = "TenSp";
            dtgview_thongTinHoaDon1.Columns[4].Name = "DonGia";
            dtgview_thongTinHoaDon1.Columns[5].Name = "KhuyenMai";
            dtgview_thongTinHoaDon1.Columns[6].Name = "SoLuong";
            dtgview_thongTinHoaDon1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (cbx_chonHoaDon1.SelectedValue != null)
            {
                LoadData_dgvHoaDonChiTiet(HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(cbx_chonHoaDon1.SelectedValue.ToString()));
            }
            //dtgview_thongTinHoaDon1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dtgview_thongTinHoaDon1.Columns[2].FillWeight = 200;
            //dtgview_thongTinHoaDon1.Columns[0].FillWeight = 40;

            dtg_LichSuHoaDon.ColumnCount = 5;
            dtg_LichSuHoaDon.Columns[0].Name = "IDHoaDon";
            dtg_LichSuHoaDon.Columns[1].Name = "TenKhachHang";
            dtg_LichSuHoaDon.Columns[2].Name = "SoDienThoai";
            dtg_LichSuHoaDon.Columns[3].Name = "TrangThai";
            dtg_LichSuHoaDon.Columns[4].Name = "NgayMuaHang";
            dtg_LichSuHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



            dtg_lichSuChiTietHoaDon.ColumnCount = 6;
            dtg_lichSuChiTietHoaDon.Columns[0].Name = "STT";
            dtg_lichSuChiTietHoaDon.Columns[1].Name = "IDSanPham";
            dtg_lichSuChiTietHoaDon.Columns[1].Visible = false;
            dtg_lichSuChiTietHoaDon.Columns[2].Name = "TenSp";
            dtg_lichSuChiTietHoaDon.Columns[3].Name = "DonGia";
            dtg_lichSuChiTietHoaDon.Columns[4].Name = "KhuyenMai";
            dtg_lichSuChiTietHoaDon.Columns[5].Name = "SoLuong";

            LoadData_LichSuHoaDonByNhanVien(_nhanVien.IdnhanVien);
            dtg_lichSuChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_lichSuChiTietHoaDon.Columns[2].FillWeight = 200;
            dtg_lichSuChiTietHoaDon.Columns[0].FillWeight = 40;


        }


        public void LoadCBX_LoaiSP()
        {
            //foreach (var item in DQLNhanVienBUS.Getallnhanvien())
            //{
            //    cbx_nhanVien.Items.Add(item.IdnhanVien+"-"+item.TenNhanVien);
            //}
            var DSLoaiSP = LoaiSanPhamBLL.Getallloaisp();

            if (DSLoaiSP != null)
            {
                DSLoaiSP.Insert(0, new LoaiSanPham { IdloaiSanPham = "0", LoaiSanPham1 = "Tất cả" });
                cbx_loaiSP.DataSource = DSLoaiSP;
                cbx_loaiSP.DisplayMember = "LoaiSanPham1";
                cbx_loaiSP.ValueMember = "IdloaiSanPham";
            }




        }

        public string idLoaiSP()
        {

            return cbx_loaiSP.SelectedValue.ToString();


        }
        private void LoadData_dgvSanPhamChiTiet()
        {
            dtgview_danhSachSP.Rows.Clear();
            foreach (SanPham sp in DSSP.GetAllSanPhams(txt_timkiem.Text, idLoaiSP()))
            {
                string khuyenmai;
              

                if (sp.TrangThai == true&&sp.SoLuong>0)
                {
                    if (DSSP.GetLoaiSanPhamById((DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham)).IdkhuyenMai != null)
                    {
                        if (DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById((DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham)).IdkhuyenMai).TrangThai == true&& DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById((DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham)).IdkhuyenMai).TamNgung == false)
                        {
                            khuyenmai = Convert.ToString(DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById(DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham).IdkhuyenMai).PhanTramGiamGia);
                        }
                        else
                        {
                            khuyenmai = "0";
                        }
                    }
                    else
                    {
                        khuyenmai = "0";
                    }
                    dtgview_danhSachSP.Rows.Add(sp.IdsanPham,
                        sp.TenSanPham,
                        DSSP.GetLoaiSanPhamById(sp.IdloaiSanPham).LoaiSanPham1,
                        khuyenmai + "%",
                       Convert.ToDecimal(sp.GiaBan).ToString("#,##0 'VND'"),

                       sp.SoLuong
                        );
                }
            }


        }
        int demso;
        private void LoadData_LichSuHoaDonByNhanVien(string idnhanvien)
        {
            demso = 0;
            dtg_LichSuHoaDon.Rows.Clear();
            foreach (var item in HoaDonBUS.GetAllHoaDonsbyNhanvien(idnhanvien).OrderByDescending(h => h.NgayDatHang))
            {
                string TrangThai = "";
                if (item.TrangThaiThanhToan == 0)
                {
                    TrangThai = "Chưa thanh toán";
                }
                else if (item.TrangThaiThanhToan == 1)
                {
                    TrangThai = "Đã thanh toán";
                }
                else if (item.TrangThaiThanhToan == 2)
                {
                    TrangThai = "Hủy";
                }
                if (item.TrangThaiThanhToan == 0)
                {
                    continue;
                }

                dtg_LichSuHoaDon.Rows.Add(item.IdhoaDon, ThongTinKhachHangBUS.GetTenKHByID(item.IdkhachHang).Ten, ThongTinKhachHangBUS.GetTenKHByID(item.IdkhachHang).Sdt, TrangThai, item.NgayDatHang);
                demso++;
                if (demso == 1)
                {
                    Load_LS_HoaDon(item.IdhoaDon);
                }
            }



        }
        private void LoadData_dgvHoaDonChiTiet(List<HoaDonChiTiet> hoaDonChiTiets)
        {
            dtgview_thongTinHoaDon1.Rows.Clear();

            int i = 1;

            foreach (HoaDonChiTiet sp in hoaDonChiTiets)
            {
                string khuyenmai;
                if (DSSP.GetLoaiSanPhamById((DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham)).IdkhuyenMai != null)
                {
                    if (DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById((DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham)).IdkhuyenMai).TrangThai == true)
                    {
                        khuyenmai = Convert.ToString(DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById((DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham)).IdkhuyenMai).PhanTramGiamGia);
                    }
                    else
                    {
                        khuyenmai = "0";
                    }

                }
                else
                {
                    khuyenmai = "0";
                }
                if (sp.SoLuong != 0)
                {
                    dtgview_thongTinHoaDon1.Rows.Add(i++,
                            sp.IdhoaDonChiTiet,
                            sp.IdsanPham,
                           DSSP.GetSanPhamById(sp.IdsanPham).TenSanPham,
                           Convert.ToDecimal(DSSP.GetSanPhamById(sp.IdsanPham).GiaBan).ToString("#,##0 'VND'"),
                           khuyenmai + "%",
                           sp.SoLuong
                   ); ;
                }

            }
            //dgvHoaDonChiTiet.DataSource = dataTableHDCT;
            if (cbx_chonHoaDon1.SelectedValue != null)
            {
                lbl_tongHoaDon1.Text = TinhTongTienHoaDon(cbx_chonHoaDon1.SelectedValue.ToString()).ToString("#,##0 'VND'");
                lbl_khuyenMai1.Text = khuyenMai(cbx_chonHoaDon1.SelectedValue.ToString()).ToString("#,##0 'VND'");
                lbl_thanhTien1.Text = thanhTien(cbx_chonHoaDon1.SelectedValue.ToString()).ToString("#,##0 'VND'");
                if (txt_tienKhachDua1.Text != "")
                {
                    lbl_tienThua1.Text = Convert.ToString(Convert.ToInt32(txt_tienKhachDua1.Text) - Convert.ToInt32(thanhTien(cbx_chonHoaDon1.SelectedValue.ToString())));
                    if (Convert.ToInt32(lbl_tienThua1.Text) < 0)
                    {
                        daThanhToanDu=false;
                    }
                }

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
            cbx_chonHoaDon1.DataSource = null;
            cbx_chonHoaDon1.Items.Clear();

            // Load dữ liệu lên combobox
            var listHoaDonCho = HoaDonBUS.GetAllHoaDonChos(_nhanVien.IdnhanVien);
            cbx_chonHoaDon1.DataSource = listHoaDonCho; // nguồn dữ liệu combobox
            cbx_chonHoaDon1.DisplayMember = "IdhoaDon"; // mỗi item hiển thị mã hóa đơn
            cbx_chonHoaDon1.ValueMember = "IdhoaDon"; // mỗi item có giá trị là mã hóa đơn
            cbx_chonHoaDon1.SelectedItem = listHoaDonCho.FirstOrDefault();
            if (listHoaDonCho.Count == 0)
            {
                cbx_chonHoaDon1.SelectedIndex = -1; // Không chọn mục nào cả
            }
            else


                LoadData_dgvHoaDonChiTiet(HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(cbx_chonHoaDon1.SelectedValue.ToString()));

        }

        private void cbx_chonHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgview_danhSachSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= DSSP.GetAllSanPhams(txt_timkiem.Text, idLoaiSP()).Count())
            {
                return;
            }
            var rowHienTai = dtgview_danhSachSP.Rows[e.RowIndex];
            var IdSanPham = rowHienTai.Cells[0].Value.ToString();
            var spDangTao = DSSP.GetSanPhamById(IdSanPham);

            var hoaDonDangChon = cbx_chonHoaDon1.SelectedItem as HoaDon;

            FormSoLuongMua formSoLuongMua = new FormSoLuongMua();
            formSoLuongMua.ShowDialog();

            string x = "HDCT" + (HoaDonChiTietBUS.GetAllHoaDonCT().Count + 1);
            if (hoaDonDangChon == null)
            {
                MessageBox.Show("Vui lòng tạo hóa đơn.");
            }
            else
            {
                var hoaDonChiTietTonTai = HoaDonChiTietBUS.GetHDCTById(hoaDonDangChon.IdhoaDon, IdSanPham);

                if (spDangTao.SoLuong < formSoLuongMua.SoLuongMua)
                {
                    MessageBox.Show("Số lượng bạn nhập nhiều hơn số lượng trong kho!");
                }
                else if (formSoLuongMua.SoLuongMua < 0)
                {
                    MessageBox.Show("Số lượng bạn nhập không được âm!");

                }

                else if (formSoLuongMua.SoLuongMua == 0)
                {

                }

                else
                {
                    // chưa tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> thêm mới
                    if (hoaDonChiTietTonTai == null)
                    {
                        HoaDonChiTiet hoaDonChiTietDangTao = new HoaDonChiTiet();
                        hoaDonChiTietDangTao.IdhoaDonChiTiet = x;
                        hoaDonChiTietDangTao.IdsanPham = IdSanPham;
                        hoaDonChiTietDangTao.IdhoaDon = hoaDonDangChon.IdhoaDon;
                        if (DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById((DSSP.GetSanPhamById((IdSanPham)).IdloaiSanPham)).IdkhuyenMai) != null)
                        {
                            hoaDonChiTietDangTao.KhuyenMai = Convert.ToString(DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById((DSSP.GetSanPhamById((IdSanPham)).IdloaiSanPham)).IdkhuyenMai).PhanTramGiamGia);
                        }
                        else
                        {
                            hoaDonChiTietDangTao.KhuyenMai = "0";
                        }
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
                        //hoaDonChiTietDangUpdate.IdkhuyenMai = Convert.ToString(DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById((DSSP.GetSanPhamById((IdSanPham)).IdloaiSanPham)).IdkhuyenMai).PhanTramGiamGia);
                        //hoaDonChiTietDangUpdate.Gia = spDangTao.GiaBan;
                        hoaDonChiTietDangUpdate.SoLuong = hoaDonChiTietTonTai.SoLuong + formSoLuongMua.SoLuongMua;

                        HoaDonChiTietBUS.UpdateSoLuong(hoaDonChiTietDangUpdate);
                    }

                    spDangTao.SoLuong -= formSoLuongMua.SoLuongMua;
                    DSSP.UpdateSoLuong(spDangTao);
                }


                // load lại dữ liệu trên 2 data grid view
                //txt_timkiem.Text = string.Empty;
                LoadData_dgvSanPhamChiTiet();
                LoadData_dgvHoaDonChiTiet(HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(cbx_chonHoaDon1.SelectedValue.ToString()));

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
                var x = DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById(DSSP.GetSanPhamById(hdct.IdsanPham).IdloaiSanPham).IdkhuyenMai);
                if (x != null)
                {
                    phanTramKhuyenmai = Convert.ToDecimal(x.PhanTramGiamGia / 100);

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
            //var listHDCT = HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            decimal thanhTien = TinhTongTienHoaDon(maHoaDon) - khuyenMai(maHoaDon);

            //foreach (var hdct in listHDCT)
            //{
            //    decimal phanTramKhuyenmai;
            //    if (DSSP.GetKhuyenMaiById(hdct.IdkhuyenMai) != null)
            //    {
            //        phanTramKhuyenmai = Convert.ToDecimal(DSSP.GetKhuyenMaiById(hdct.IdkhuyenMai).PhanTramGiamGia / 100);

            //    }
            //    else
            //    {
            //        phanTramKhuyenmai = 0;
            //    }
            //    thanhTien += (Convert.ToDecimal(hdct.Gia) -
            //        Convert.ToDecimal(hdct.Gia) * phanTramKhuyenmai)
            //        * Convert.ToDecimal(hdct.SoLuong);
            //}

            return thanhTien;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_tinKhachDua_TextChanged(object sender, EventArgs e)
        {


        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {

        }

        private void RefreshToanBoForm()
        {
            txt_sodienthoai.Text = string.Empty;
            txt_tenkhachhang.Text = string.Empty;
            txt_timkiem.Text = string.Empty;
            lbl_tongHoaDon1.Text = "0";
            txt_tienKhachDua1.Text = "";
            lbl_tienThua1.Text = "0";
            lbl_khuyenMai1.Text = "0";
            lbl_thanhTien1.Text = "0";

            LoadData_LichSuHoaDonByNhanVien(_nhanVien.IdnhanVien);
            //Load_LS_HoaDon("HD6");
            LoadData_cbbHoaDonCho();
            LoadData_dgvSanPhamChiTiet();

            if (cbx_chonHoaDon1.SelectedValue != null)
            {
                LoadData_dgvHoaDonChiTiet(HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(cbx_chonHoaDon1.SelectedValue.ToString()));
            }
            else
            {
                LoadData_dgvHoaDonChiTiet(new List<HoaDonChiTiet>());
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {


        }

        private void dtg_LichSuHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idwhenclick;
            int i = 1;
            int index = e.RowIndex;
            if (index < 0 || index >= demso)
            {
                return;
            }
            dtg_lichSuChiTietHoaDon.Rows.Clear();


            idwhenclick = dtg_LichSuHoaDon.Rows[index].Cells[0].Value.ToString();

            foreach (var item in HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(idwhenclick))
            {
                if (item.SoLuong != 0)
                {
                    dtg_lichSuChiTietHoaDon.Rows.Add(i++, item.IdsanPham, DSSP.GetSanPhamById(item.IdsanPham).TenSanPham, Convert.ToDecimal(item.Gia).ToString("#,##0 'VND'"), item.KhuyenMai + "%", item.SoLuong);
                }
            }
            var x = ThanhTienBUS.GetThanhtienbyMaHoaDon(idwhenclick);
            if (x != null)
            {
                lbl_LichSuThanhTien.Text = Convert.ToDecimal(x.ThanhTien1).ToString("#,##0 'VND'");
                lbl_LichSuKhuyenMai.Text = Convert.ToDecimal(x.KhuyenMai).ToString("#,##0 'VND'");
                lbl_LichSuTongHoaDon.Text = Convert.ToDecimal(x.TongHoaDon).ToString("#,##0 'VND'");
                lbl_LichSuTienKhachDua.Text = Convert.ToDecimal(x.TienKhachDua).ToString("#,##0 'VND'");
                lbl_LichSuTienThua.Text = Convert.ToDecimal(x.TienThua).ToString("#,##0 'VND'");

            }
            if (HoaDonBUS.GetHoaDonbyMaHoaDon(idwhenclick).TrangThaiThanhToan == 1)
            {
                txt_daThanhToan.Text = "Đã thanh toán";
                txt_daHuy.Text = "";
            }
            else if (HoaDonBUS.GetHoaDonbyMaHoaDon(idwhenclick).TrangThaiThanhToan == 2)
            {
                txt_daThanhToan.Text = "";
                txt_daHuy.Text = "Đã hủy";
            }



        }

        public void Load_LS_HoaDon(string idHoaDon)
        {

            int i = 1;

            dtg_lichSuChiTietHoaDon.Rows.Clear();

            foreach (var item in HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(idHoaDon))
            {
                if (item.SoLuong != 0)
                {
                    dtg_lichSuChiTietHoaDon.Rows.Add(i++, item.IdsanPham, DSSP.GetSanPhamById(item.IdsanPham).TenSanPham, Convert.ToDecimal(item.Gia).ToString("#,##0 'VND'"), item.KhuyenMai + "%", item.SoLuong);
                }
            }
            var x = ThanhTienBUS.GetThanhtienbyMaHoaDon(idHoaDon);
            if (x != null)
            {
                lbl_LichSuThanhTien.Text = Convert.ToDecimal(x.ThanhTien1).ToString("#,##0 'VND'");
                lbl_LichSuKhuyenMai.Text = Convert.ToDecimal(x.KhuyenMai).ToString("#,##0 'VND'");
                lbl_LichSuTongHoaDon.Text = Convert.ToDecimal(x.TongHoaDon).ToString("#,##0 'VND'");
                lbl_LichSuTienKhachDua.Text = Convert.ToDecimal(x.TienKhachDua).ToString("#,##0 'VND'");
                lbl_LichSuTienThua.Text = Convert.ToDecimal(x.TienThua).ToString("#,##0 'VND'");

            }
            if (HoaDonBUS.GetHoaDonbyMaHoaDon(idHoaDon).TrangThaiThanhToan == 1)
            {
                txt_daThanhToan.Text = "Đã thanh toán";
                txt_daHuy.Text = "";
            }
            else if (HoaDonBUS.GetHoaDonbyMaHoaDon(idHoaDon).TrangThaiThanhToan == 2)
            {
                txt_daThanhToan.Text = "";
                txt_daHuy.Text = "Đã hủy";
            }
        }

        private void dtgview_thongTinHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {


            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 12);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offsetY = 40;

            Pen blackPen = new Pen(Color.Black, 1);

            // In tiêu đề hóa đơn
            graphics.DrawString("SUNSCREEN FPL", new Font("Arial", 18), new SolidBrush(Color.Black), startX, startY);
            offsetY += (int)fontHeight + 10;
            graphics.DrawString("Địa chỉ: Số 10, Đường Trịnh Văn Bô, Quận Nam Từ Liêm ", font, new SolidBrush(Color.Black), startX, startY + offsetY);
            offsetY += (int)fontHeight + 10;
            graphics.DrawString("Số điện thoại: 0999922278", font, new SolidBrush(Color.Black), startX, startY + offsetY);
            offsetY += (int)fontHeight + 10;
       
            // In thông tin hóa đơn
            graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 16), new SolidBrush(Color.Black), startX, startY + offsetY);
            offsetY += (int)fontHeight + 20;
            graphics.DrawString($"Mã hóa đơn: {cbx_chonHoaDon1.Text}", font, new SolidBrush(Color.Black), startX, startY + offsetY);
            offsetY += (int)fontHeight + 10;
            graphics.DrawString($"Nhân viên bán hàng: {_nhanVien.TenNhanVien}", font, new SolidBrush(Color.Black), startX, startY + offsetY);
            offsetY += (int)fontHeight + 10;
            //graphics.DrawString("Ngày: " + hoaDon.NgayLap.ToString("dd/MM/yyyy"), font, new SolidBrush(Color.Black), startX, startY + offsetY);
            //offsetY += (int)fontHeight + 30;

            // In thông tin khách hàng
            graphics.DrawString("THÔNG TIN KHÁCH HÀNG", new Font("Arial", 16), new SolidBrush(Color.Black), startX, startY + offsetY);

            offsetY += (int)fontHeight + 10;
            graphics.DrawString($"Số điện thoại: {txt_sodienthoai.Text}", font, new SolidBrush(Color.Black), startX, startY + offsetY);
            offsetY += (int)fontHeight + 10;
            graphics.DrawString($"Tên khách hàng: {txt_tenkhachhang.Text}", font, new SolidBrush(Color.Black), startX, startY + offsetY);
            offsetY += (int)fontHeight + 30;

            // Vẽ bảng sản phẩm
            int tableStartX = startX;
            int tableStartY = startY + offsetY;
            int cellWidth = 100;
            int cellHeight = 30;

            // Vẽ tiêu đề bảng
            graphics.DrawRectangle(blackPen, tableStartX, tableStartY, cellWidth, cellHeight);
            graphics.DrawString("STT", font, new SolidBrush(Color.Black), tableStartX, tableStartY);

            graphics.DrawRectangle(blackPen, tableStartX + cellWidth, tableStartY, cellWidth * 2, cellHeight);
            graphics.DrawString("Tên SP", font, new SolidBrush(Color.Black), tableStartX + cellWidth, tableStartY);

            graphics.DrawRectangle(blackPen, tableStartX + cellWidth * 3, tableStartY, cellWidth, cellHeight);
            graphics.DrawString("Đơn Giá", font, new SolidBrush(Color.Black), tableStartX + cellWidth * 3, tableStartY);

            graphics.DrawRectangle(blackPen, tableStartX + cellWidth * 4, tableStartY, cellWidth, cellHeight);
            graphics.DrawString("Khuyến Mãi", font, new SolidBrush(Color.Black), tableStartX + cellWidth * 4, tableStartY);

            graphics.DrawRectangle(blackPen, tableStartX + cellWidth * 5, tableStartY, cellWidth, cellHeight);
            graphics.DrawString("Số Lượng", font, new SolidBrush(Color.Black), tableStartX + cellWidth * 5, tableStartY);

            tableStartY += cellHeight;

            // Vẽ các hàng sản phẩm
            int i = 1;
            foreach (var sp in HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(idhoaDonIN))
            {
                // STT
                graphics.DrawRectangle(blackPen, tableStartX, tableStartY, cellWidth, cellHeight);
                graphics.DrawString(i++.ToString(), font, new SolidBrush(Color.Black), tableStartX, tableStartY);

                // Tên sản phẩm
                graphics.DrawRectangle(blackPen, tableStartX + cellWidth, tableStartY, cellWidth * 2, cellHeight);
                graphics.DrawString(DSSP.GetSanPhamById(sp.IdsanPham).TenSanPham, font, new SolidBrush(Color.Black), tableStartX + cellWidth, tableStartY);

                // Đơn giá
                graphics.DrawRectangle(blackPen, tableStartX + cellWidth * 3, tableStartY, cellWidth, cellHeight);
                graphics.DrawString(Convert.ToDecimal(sp.Gia).ToString("#,##0 'VND'"), font, new SolidBrush(Color.Black), tableStartX + cellWidth * 3, tableStartY);

                // Khuyến mãi
                graphics.DrawRectangle(blackPen, tableStartX + cellWidth * 4, tableStartY, cellWidth, cellHeight);
                if (Convert.ToInt32(DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById(DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham).IdkhuyenMai).TrangThai) == 1)
                {
                    graphics.DrawString(Convert.ToString(DSSP.GetKhuyenMaiById(DSSP.GetLoaiSanPhamById(DSSP.GetSanPhamById(sp.IdsanPham).IdloaiSanPham).IdkhuyenMai).PhanTramGiamGia) + "%", font, new SolidBrush(Color.Black), tableStartX + cellWidth * 4, tableStartY);
                }

                // Số lượng
                graphics.DrawRectangle(blackPen, tableStartX + cellWidth * 5, tableStartY, cellWidth, cellHeight);
                graphics.DrawString(sp.SoLuong.ToString(), font, new SolidBrush(Color.Black), tableStartX + cellWidth * 5, tableStartY);

                tableStartY += cellHeight;
            }

            offsetY = tableStartY - startY + 20;

            //in tổng tiền, khuyến mãi, thành tiền, tiền khách đưa và tiền thừa

            var thanhTien = ThanhTienBUS.GetThanhtienbyMaHoaDon(idhoaDonIN);
            graphics.DrawString($"Tổng hóa đơn: {Convert.ToDecimal(thanhTien.TongHoaDon).ToString("#,##0 'VND'")}", font, new SolidBrush(Color.Black), startX, startY + offsetY);
            offsetY += (int)fontHeight + 10;
            graphics.DrawString($"Khuyến mãi: {Convert.ToDecimal(thanhTien.KhuyenMai).ToString("#,##0 'VND'")}", font, new SolidBrush(Color.Black), startX, startY + offsetY);
            offsetY += (int)fontHeight + 10;

            graphics.DrawString($"Thành tiền: {Convert.ToDecimal(thanhTien.ThanhTien1).ToString("#,##0 'VND'")}", font, new SolidBrush(Color.Black), startX, startY + offsetY);
            offsetY += (int)fontHeight + 10;

            graphics.DrawString($"Tiền khách đưa: {Convert.ToDecimal(thanhTien.TienKhachDua).ToString("#,##0 'VND'")}", font, new SolidBrush(Color.Black), startX, startY + offsetY);
            offsetY += (int)fontHeight + 10;

            graphics.DrawString($"Tiền thừa: {Convert.ToDecimal(thanhTien.TienThua).ToString("#,##0 'VND'")}", font, new SolidBrush(Color.Black), startX, startY + offsetY);
            offsetY += (int)fontHeight + 30;

            // in thông báo 
            graphics.DrawString("đã thanh toán", new Font("Arial", 16, FontStyle.Bold), new SolidBrush(Color.Red), startX, startY + offsetY);
        }

        private void dtgview_thongTinHoaDon1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var hoaDonDangChon = cbx_chonHoaDon1.SelectedItem as HoaDon;
            int index = e.RowIndex;
            if (index < 0 || index >= HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(hoaDonDangChon.IdhoaDon).Count())
            {
                return;
            }
            var rowHienTai = dtgview_thongTinHoaDon1.Rows[e.RowIndex];
            var IdSanPham = rowHienTai.Cells[2].Value.ToString();
            var IdHDCT = rowHienTai.Cells[1].Value.ToString();

            var spDangChon = DSSP.GetSanPhamById(IdSanPham);

            var HDCTXoa = HoaDonChiTietBUS.GetHDCTByIdHDCT(IdHDCT);

            FormSoLuongMua formSoLuongMua = new FormSoLuongMua();
            formSoLuongMua.ShowDialog();


            if (hoaDonDangChon == null)
            {
                MessageBox.Show("Vui lòng tạo hóa đơn.");
            }
            else
            {
                HoaDonChiTiet hoaDonChiTietDangUpdate = new HoaDonChiTiet();

                var hoaDonChiTietTonTai = HoaDonChiTietBUS.GetHDCTById(hoaDonDangChon.IdhoaDon, IdSanPham);

                if (spDangChon.SoLuong + hoaDonChiTietDangUpdate.SoLuong < formSoLuongMua.SoLuongMua)
                {
                    MessageBox.Show("Số lượng bạn nhập nhiều hơn số lượng trong kho!");
                }
                else if (formSoLuongMua.SoLuongMua < 0)
                {
                    MessageBox.Show("Số lượng bạn nhập không được âm!");
                }
                //else if (formSoLuongMua.SoLuongMua == 0)
                //{
                //    HoaDonChiTietBUS.XoaHDCT(HDCTXoa);
                //}
                else
                {

                    spDangChon.SoLuong = Convert.ToInt32(spDangChon.SoLuong + hoaDonChiTietTonTai.SoLuong - formSoLuongMua.SoLuongMua);
                    DSSP.UpdateSoLuong(spDangChon);

                    hoaDonChiTietDangUpdate.IdsanPham = IdSanPham;
                    hoaDonChiTietDangUpdate.IdhoaDon = hoaDonDangChon.IdhoaDon;
                    hoaDonChiTietDangUpdate.SoLuong = /*hoaDonChiTietTonTai.SoLuong +*/ formSoLuongMua.SoLuongMua;
                    HoaDonChiTietBUS.UpdateSoLuong(hoaDonChiTietDangUpdate);


                }


                // load lại dữ liệu trên 2 data grid view
                //txt_timkiem.Text = string.Empty;
                LoadData_dgvSanPhamChiTiet();
                LoadData_dgvHoaDonChiTiet(HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(cbx_chonHoaDon1.SelectedValue.ToString()));

            }
        }

        private void cbx_chonHoaDon1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hoaDonDangChon = cbx_chonHoaDon1.SelectedItem as HoaDon;
            if (hoaDonDangChon != null)
            {
                txt_sodienthoai.Text = ThongTinKhachHangBUS.GetTenKHByID(hoaDonDangChon.IdkhachHang).Sdt;
                txt_tenkhachhang.Text = ThongTinKhachHangBUS.GetTenKHByID(hoaDonDangChon.IdkhachHang).Ten;
                //LoadData_dgvHoaDonChiTiet(hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(hoaDonDangChon.MaHoaDon));
                LoadData_dgvHoaDonChiTiet(HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(hoaDonDangChon.IdhoaDon));

            }
        }

        private void btn_thanhToan1_Click(object sender, EventArgs e)
        {
            var x = MessageBox.Show("Xác nhận thanh toán.", "Thanh toán", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                if (cbx_chonHoaDon1.Text != "")
                {
                    if (thanhTien(cbx_chonHoaDon1.SelectedValue.ToString()) > 0)
                    {
                        if (daThanhToanDu)
                        {
                            HoaDonBUS.SuaTrangThai(cbx_chonHoaDon1.SelectedValue.ToString(), 1);
                            MessageBox.Show("Đã thanh toán hóa đơn!");
                            ThanhTien thanhtien = new ThanhTien();
                            thanhtien.IdthanhTien = "TT" + (ThanhTienBUS.GetAllThanhtien().Count + 1);
                            thanhtien.IdhoaDon = cbx_chonHoaDon1.Text;
                            thanhtien.TongHoaDon = TinhTongTienHoaDon(cbx_chonHoaDon1.SelectedValue.ToString());
                            thanhtien.KhuyenMai = khuyenMai(cbx_chonHoaDon1.SelectedValue.ToString());
                            thanhtien.ThanhTien1 = thanhTien(cbx_chonHoaDon1.SelectedValue.ToString());
                            thanhtien.TienKhachDua = Convert.ToDecimal(txt_tienKhachDua1.Text);
                            thanhtien.TienThua = thanhtien.TienKhachDua - thanhtien.ThanhTien1;
                            ThanhTienBUS.TaoThanhTien(thanhtien);
                            idhoaDonIN = cbx_chonHoaDon1.SelectedValue.ToString();

                            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                            printPreviewDialog.Document = printDocument1;
                            printPreviewDialog.ShowDialog();
                            RefreshToanBoForm();

                        }
                        else
                        {
                            MessageBox.Show("Tiền khách đưa chưa đủ!");
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Hóa đơn trống!");
                }


            }

        }
        private void txt_tienKhachDua1_TextChanged(object sender, EventArgs e)
        {
         
            decimal price;
            if (decimal.TryParse(txt_tienKhachDua1.Text.Replace(",", ""), out price))
            {
                txt_tienKhachDua1.Text = price.ToString("N0") ;
                txt_tienKhachDua1.SelectionStart = txt_tienKhachDua1.Text.Length;
            }
            if (txt_tienKhachDua1.Text == "")
            {
                daThanhToanDu = false;
            }
            else {
                decimal tienKhachDua = 0;
                int dem = 0;
                if (cbx_chonHoaDon1.Text != "")
                {
                      foreach (var item in HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(cbx_chonHoaDon1.SelectedValue.ToString()))
                            {
                                if (item.SoLuong != 0)
                                {
                                    dem++;
                                }
                    }
                }
               
                if (cbx_chonHoaDon1.Text == "" || dem == 0)
                {
                    txt_tienKhachDua1.Text = null;
                    MessageBox.Show("Hóa đơn trống");

                }
                else
                {
                    var tongSoTien = thanhTien(cbx_chonHoaDon1.SelectedValue.ToString());
                
                        if (decimal.TryParse(txt_tienKhachDua1.Text, out tienKhachDua))
                        {
                            lbl_tienThua1.Text = (tienKhachDua - tongSoTien).ToString("#,##0 'VND'");
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
            }
           
           
        }

        private void btn_huy1_Click(object sender, EventArgs e)
        {

            if (cbx_chonHoaDon1.Text != "")
            {
                var listHDCT = HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(cbx_chonHoaDon1.SelectedValue.ToString());
                foreach (var hdct in listHDCT)
                {
                    var spct = DSSP.GetSanPhamById(hdct.IdsanPham);
                    // hoàn lại số lượng sản phẩm đã chọn trong hóa đơn vào lại danh sách sản phẩm
                    spct.SoLuong += Convert.ToInt32(hdct.SoLuong);

                    DSSP.UpdateSoLuong(spct);
                }
                ThanhTien thanhtien = new ThanhTien();
                thanhtien.IdthanhTien = "TT" + (ThanhTienBUS.GetAllThanhtien().Count + 1);
                thanhtien.IdhoaDon = cbx_chonHoaDon1.Text;
                thanhtien.TongHoaDon = TinhTongTienHoaDon(cbx_chonHoaDon1.SelectedValue.ToString());
                thanhtien.KhuyenMai = khuyenMai(cbx_chonHoaDon1.SelectedValue.ToString());
                thanhtien.ThanhTien1 = thanhTien(cbx_chonHoaDon1.SelectedValue.ToString());
                thanhtien.TienKhachDua = 0;
                thanhtien.TienThua = 0;
                var x = MessageBox.Show("Xác nhận hủy.", "Hủy", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    ThanhTienBUS.TaoThanhTien(thanhtien);
                    HoaDonBUS.SuaTrangThai(cbx_chonHoaDon1.SelectedValue.ToString(), 2);
               
                MessageBox.Show("Đã hủy hóa đơn!");
                RefreshToanBoForm(); 
                }
            }
            else
            {
                MessageBox.Show("Hóa đơn trống");

            }

        }

        private void cbx_loaiSP_TextChanged(object sender, EventArgs e)
        {
            LoadData_dgvSanPhamChiTiet();
        }
    }
}
