﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BUS;

using Microsoft.EntityFrameworkCore;
using System.Security;
using Microsoft.Identity.Client;


using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Data.Data;

using System.Security.Cryptography;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;



namespace GUI
{

    public partial class FormSanPham : Form

    {
        LSanPhamBLL sanPhamBLL = new LSanPhamBLL();
        LLoaiSanPhamBLL lspBLL = new LLoaiSanPhamBLL();
        CsdlDuAn1Context context = new CsdlDuAn1Context();
        private string _idCellClickSanPham;
        private string _idCellClickLoaiSanPham;




        public FormSanPham()
        {
            InitializeComponent();

        }


        public void FormSanPham_Load(object sender, EventArgs e)
        {

        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = e.RowIndex;
            if (row < 0 || row >= sanPhamBLL.GetAllSP().Count()) return;
            _idCellClickSanPham = Convert.ToString(dgvSanPham.Rows[row].Cells[0].Value);
            var obj = sanPhamBLL.GetById(_idCellClickSanPham);
            if (obj != null)
            {
                
                //cbbLoaiSP.SelectedIndex = _lstSanPHam.FindIndex(x => x == obj.IdloaiSanPham);
                cbbLoaiSP.Text = lspBLL.Getbyid(obj.IdloaiSanPham).LoaiSanPham1;
                txtTenSanPham.Text = obj.TenSanPham;
                txtSoLuong1.Text = Convert.ToString(obj.SoLuong);
               
                txtGiaNhap.Text = Convert.ToDecimal(obj.GiaNhap).ToString("#,##0 'VND'");
                txtKhoiLuong.Text = Convert.ToString(obj.KhoiLuong);
                txtNguonGoc.Text = obj.NguonGoc;
                datetimeHsd.Text = Convert.ToString(obj.HanSuDung);
                txtSPF.Text = obj.ChiSoSpf;
                txtFA.Text = obj.ChiSoFa;
              
                txtGiaBan.Text = Convert.ToDecimal(obj.GiaBan).ToString("#,##0 'VND'");
                if (obj.TrangThai == true)
                {
                    rdoConBan.Checked = true;
                }
                else
                {
                    rdoNgungBan.Checked = true;
                }
            }
        }
        List<string> _lstSanPHam = new List<string>();

        private void FormSanPham_Load_1(object sender, EventArgs e)
        {

        }
        private void FormSanPham_Load_2(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormSanPham_Load_3(object sender, EventArgs e)
        {
            ShowDS(dgvSanPham, null);
            LoadLoaiSP(dgvLoaiSP);
            dgvLoaiSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void Load1()
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void loadhu()
        {

        }
        private void btnAddSp_Click(object sender, EventArgs e)
        {

            bool TrangThai = false;
            if (rdoConBan.Checked == true)
            {
                TrangThai = true;
            }
            else { TrangThai = false; }

            string IdLoaiSanPham = "";
            if (cbbLoaiSP.Text == "Cơ Thể")
            {
                IdLoaiSanPham = "LSP001";
            }
            else if (cbbLoaiSP.Text == "Măt")
            {
                IdLoaiSanPham = "LSP002";
            }
            SanPham sanPham = new SanPham()
            {
                IdsanPham = "SP" + (sanPhamBLL.GetAllSP().Count + 1),
                IdloaiSanPham = IdLoaiSanPham,
                TenSanPham = txtTenSanPham.Text,
                SoLuong = Convert.ToInt32(txtSoLuong1.Text),
                GiaNhap = Convert.ToInt32(txtGiaNhap.Text),
                KhoiLuong = Convert.ToDouble(txtKhoiLuong.Text),
                NguonGoc = txtNguonGoc.Text,
                HanSuDung = DateOnly.FromDateTime(datetimeHsd.Value),
                ChiSoSpf = txtSPF.Text,
                ChiSoFa = txtFA.Text,

                TrangThai = TrangThai,
            };
          
            if (sanPhamBLL.CreateSanPham(sanPham))
            {
                MessageBox.Show("Thêm sản phẩm thành công");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }
            ShowDS(dgvSanPham, null);

        }

        private void btnUpdateSp_Click(object sender, EventArgs e)
        {
            int soLuong;
            decimal giaNhap, giaBan;
            double khoiLuong;
           
            bool isNumber = int.TryParse(txtSoLuong1.Text, out soLuong);

            bool TrangThai = false;
            if (rdoConBan.Checked)
            {
                TrangThai = true;
            }
            else if (rdoNgungBan.Checked)
            {
                TrangThai = false;
            }
            if (!isNumber)
            {
                MessageBox.Show("vui lòng nhập đúng số lượng");
            }else if (Convert.ToInt32(txtSoLuong1.Text) < 0)
            {
                MessageBox.Show("vui lòng nhập đúng số lượng");

            }
            if (!decimal.TryParse(txtGiaNhap.Text, out giaNhap))
            {
                MessageBox.Show("Giá nhập phải là số.");
                return;
            }

            if (!decimal.TryParse(txtGiaBan.Text, out giaBan))
            {
                MessageBox.Show("Giá bán phải là số.");
                return;
            }

            if (!double.TryParse(txtKhoiLuong.Text, out khoiLuong))
            {
                MessageBox.Show("Khối lượng phải là số.");
                return;
            }
            if (!decimal.TryParse(txtSPF.Text, out decimal spf) || spf < 30 || spf > 60)
            {
                MessageBox.Show("Chỉ số SPF phải là số nguyên từ 30 đến 60.");
                return;
            }

            if (!decimal.TryParse(txtFA.Text, out decimal fa) || fa < 8 || fa > 30)
            {
                MessageBox.Show("Chỉ số FA phải là số nguyên từ 8 đến 30.");
                return;
            }
            if ( datetimeHsd.Value > DateTime.Now)
            {
                MessageBox.Show("Hạn sử dụng không hợp lệ.");
                return;
            }


            else
            {
                var updateSP = sanPhamBLL.GetAllSP().Find(x => x.IdsanPham == _idCellClickSanPham);
                updateSP.TenSanPham = txtTenSanPham.Text;
                updateSP.NguonGoc = txtNguonGoc.Text;
                updateSP.SoLuong = Convert.ToInt32(txtSoLuong1.Text);
                updateSP.GiaNhap = Convert.ToDecimal(txtGiaNhap.Text);
                updateSP.KhoiLuong = Convert.ToDouble(txtKhoiLuong.Text);
                updateSP.HanSuDung = DateOnly.FromDateTime(datetimeHsd.Value);
                updateSP.ChiSoFa = txtFA.Text;
                updateSP.ChiSoSpf = txtSPF.Text;
                updateSP.GiaBan = Convert.ToDecimal(txtGiaBan.Text);
                updateSP.IdloaiSanPham = cbbLoaiSP.SelectedValue.ToString();
                updateSP.TrangThai = TrangThai;


                var chon = MessageBox.Show("Bạn có muốn sửa không?", "Sửa thành công", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    MessageBox.Show(sanPhamBLL.SuaSP(updateSP));
                }

                ShowDS(dgvSanPham, null);

            }

        }

        private void btnClearSp_Click(object sender, EventArgs e)
        {


            txtTenSanPham.Clear();
            txtSoLuong1.Clear();
            txtGiaNhap.Clear();
            txtKhoiLuong.Clear();
            txtNguonGoc.Clear();
            txtSPF.Clear();
            txtFA.Clear();
            txtGiaBan.Clear();
            rdoNgungBan.Checked = false;
            rdoConBan.Checked = false;



        }

        private void txtTimKiemSp_TextChanged(object sender, EventArgs e)
        {
            string timKiem = this.txtTimKiemSp.Text;
            ShowDS(dgvSanPham, timKiem);
        }


        public void ShowDS(DataGridView dgvSanPham, string input)
        {

            dgvSanPham.ColumnCount = 12;
            dgvSanPham.Columns[0].Name = "IdSanPham";
            dgvSanPham.Columns[1].Name = "TenSanPham";
            dgvSanPham.Columns[2].Name = "SoLuong";
            dgvSanPham.Columns[3].Name = "GiaNhap";
            dgvSanPham.Columns[4].Name = "LoaiSanPham";
            dgvSanPham.Columns[5].Name = "KhoiLuong";
            dgvSanPham.Columns[6].Name = "NguonGoc";
            dgvSanPham.Columns[7].Name = "HanSuDung";
            dgvSanPham.Columns[8].Name = "ChiSoSpf";
            dgvSanPham.Columns[9].Name = "ChiSoFa";
            dgvSanPham.Columns[10].Name = "GiaBan";
            dgvSanPham.Columns[11].Name = "TrangThai";

            dgvSanPham.Rows.Clear();
            var dssp = lspBLL.Getallloaisp().ToList();
            cbbLoaiSP.DataSource = dssp;
            cbbLoaiSP.DisplayMember = "LoaiSanPham1";
            cbbLoaiSP.ValueMember = "IdloaiSanPham";

            foreach (var item in sanPhamBLL.GetAllSanPham(/*txtTimKiemSp.Text*/ input))
            {

                string TrangThai;
                if (item.TrangThai == true)
                {
                    TrangThai = "Còn Bán";
                }
                else
                {
                    TrangThai = "Ngừng Bán";
                }
                var loaiSanPham = "";
                if (lspBLL.Getbyid(item.IdloaiSanPham) != null)
                {
                    loaiSanPham = lspBLL.Getbyid(item.IdloaiSanPham).LoaiSanPham1;
                }

                else
                {
                    loaiSanPham = "";
                }


                dgvSanPham.Rows.Add(item.IdsanPham, item.TenSanPham, item.SoLuong, Convert.ToDecimal(item.GiaNhap).ToString("#,##0 'VND'"), loaiSanPham,
                    item.KhoiLuong, item.NguonGoc, item.HanSuDung, item.ChiSoSpf, item.ChiSoFa,Convert.ToDecimal( item.GiaBan).ToString("#,##0 'VND'"), TrangThai);
            }

            //Convert.ToDecimal(item.Gia).ToString("#,##0 'VND'")


        }

        public void LoadLoaiSP(DataGridView dgvLoadLSP)
        {
            dgvLoadLSP.ColumnCount = 4;
            int stt = 1;

            dgvLoadLSP.Columns[0].Name = "STT";
            dgvLoadLSP.Columns[1].Name = "ID Loại Sản Phẩm";
            dgvLoadLSP.Columns[2].Name = "Id Khuyến Mãi";
            dgvLoadLSP.Columns[3].Name = "Loại Sản Phẩm";
            dgvLoadLSP.Rows.Clear();



            List<KhuyenMai> khuyenMaiDangHoatDong = new List<KhuyenMai>();
            foreach (var km in sanPhamBLL.GetAllKhuyenMai())
            {
                if ((bool)km.TrangThai)
                {
                    khuyenMaiDangHoatDong.Add(km);
                }
            }

            foreach (var item in lspBLL.Getallloaisp())
            {
                dgvLoaiSP.Rows.Add(stt++, item.IdloaiSanPham, item.IdkhuyenMai, item.LoaiSanPham1);
            }


            // Lấy danh sách các Khuyến Mãi đang hoạt động
       
            //var dslsp = sanPhamBLL.GetAllKhuyenMai().ToList();
         
            // Add a default option with null value
           
            khuyenMaiDangHoatDong.Insert(0, new KhuyenMai { IdkhuyenMai = null });
            cbbIdKm.DataSource = khuyenMaiDangHoatDong;
            cbbIdKm.DisplayMember = "IdkhuyenMai";
            cbbIdKm.ValueMember = "IdkhuyenMai";


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSp_Click_1(object sender, EventArgs e)
        {

            bool TrangThai = false;
            if (rdoConBan.Checked == true)
            {
                TrangThai = true;
            }
            else if (rdoNgungBan.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn trạng thái sản phẩm (Còn bán hoặc Ngừng bán).");
                return;
            }

            int soLuong;
            decimal giaNhap, giaBan;
            double khoiLuong;

            // Validate input data types
            if (!int.TryParse(txtSoLuong1.Text, out soLuong))
            {
                MessageBox.Show("Số lượng phải là số nguyên.");
                return;
            }

            if (soLuong < 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.");
                return;
            }

            if (!decimal.TryParse(txtGiaNhap.Text, out giaNhap))
            {
                MessageBox.Show("Giá nhập phải là số.");
                return;
            }

            if (!decimal.TryParse(txtGiaBan.Text, out giaBan))
            {
                MessageBox.Show("Giá bán phải là số.");
                return;
            }

            if (!double.TryParse(txtKhoiLuong.Text, out khoiLuong))
            {
                MessageBox.Show("Khối lượng phải là số.");
                return;
            }
            if (!decimal.TryParse(txtSPF.Text, out decimal spf) || spf < 30 || spf > 60)
            {
                MessageBox.Show("Chỉ số SPF phải là số nguyên từ 30 đến 60.");
                return;
            }

            if (!decimal.TryParse(txtFA.Text, out decimal fa) || fa < 8 || fa > 30)
            {
                MessageBox.Show("Chỉ số FA phải là số nguyên từ 8 đến 30.");
                return;
            }
            if ( datetimeHsd.Value < DateTime.Now)
            {
                MessageBox.Show("Hạn sử dụng không hợp lệ.");
                return;
            }

            // Check for empty fields
            if (string.IsNullOrEmpty(cbbLoaiSP.Text) || string.IsNullOrEmpty(txtTenSanPham.Text) || soLuong <= 0 ||
                giaNhap <= 0 || khoiLuong <= 0 || string.IsNullOrEmpty(txtNguonGoc.Text) ||
                string.IsNullOrEmpty(txtSPF.Text) || string.IsNullOrEmpty(txtFA.Text) || giaBan <= 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            SanPham sanPham = new SanPham()
            {
                IdsanPham = "SP" + (sanPhamBLL.GetAllSP().Count + 1),
                IdloaiSanPham = cbbLoaiSP.SelectedValue.ToString(),
                TenSanPham = txtTenSanPham.Text,
                SoLuong = soLuong,
                GiaNhap = giaNhap,
                KhoiLuong = khoiLuong,
                NguonGoc = txtNguonGoc.Text,
                HanSuDung = DateOnly.FromDateTime(datetimeHsd.Value),
                ChiSoSpf = txtSPF.Text,
                ChiSoFa = txtFA.Text,
                GiaBan = giaBan,
                TrangThai = TrangThai,
            };

            if (sanPhamBLL.CreateSanPham(sanPham))
            {
                MessageBox.Show("Thêm sản phẩm thành công");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }

            ShowDS(dgvSanPham, null);
        }

        private void btnQLLSP_Click(object sender, EventArgs e)
        {


        }




        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex < 0 || rowindex >= lspBLL.Getallloaisp().Count) return;
            _idCellClickLoaiSanPham = Convert.ToString(dgvLoaiSP.Rows[rowindex].Cells[1].Value);
            var obj = lspBLL.Getbyid(_idCellClickLoaiSanPham);
            if (obj != null)
            {
         
                cbbIdKm.Text = obj.IdkhuyenMai;
                txtLsp.Text = obj.LoaiSanPham1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
          


            LoaiSanPham lsp = new LoaiSanPham();

            lsp.IdloaiSanPham = "LSP" + (lspBLL.Getallloaisp().Count + 1);
            bool X;

            if (cbbIdKm.SelectedValue == null)
            {
                lsp.IdkhuyenMai = null;
            }
            else
            {
                lsp.IdkhuyenMai = cbbIdKm.SelectedValue.ToString();

            }
            lsp.LoaiSanPham1 = txtLsp.Text;

            lspBLL.createLSP(lsp);
            Console.WriteLine("Them loai san pham thanh cong");


            LoadLoaiSP(dgvLoaiSP);
            ShowDS(dgvSanPham, null);


        }

        private void txtTimKiemNgGoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var updateLoaiSP = lspBLL.Getallloaisp().Find(x => x.IdloaiSanPham == _idCellClickLoaiSanPham);
            updateLoaiSP.LoaiSanPham1 = txtLsp.Text;
            updateLoaiSP.IdkhuyenMai= cbbIdKm.Text;
            
            LoadLoaiSP(dgvLoaiSP);          
            ShowDS(dgvSanPham, null);


            var chon = MessageBox.Show("Bạn có muốn sửa không?", "Cập nhật thông tin loại sản phẩm", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                MessageBox.Show(lspBLL.SuaLSP(updateLoaiSP));
            }

            //DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Cập nhật thông tin loại sản phẩm", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    string updateResult = lspBLL.Update(IdLoaiSanPham, idKhuyenMai, loaiSanPham);

            //    MessageBox.Show(updateResult, "Thông báo cập nhật", MessageBoxButtons.OK);
            //}
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool trangThai = cbbTrangThai.SelectedItem.ToString() == "Còn Bán";
            List<SanPham> sanPhams = sanPhamBLL.LocTrangThai(trangThai);
            LoadGrid2(dgvSanPham, sanPhams);


        }
        public void LoadGrid2(DataGridView dataGridView, List<SanPham> sanPhams)
        {
            int stt = 1;
            dataGridView.ColumnCount = 13;

            dataGridView.Columns[0].Name = "STT";
            dataGridView.Columns[1].Name = "ID sản phẩm";
            dataGridView.Columns[2].Name = "Ten san pham";
            dataGridView.Columns[3].Name = "So luong";
            dataGridView.Columns[4].Name = "Gia Nhap";
            dataGridView.Columns[5].Name = "Loai san pham";
            dataGridView.Columns[6].Name = "Khoi luong";
            dataGridView.Columns[7].Name = "Nguon goc";
            dataGridView.Columns[8].Name = "Han su dung";
            dataGridView.Columns[9].Name = "ChiSoSpf";
            dataGridView.Columns[10].Name = "Chi So Fa";
            dataGridView.Columns[11].Name = "Gia Ban";
            dataGridView.Columns[12].Name = "Trang Thai";



            dataGridView.Rows.Clear();

            foreach (var item in sanPhams)
            {

                string trangthai = item.TrangThai == true ? "Còn Bán" : "Ngừng Bán";

                var LoaiSanPham = lspBLL.Getbyid(item.IdloaiSanPham).LoaiSanPham1;

                dataGridView.Rows.Add(stt++, item.IdsanPham, item.TenSanPham, item.SoLuong, Convert.ToDecimal(item.GiaNhap).ToString("#,##0 'VND'"), LoaiSanPham, item.KhoiLuong, item.NguonGoc, item.HanSuDung, item.ChiSoSpf, item.ChiSoFa, Convert.ToDecimal(item.GiaBan).ToString("#,##0 'VND'"), trangthai);
            }
        }
        private void cbbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


