using BUS;



using Data.Data;



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FormQLHoaDon : Form
    {
        HoaDonBUS hoaDonBUS = new HoaDonBUS();

        TQLNhanVienBUS DQLNhanVienBUS = new TQLNhanVienBUS();
        DanhSachSanPhamBUS DSSP = new DanhSachSanPhamBUS();
        ChucVuBUS ChucVuBUS = new ChucVuBUS();
        ThongTinKhachHangBUS ThongTinKhachHangBUS = new ThongTinKhachHangBUS();
        HoaDonBUS HoaDonBUS = new HoaDonBUS();
        HoaDonChiTietBUS HoaDonChiTietBUS = new HoaDonChiTietBUS();
        ThanhTienBUS ThanhTienBUS = new ThanhTienBUS();
        private bool daThanhToanDu = false;
        //string maNhanVien ;

        public FormQLHoaDon()
        {
            InitializeComponent();

            LoadNhanvien();
            LoadTrangThai();
            dateTime_end.Value = DateTime.Now;
            dtgDisplay();
            
        }

        public void dtgDisplay()
        {



            dtg_LichSuHoaDon.ColumnCount = 7;
            dtg_LichSuHoaDon.Columns[0].Name = "STT";
            dtg_LichSuHoaDon.Columns[1].Name = "IDHoaDon";
            dtg_LichSuHoaDon.Columns[2].Name = "TenNhanVien";
            dtg_LichSuHoaDon.Columns[3].Name = "TenKhachHang";
            dtg_LichSuHoaDon.Columns[4].Name = "SDTKhachHang";
            dtg_LichSuHoaDon.Columns[5].Name = "TrangThai";
            dtg_LichSuHoaDon.Columns[6].Name = "NgayMuaHang";
            dtg_LichSuHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //LoadData_LichSuHoaDonByNhanVien(_nhanVien.IdnhanVien);

            dtg_lichSuChiTietHoaDon.ColumnCount = 7;
            dtg_lichSuChiTietHoaDon.Columns[0].Name = "STT";
            dtg_lichSuChiTietHoaDon.Columns[1].Name = "IDSanPham";
            dtg_lichSuChiTietHoaDon.Columns[2].Name = "TenSp";
            dtg_lichSuChiTietHoaDon.Columns[3].Name = "NguonGoc";
            dtg_lichSuChiTietHoaDon.Columns[4].Name = "DonGia";
            dtg_lichSuChiTietHoaDon.Columns[5].Name = "KhuyenMai";
            dtg_lichSuChiTietHoaDon.Columns[6].Name = "SoLuong";
          
            //dtg_lichSuChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtg_lichSuChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_lichSuChiTietHoaDon.Columns[2].FillWeight = 130;
            LoadData_LichSuHoaDon();
            ThoiGian();
        }

        int demso;
        private void LoadData_LichSuHoaDon()
        {
            demso = 1;
            dtg_LichSuHoaDon.Rows.Clear();
            foreach (var item in hoaDonBUS.GetAllHoaDonByAll(txt_timKiem.Text, TrangThaiCBX(), idNhanvien(), txt_khachHang.Text, dateTime_start.Value, dateTime_end.Value).OrderByDescending(h => h.NgayDatHang))
            {
                string TrangThai = "";
                if (item.TrangThaiThanhToan == 0)
                {
                    TrangThai = "Chưa thanh toán";
                }
                if (item.TrangThaiThanhToan == 1)
                {
                    TrangThai = "Đã thanh toán";
                }
                else if (item.TrangThaiThanhToan == 2)
                {
                    TrangThai = "Hủy";
                }
                //if (item.TrangThaiThanhToan == 0)
                //{
                //    continue;
                //}
                if (demso == 1)
                {
                    Load_LS_HoaDon(item.IdhoaDon);
                }

                dtg_LichSuHoaDon.Rows.Add(demso++, item.IdhoaDon, DQLNhanVienBUS.GetnhanvienByID(item.IdnhanVien).TenNhanVien, ThongTinKhachHangBUS.GetTenKHByID(item.IdkhachHang).Ten, ThongTinKhachHangBUS.GetTenKHByID(item.IdkhachHang).Sdt, TrangThai, item.NgayDatHang);

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
                    dtg_lichSuChiTietHoaDon.Rows.Add(i++, item.IdsanPham, DSSP.GetSanPhamById(item.IdsanPham).TenSanPham, DSSP.GetSanPhamById(item.IdsanPham).NguonGoc, Convert.ToDecimal(item.Gia).ToString("#,##0.00 'VND'"), item.KhuyenMai + "%", item.SoLuong);

                }
            }
            var x = ThanhTienBUS.GetThanhtienbyMaHoaDon(idHoaDon);
            if (x != null)
            {
                lbl_LichSuThanhTien.Text = Convert.ToDecimal(x.ThanhTien1).ToString("#,##0.00 'VND'");
                lbl_LichSuKhuyenMai.Text = Convert.ToDecimal(x.KhuyenMai).ToString("#,##0.00 'VND'");
                lbl_LichSuTongHoaDon.Text = Convert.ToDecimal(x.TongHoaDon).ToString("#,##0.00 'VND'");
                lbl_LichSuTienKhachDua.Text = Convert.ToDecimal(x.TienKhachDua).ToString("#,##0.00 'VND'");
                lbl_LichSuTienThua.Text = Convert.ToDecimal(x.TienThua).ToString("#,##0.00 'VND'");

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
            else if (HoaDonBUS.GetHoaDonbyMaHoaDon(idHoaDon).TrangThaiThanhToan == 0)
            {
                txt_daThanhToan.Text = "";
                txt_daHuy.Text = "Chưa thanh toán";
            }
        }
        private void dtg_LichSuHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idwhenclick;
            int i = 1;
            int index = e.RowIndex;
            if (index < 0 || index >= hoaDonBUS.GetAllHoaDonByAll(txt_timKiem.Text, TrangThaiCBX(), idNhanvien(), txt_khachHang.Text, dateTime_start.Value, dateTime_end.Value).OrderByDescending(h => h.NgayDatHang).Count())
            {
                return;
            }
            dtg_lichSuChiTietHoaDon.Rows.Clear();
            idwhenclick = dtg_LichSuHoaDon.Rows[index].Cells[1].Value.ToString();
            foreach (var item in HoaDonChiTietBUS.GetAllHoaDonCTByMaHoaDon(idwhenclick))
            {
                if (item.SoLuong != 0)
                {
                    dtg_lichSuChiTietHoaDon.Rows.Add(i++, item.IdsanPham, DSSP.GetSanPhamById(item.IdsanPham).TenSanPham, DSSP.GetSanPhamById(item.IdsanPham).NguonGoc, Convert.ToDecimal(item.Gia).ToString("#,##0.00 'VND'"), item.KhuyenMai + "%", item.SoLuong);
                    
                }
            }
            var x = ThanhTienBUS.GetThanhtienbyMaHoaDon(idwhenclick);
            if (x != null)
            {
                lbl_LichSuThanhTien.Text = Convert.ToDecimal(x.ThanhTien1).ToString("#,##0.00 'VND'");
                lbl_LichSuKhuyenMai.Text = Convert.ToDecimal(x.KhuyenMai).ToString("#,##0.00 'VND'");
                lbl_LichSuTongHoaDon.Text = Convert.ToDecimal(x.TongHoaDon).ToString("#,##0.00 'VND'");
                lbl_LichSuTienKhachDua.Text = Convert.ToDecimal(x.TienKhachDua).ToString("#,##0.00 'VND'");
                lbl_LichSuTienThua.Text = Convert.ToDecimal(x.TienThua).ToString("#,##0.00 'VND'");

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
            else if (HoaDonBUS.GetHoaDonbyMaHoaDon(idwhenclick).TrangThaiThanhToan == 0)
            {
                txt_daThanhToan.Text = "";
                txt_daHuy.Text = "Chưa thanh toán";
            }

        }


        public void LoadNhanvien()
        {
            //foreach (var item in DQLNhanVienBUS.Getallnhanvien())
            //{
            //    cbx_nhanVien.Items.Add(item.IdnhanVien+"-"+item.TenNhanVien);
            //}
            var dsnhanvien = DQLNhanVienBUS.Getallnhanvien().ToList();
            dsnhanvien.Insert(0, new NhanVien { IdnhanVien = "All", TenNhanVien = "Tất cả nhân viên" });
            cbx_nhanVien.DataSource = dsnhanvien; // Gọi hàm lấy danh sách nhân viên từ database
            cbx_nhanVien.DisplayMember = "TenNhanVien"; // Hiển thị tên nhân viên
            cbx_nhanVien.ValueMember = "IdnhanVien"; // Lưu trữ ID nhân viên
                                                     



        }

        public string idNhanvien()
        {
            return cbx_nhanVien.SelectedValue.ToString();
           
        }
        public void LoadTrangThai()
        {

            cbx_trangThai.SelectedIndex = 0;

        }

        private void cbx_nhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedEmployeeID = (string)cbx_nhanVien.SelectedValue;
            dtgDisplay();
        }

        //public string IDNhanVien()
        //{


        //}
        public int TrangThaiCBX()
        {
            int giatri;
            if (cbx_trangThai.Text == "Tất cả")
            {
                return giatri = 3;
            }
            else if (cbx_trangThai.Text == "Đã thanh toán")
            {
                return giatri = 1;
            }
            else
            {
                return giatri = 2;
            }
        }

        private void cbx_trangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgDisplay();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            dtgDisplay();

        }

        private void txt_khachHang_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_khachHang_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (txt_khachHang.Text != "")
                {
                    var khachHang = ThongTinKhachHangBUS.GetTenKHBySdt(txt_khachHang.Text);
                    if (khachHang == null)
                    {
                        MessageBox.Show("SĐT khách hàng không hợp lệ!");
                    }
                    else
                    {
                        dtgDisplay();
                    }
                }
                else
                {
                    dtgDisplay();
                }

            }

        }

        private void dateTime_end_ValueChanged(object sender, EventArgs e)
        {
            dtgDisplay();
        }

        private void dateTime_start_ValueChanged(object sender, EventArgs e)
        {
            dtgDisplay();
        }
        public void ThoiGian()
        {
            if (dateTime_start.Value > dateTime_end.Value)
            {
                MessageBox.Show("Thời gian bắt đầu nhỏ hơn thời gian kết thúc", "Thời gian");
            }
        }

        private void cbx_nhanVien_Format(object sender, ListControlConvertEventArgs e)
        {
            dynamic nhanVien = e.ListItem;
            e.Value = $"{nhanVien.IdnhanVien} - {nhanVien.TenNhanVien}";
        }
    }
}
