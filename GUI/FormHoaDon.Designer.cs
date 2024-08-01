﻿namespace GUI
{
    partial class FormHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            lbl_tenNhanVien = new Label();
            lbl_chucVu = new Label();
            groupBox1 = new GroupBox();
            btn_taohoadon = new Button();
            txt_tenkhachhang = new TextBox();
            txt_sodienthoai = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label12 = new Label();
            lbl_thanhtien = new Label();
            label10 = new Label();
            label2 = new Label();
            lbl_khuyenMai = new Label();
            label1 = new Label();
            btn_huy = new Button();
            btn_thanhToan = new Button();
            lb_tienThua = new Label();
            txt_tinKhachDua = new TextBox();
            label9 = new Label();
            label8 = new Label();
            lbl_giaTriHoaDon = new Label();
            label6 = new Label();
            dtgview_thongTinHoaDon = new DataGridView();
            cbx_chonHoaDon = new ComboBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label11 = new Label();
            txt_timkiem = new TextBox();
            dtgview_danhSachSP = new DataGridView();
            groupBox4 = new GroupBox();
            groupBox7 = new GroupBox();
            txt_daHuy = new Label();
            txt_daThanhToan = new Label();
            lbl_LichSuTienThua = new Label();
            lbl_LichSuTienKhachDua = new Label();
            lbl_LichSuThanhTien = new Label();
            lbl_LichSuKhuyenMai = new Label();
            lbl_LichSuTongHoaDon = new Label();
            label19 = new Label();
            label18 = new Label();
            label13 = new Label();
            label15 = new Label();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            groupBox6 = new GroupBox();
            dtg_lichSuChiTietHoaDon = new DataGridView();
            groupBox5 = new GroupBox();
            dtg_LichSuHoaDon = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgview_thongTinHoaDon).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgview_danhSachSP).BeginInit();
            groupBox4.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_lichSuChiTietHoaDon).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_LichSuHoaDon).BeginInit();
            SuspendLayout();
            // 
            // lbl_tenNhanVien
            // 
            lbl_tenNhanVien.AutoSize = true;
            lbl_tenNhanVien.BackColor = Color.Transparent;
            lbl_tenNhanVien.Location = new Point(31, 18);
            lbl_tenNhanVien.Name = "lbl_tenNhanVien";
            lbl_tenNhanVien.Size = new Size(165, 32);
            lbl_tenNhanVien.TabIndex = 0;
            lbl_tenNhanVien.Text = "Tên nhân viên";
            // 
            // lbl_chucVu
            // 
            lbl_chucVu.AutoSize = true;
            lbl_chucVu.BackColor = Color.Transparent;
            lbl_chucVu.Location = new Point(31, 76);
            lbl_chucVu.Name = "lbl_chucVu";
            lbl_chucVu.Size = new Size(101, 32);
            lbl_chucVu.TabIndex = 1;
            lbl_chucVu.Text = "Chức vụ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(238, 241, 255);
            groupBox1.Controls.Add(btn_taohoadon);
            groupBox1.Controls.Add(txt_tenkhachhang);
            groupBox1.Controls.Add(txt_sodienthoai);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.DarkSlateBlue;
            groupBox1.Location = new Point(33, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 788);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btn_taohoadon
            // 
            btn_taohoadon.Location = new Point(19, 288);
            btn_taohoadon.Name = "btn_taohoadon";
            btn_taohoadon.Size = new Size(183, 46);
            btn_taohoadon.TabIndex = 4;
            btn_taohoadon.Text = "Tạo hóa đơn";
            btn_taohoadon.UseVisualStyleBackColor = true;
            btn_taohoadon.Click += btn_taohoadon_Click;
            // 
            // txt_tenkhachhang
            // 
            txt_tenkhachhang.BackColor = SystemColors.ActiveBorder;
            txt_tenkhachhang.Location = new Point(19, 217);
            txt_tenkhachhang.Name = "txt_tenkhachhang";
            txt_tenkhachhang.ReadOnly = true;
            txt_tenkhachhang.Size = new Size(304, 39);
            txt_tenkhachhang.TabIndex = 3;
            // 
            // txt_sodienthoai
            // 
            txt_sodienthoai.Location = new Point(19, 113);
            txt_sodienthoai.Name = "txt_sodienthoai";
            txt_sodienthoai.Size = new Size(304, 39);
            txt_sodienthoai.TabIndex = 2;
            txt_sodienthoai.KeyDown += txt_sodienthoai_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 171);
            label4.Name = "label4";
            label4.Size = new Size(183, 32);
            label4.TabIndex = 1;
            label4.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 67);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 0;
            label3.Text = "Số điện thoại";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(238, 241, 255);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(lbl_thanhtien);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(lbl_khuyenMai);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btn_huy);
            groupBox2.Controls.Add(btn_thanhToan);
            groupBox2.Controls.Add(lb_tienThua);
            groupBox2.Controls.Add(txt_tinKhachDua);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(lbl_giaTriHoaDon);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dtgview_thongTinHoaDon);
            groupBox2.Controls.Add(cbx_chonHoaDon);
            groupBox2.Controls.Add(label5);
            groupBox2.ForeColor = Color.DarkSlateBlue;
            groupBox2.Location = new Point(418, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(964, 788);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hóa đơn";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 578);
            label12.Name = "label12";
            label12.Size = new Size(584, 32);
            label12.TabIndex = 21;
            label12.Text = "---------------------------------------------------------";
            // 
            // lbl_thanhtien
            // 
            lbl_thanhtien.AutoSize = true;
            lbl_thanhtien.Location = new Point(309, 607);
            lbl_thanhtien.Name = "lbl_thanhtien";
            lbl_thanhtien.Size = new Size(27, 32);
            lbl_thanhtien.TabIndex = 20;
            lbl_thanhtien.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 607);
            label10.Name = "label10";
            label10.Size = new Size(129, 32);
            label10.TabIndex = 19;
            label10.Text = "Thành tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(539, 647);
            label2.Name = "label2";
            label2.Size = new Size(64, 32);
            label2.TabIndex = 18;
            label2.Text = "VND";
            label2.Click += label2_Click;
            // 
            // lbl_khuyenMai
            // 
            lbl_khuyenMai.AutoSize = true;
            lbl_khuyenMai.Location = new Point(309, 545);
            lbl_khuyenMai.Name = "lbl_khuyenMai";
            lbl_khuyenMai.Size = new Size(27, 32);
            lbl_khuyenMai.TabIndex = 17;
            lbl_khuyenMai.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 545);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 16;
            label1.Text = "Khuyến mại";
            // 
            // btn_huy
            // 
            btn_huy.Location = new Point(779, 644);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(153, 46);
            btn_huy.TabIndex = 15;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = true;
            btn_huy.Click += btn_huy_Click;
            // 
            // btn_thanhToan
            // 
            btn_thanhToan.Location = new Point(779, 578);
            btn_thanhToan.Name = "btn_thanhToan";
            btn_thanhToan.Size = new Size(153, 46);
            btn_thanhToan.TabIndex = 14;
            btn_thanhToan.Text = "Thanh toán";
            btn_thanhToan.UseVisualStyleBackColor = true;
            btn_thanhToan.Click += btn_thanhToan_Click;
            // 
            // lb_tienThua
            // 
            lb_tienThua.AutoSize = true;
            lb_tienThua.Location = new Point(309, 701);
            lb_tienThua.Name = "lb_tienThua";
            lb_tienThua.Size = new Size(27, 32);
            lb_tienThua.TabIndex = 13;
            lb_tienThua.Text = "0";
            // 
            // txt_tinKhachDua
            // 
            txt_tinKhachDua.Location = new Point(309, 644);
            txt_tinKhachDua.Name = "txt_tinKhachDua";
            txt_tinKhachDua.Size = new Size(200, 39);
            txt_tinKhachDua.TabIndex = 12;
            txt_tinKhachDua.TextChanged += txt_tinKhachDua_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 694);
            label9.Name = "label9";
            label9.Size = new Size(115, 32);
            label9.TabIndex = 11;
            label9.Text = "Tiền thừa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 651);
            label8.Name = "label8";
            label8.Size = new Size(177, 32);
            label8.TabIndex = 10;
            label8.Text = "Tiền khách đưa";
            // 
            // lbl_giaTriHoaDon
            // 
            lbl_giaTriHoaDon.AutoSize = true;
            lbl_giaTriHoaDon.Location = new Point(309, 504);
            lbl_giaTriHoaDon.Name = "lbl_giaTriHoaDon";
            lbl_giaTriHoaDon.Size = new Size(27, 32);
            lbl_giaTriHoaDon.TabIndex = 9;
            lbl_giaTriHoaDon.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 504);
            label6.Name = "label6";
            label6.Size = new Size(165, 32);
            label6.TabIndex = 8;
            label6.Text = "Tổng hóa đơn";
            // 
            // dtgview_thongTinHoaDon
            // 
            dtgview_thongTinHoaDon.BackgroundColor = SystemColors.InactiveBorder;
            dtgview_thongTinHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgview_thongTinHoaDon.Location = new Point(28, 113);
            dtgview_thongTinHoaDon.Name = "dtgview_thongTinHoaDon";
            dtgview_thongTinHoaDon.RowHeadersWidth = 82;
            dtgview_thongTinHoaDon.Size = new Size(904, 361);
            dtgview_thongTinHoaDon.TabIndex = 7;
            dtgview_thongTinHoaDon.CellDoubleClick += dtgview_thongTinHoaDon_CellDoubleClick;
            // 
            // cbx_chonHoaDon
            // 
            cbx_chonHoaDon.FormattingEnabled = true;
            cbx_chonHoaDon.Location = new Point(213, 51);
            cbx_chonHoaDon.Name = "cbx_chonHoaDon";
            cbx_chonHoaDon.Size = new Size(242, 40);
            cbx_chonHoaDon.TabIndex = 6;
            cbx_chonHoaDon.SelectedIndexChanged += cbx_chonHoaDon_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 51);
            label5.Name = "label5";
            label5.Size = new Size(167, 32);
            label5.TabIndex = 0;
            label5.Text = "Chọn hóa đơn";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(238, 241, 255);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txt_timkiem);
            groupBox3.Controls.Add(dtgview_danhSachSP);
            groupBox3.ForeColor = Color.DarkSlateBlue;
            groupBox3.Location = new Point(1415, 140);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1027, 788);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 41);
            label11.Name = "label11";
            label11.Size = new Size(113, 32);
            label11.TabIndex = 9;
            label11.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(169, 38);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(512, 39);
            txt_timkiem.TabIndex = 8;
            txt_timkiem.TextChanged += textBox4_TextChanged;
            // 
            // dtgview_danhSachSP
            // 
            dtgview_danhSachSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgview_danhSachSP.BackgroundColor = SystemColors.InactiveBorder;
            dtgview_danhSachSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgview_danhSachSP.Location = new Point(30, 97);
            dtgview_danhSachSP.Name = "dtgview_danhSachSP";
            dtgview_danhSachSP.RowHeadersWidth = 82;
            dtgview_danhSachSP.Size = new Size(968, 636);
            dtgview_danhSachSP.TabIndex = 7;
            dtgview_danhSachSP.CellDoubleClick += dtgview_danhSachSP_CellDoubleClick;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(238, 241, 255);
            groupBox4.Controls.Add(groupBox7);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(33, 966);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(2409, 557);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Lịch sử hóa đơn";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txt_daHuy);
            groupBox7.Controls.Add(txt_daThanhToan);
            groupBox7.Controls.Add(lbl_LichSuTienThua);
            groupBox7.Controls.Add(lbl_LichSuTienKhachDua);
            groupBox7.Controls.Add(lbl_LichSuThanhTien);
            groupBox7.Controls.Add(lbl_LichSuKhuyenMai);
            groupBox7.Controls.Add(lbl_LichSuTongHoaDon);
            groupBox7.Controls.Add(label19);
            groupBox7.Controls.Add(label18);
            groupBox7.Controls.Add(label13);
            groupBox7.Controls.Add(label15);
            groupBox7.Controls.Add(label14);
            groupBox7.Controls.Add(label16);
            groupBox7.Controls.Add(label17);
            groupBox7.Location = new Point(1954, 61);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(426, 471);
            groupBox7.TabIndex = 8;
            groupBox7.TabStop = false;
            groupBox7.Text = "Thành tiền";
            // 
            // txt_daHuy
            // 
            txt_daHuy.AutoSize = true;
            txt_daHuy.Font = new Font("Arial Narrow", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_daHuy.ForeColor = Color.Red;
            txt_daHuy.Location = new Point(131, 355);
            txt_daHuy.Name = "txt_daHuy";
            txt_daHuy.Size = new Size(189, 43);
            txt_daHuy.TabIndex = 29;
            txt_daHuy.Text = "Trạng Thái ";
            // 
            // txt_daThanhToan
            // 
            txt_daThanhToan.AutoSize = true;
            txt_daThanhToan.Font = new Font("Arial Narrow", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_daThanhToan.ForeColor = Color.Blue;
            txt_daThanhToan.Location = new Point(109, 355);
            txt_daThanhToan.Name = "txt_daThanhToan";
            txt_daThanhToan.Size = new Size(0, 43);
            txt_daThanhToan.TabIndex = 28;
            // 
            // lbl_LichSuTienThua
            // 
            lbl_LichSuTienThua.AutoSize = true;
            lbl_LichSuTienThua.Location = new Point(233, 246);
            lbl_LichSuTienThua.Name = "lbl_LichSuTienThua";
            lbl_LichSuTienThua.Size = new Size(27, 32);
            lbl_LichSuTienThua.TabIndex = 27;
            lbl_LichSuTienThua.Text = "0";
            // 
            // lbl_LichSuTienKhachDua
            // 
            lbl_LichSuTienKhachDua.AutoSize = true;
            lbl_LichSuTienKhachDua.Location = new Point(233, 203);
            lbl_LichSuTienKhachDua.Name = "lbl_LichSuTienKhachDua";
            lbl_LichSuTienKhachDua.Size = new Size(27, 32);
            lbl_LichSuTienKhachDua.TabIndex = 26;
            lbl_LichSuTienKhachDua.Text = "0";
            // 
            // lbl_LichSuThanhTien
            // 
            lbl_LichSuThanhTien.AutoSize = true;
            lbl_LichSuThanhTien.Location = new Point(233, 159);
            lbl_LichSuThanhTien.Name = "lbl_LichSuThanhTien";
            lbl_LichSuThanhTien.Size = new Size(27, 32);
            lbl_LichSuThanhTien.TabIndex = 25;
            lbl_LichSuThanhTien.Text = "0";
            // 
            // lbl_LichSuKhuyenMai
            // 
            lbl_LichSuKhuyenMai.AutoSize = true;
            lbl_LichSuKhuyenMai.Location = new Point(233, 97);
            lbl_LichSuKhuyenMai.Name = "lbl_LichSuKhuyenMai";
            lbl_LichSuKhuyenMai.Size = new Size(27, 32);
            lbl_LichSuKhuyenMai.TabIndex = 24;
            lbl_LichSuKhuyenMai.Text = "0";
            // 
            // lbl_LichSuTongHoaDon
            // 
            lbl_LichSuTongHoaDon.AutoSize = true;
            lbl_LichSuTongHoaDon.Location = new Point(233, 56);
            lbl_LichSuTongHoaDon.Name = "lbl_LichSuTongHoaDon";
            lbl_LichSuTongHoaDon.Size = new Size(27, 32);
            lbl_LichSuTongHoaDon.TabIndex = 23;
            lbl_LichSuTongHoaDon.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(28, 292);
            label19.Name = "label19";
            label19.Size = new Size(374, 32);
            label19.TabIndex = 22;
            label19.Text = "------------------------------------";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(28, 130);
            label18.Name = "label18";
            label18.Size = new Size(374, 32);
            label18.TabIndex = 21;
            label18.Text = "------------------------------------";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(28, 56);
            label13.Name = "label13";
            label13.Size = new Size(165, 32);
            label13.TabIndex = 8;
            label13.Text = "Tổng hóa đơn";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 246);
            label15.Name = "label15";
            label15.Size = new Size(115, 32);
            label15.TabIndex = 11;
            label15.Text = "Tiền thừa";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 203);
            label14.Name = "label14";
            label14.Size = new Size(177, 32);
            label14.TabIndex = 10;
            label14.Text = "Tiền khách đưa";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(28, 97);
            label16.Name = "label16";
            label16.Size = new Size(141, 32);
            label16.TabIndex = 16;
            label16.Text = "Khuyến mại";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(28, 159);
            label17.Name = "label17";
            label17.Size = new Size(129, 32);
            label17.TabIndex = 19;
            label17.Text = "Thành tiền";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dtg_lichSuChiTietHoaDon);
            groupBox6.Location = new Point(853, 61);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1065, 471);
            groupBox6.TabIndex = 23;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chi tiết hóa đơn";
            // 
            // dtg_lichSuChiTietHoaDon
            // 
            dtg_lichSuChiTietHoaDon.BackgroundColor = SystemColors.InactiveBorder;
            dtg_lichSuChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_lichSuChiTietHoaDon.Location = new Point(38, 56);
            dtg_lichSuChiTietHoaDon.Name = "dtg_lichSuChiTietHoaDon";
            dtg_lichSuChiTietHoaDon.RowHeadersWidth = 82;
            dtg_lichSuChiTietHoaDon.Size = new Size(990, 385);
            dtg_lichSuChiTietHoaDon.TabIndex = 25;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dtg_LichSuHoaDon);
            groupBox5.Location = new Point(35, 61);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(761, 471);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            groupBox5.Text = "Hóa đơn";
            // 
            // dtg_LichSuHoaDon
            // 
            dtg_LichSuHoaDon.BackgroundColor = SystemColors.InactiveBorder;
            dtg_LichSuHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_LichSuHoaDon.Location = new Point(34, 56);
            dtg_LichSuHoaDon.Name = "dtg_LichSuHoaDon";
            dtg_LichSuHoaDon.RowHeadersWidth = 82;
            dtg_LichSuHoaDon.Size = new Size(694, 385);
            dtg_LichSuHoaDon.TabIndex = 24;
            dtg_LichSuHoaDon.CellClick += dtg_LichSuHoaDon_CellClick;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 218, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2486, 1575);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lbl_chucVu);
            Controls.Add(lbl_tenNhanVien);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.Disable;
            Name = "FormHoaDon";
            Text = "Form2";
            Load += FormHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgview_thongTinHoaDon).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgview_danhSachSP).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_lichSuChiTietHoaDon).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_LichSuHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_tenNhanVien;
        private Label lbl_chucVu;
        private GroupBox groupBox1;
        private Button btn_taohoadon;
        private TextBox txt_tenkhachhang;
        private TextBox txt_sodienthoai;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Label label5;
        private Label lb_tienThua;
        private TextBox txt_tinKhachDua;
        private Label label9;
        private Label label8;
        private Label lbl_giaTriHoaDon;
        private Label label6;
        private DataGridView dtgview_thongTinHoaDon;
        private ComboBox cbx_chonHoaDon;
        private Button btn_huy;
        private Button btn_thanhToan;
        private GroupBox groupBox3;
        private Label label11;
        private TextBox txt_timkiem;
        private DataGridView dtgview_danhSachSP;
        private Label lbl_khuyenMai;
        private Label label1;
        private Label label2;
        private GroupBox groupBox4;
        private Label label10;
        private Label lbl_thanhtien;
        private Label label12;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private DataGridView dtg_lichSuChiTietHoaDon;
        private DataGridView dtg_LichSuHoaDon;
        private GroupBox groupBox7;
        private Label lbl_LichSuTongHoaDon;
        private Label label19;
        private Label label18;
        private Label label13;
        private Label label15;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label lbl_LichSuTienThua;
        private Label lbl_LichSuTienKhachDua;
        private Label lbl_LichSuThanhTien;
        private Label lbl_LichSuKhuyenMai;
        private Label txt_daHuy;
        private Label txt_daThanhToan;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}