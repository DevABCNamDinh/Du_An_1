namespace GUI
{
    partial class FormQLHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLHoaDon));
            groupBox1 = new GroupBox();
            label5 = new Label();
            cbx_trangThai = new ComboBox();
            lable5 = new Label();
            dateTime_end = new DateTimePicker();
            dateTime_start = new DateTimePicker();
            label3 = new Label();
            txt_khachHang = new TextBox();
            label4 = new Label();
            cbx_nhanVien = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txt_timKiem = new TextBox();
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
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_lichSuChiTietHoaDon).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_LichSuHoaDon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(210, 218, 255);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbx_trangThai);
            groupBox1.Controls.Add(lable5);
            groupBox1.Controls.Add(dateTime_end);
            groupBox1.Controls.Add(dateTime_start);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_khachHang);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbx_nhanVien);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_timKiem);
            groupBox1.Location = new Point(40, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2202, 314);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1551, 207);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 11;
            label5.Text = "Trang thái";
            // 
            // cbx_trangThai
            // 
            cbx_trangThai.FormattingEnabled = true;
            cbx_trangThai.Items.AddRange(new object[] { "Tất cả", "Đã thanh toán", "Đã hủy" });
            cbx_trangThai.Location = new Point(1785, 206);
            cbx_trangThai.Name = "cbx_trangThai";
            cbx_trangThai.Size = new Size(321, 40);
            cbx_trangThai.TabIndex = 10;
            cbx_trangThai.SelectedIndexChanged += cbx_trangThai_SelectedIndexChanged;
            // 
            // lable5
            // 
            lable5.AutoSize = true;
            lable5.Location = new Point(1197, 207);
            lable5.Name = "lable5";
            lable5.Size = new Size(47, 32);
            lable5.TabIndex = 9;
            lable5.Text = "Tới";
            // 
            // dateTime_end
            // 
            dateTime_end.Format = DateTimePickerFormat.Short;
            dateTime_end.Location = new Point(1284, 204);
            dateTime_end.Name = "dateTime_end";
            dateTime_end.Size = new Size(170, 39);
            dateTime_end.TabIndex = 8;
            dateTime_end.ValueChanged += dateTime_end_ValueChanged;
            // 
            // dateTime_start
            // 
            dateTime_start.Format = DateTimePickerFormat.Short;
            dateTime_start.Location = new Point(972, 204);
            dateTime_start.Name = "dateTime_start";
            dateTime_start.Size = new Size(178, 39);
            dateTime_start.TabIndex = 7;
            dateTime_start.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTime_start.ValueChanged += dateTime_start_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(755, 207);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 6;
            label3.Text = "Thời gian";
            // 
            // txt_khachHang
            // 
            txt_khachHang.Location = new Point(1785, 78);
            txt_khachHang.Name = "txt_khachHang";
            txt_khachHang.Size = new Size(321, 39);
            txt_khachHang.TabIndex = 5;
            txt_khachHang.TextChanged += txt_khachHang_TextChanged;
            txt_khachHang.KeyDown += txt_khachHang_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1551, 81);
            label4.Name = "label4";
            label4.Size = new Size(187, 32);
            label4.TabIndex = 4;
            label4.Text = "SDT khách hàng";
            // 
            // cbx_nhanVien
            // 
            cbx_nhanVien.FormattingEnabled = true;
            cbx_nhanVien.Items.AddRange(new object[] { "Tất cả nhân viên" });
            cbx_nhanVien.Location = new Point(972, 77);
            cbx_nhanVien.Name = "cbx_nhanVien";
            cbx_nhanVien.Size = new Size(482, 40);
            cbx_nhanVien.TabIndex = 3;
            cbx_nhanVien.SelectedIndexChanged += cbx_nhanVien_SelectedIndexChanged;
            cbx_nhanVien.Format += cbx_nhanVien_Format;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(755, 81);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 2;
            label2.Text = "Nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 81);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm(ID hóa đơn)";
            // 
            // txt_timKiem
            // 
            txt_timKiem.Location = new Point(337, 78);
            txt_timKiem.Name = "txt_timKiem";
            txt_timKiem.Size = new Size(337, 39);
            txt_timKiem.TabIndex = 0;
            txt_timKiem.TextChanged += txt_timKiem_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(210, 218, 255);
            groupBox4.Controls.Add(groupBox7);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(40, 428);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(2202, 1048);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Lịch sử hóa đơn";
            // 
            // groupBox7
            // 
            groupBox7.BackColor = SystemColors.InactiveBorder;
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
            groupBox7.Location = new Point(1536, 61);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(634, 495);
            groupBox7.TabIndex = 8;
            groupBox7.TabStop = false;
            groupBox7.Text = "Thành tiền";
            // 
            // txt_daHuy
            // 
            txt_daHuy.AutoSize = true;
            txt_daHuy.Font = new Font("Arial Narrow", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_daHuy.ForeColor = Color.Red;
            txt_daHuy.Location = new Point(195, 369);
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
            lbl_LichSuTienThua.Location = new Point(357, 246);
            lbl_LichSuTienThua.Name = "lbl_LichSuTienThua";
            lbl_LichSuTienThua.Size = new Size(27, 32);
            lbl_LichSuTienThua.TabIndex = 27;
            lbl_LichSuTienThua.Text = "0";
            // 
            // lbl_LichSuTienKhachDua
            // 
            lbl_LichSuTienKhachDua.AutoSize = true;
            lbl_LichSuTienKhachDua.Location = new Point(357, 203);
            lbl_LichSuTienKhachDua.Name = "lbl_LichSuTienKhachDua";
            lbl_LichSuTienKhachDua.Size = new Size(27, 32);
            lbl_LichSuTienKhachDua.TabIndex = 26;
            lbl_LichSuTienKhachDua.Text = "0";
            // 
            // lbl_LichSuThanhTien
            // 
            lbl_LichSuThanhTien.AutoSize = true;
            lbl_LichSuThanhTien.Location = new Point(357, 159);
            lbl_LichSuThanhTien.Name = "lbl_LichSuThanhTien";
            lbl_LichSuThanhTien.Size = new Size(27, 32);
            lbl_LichSuThanhTien.TabIndex = 25;
            lbl_LichSuThanhTien.Text = "0";
            // 
            // lbl_LichSuKhuyenMai
            // 
            lbl_LichSuKhuyenMai.AutoSize = true;
            lbl_LichSuKhuyenMai.Location = new Point(357, 97);
            lbl_LichSuKhuyenMai.Name = "lbl_LichSuKhuyenMai";
            lbl_LichSuKhuyenMai.Size = new Size(27, 32);
            lbl_LichSuKhuyenMai.TabIndex = 24;
            lbl_LichSuKhuyenMai.Text = "0";
            // 
            // lbl_LichSuTongHoaDon
            // 
            lbl_LichSuTongHoaDon.AutoSize = true;
            lbl_LichSuTongHoaDon.Location = new Point(357, 56);
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
            label19.Size = new Size(584, 32);
            label19.TabIndex = 22;
            label19.Text = "---------------------------------------------------------";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(28, 130);
            label18.Name = "label18";
            label18.Size = new Size(584, 32);
            label18.TabIndex = 21;
            label18.Text = "---------------------------------------------------------";
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
            groupBox6.Location = new Point(36, 617);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(2134, 411);
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
            dtg_lichSuChiTietHoaDon.Size = new Size(2036, 317);
            dtg_lichSuChiTietHoaDon.TabIndex = 25;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dtg_LichSuHoaDon);
            groupBox5.Location = new Point(35, 61);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1471, 522);
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
            dtg_LichSuHoaDon.Size = new Size(1403, 439);
            dtg_LichSuHoaDon.TabIndex = 24;
            dtg_LichSuHoaDon.CellClick += dtg_LichSuHoaDon_CellClick;
            // 
            // FormQLHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 218, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2377, 1601);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormQLHoaDon";
            Text = "                                                                                                             ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_lichSuChiTietHoaDon).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_LichSuHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox7;
        private Label txt_daHuy;
        private Label txt_daThanhToan;
        private Label lbl_LichSuTienThua;
        private Label lbl_LichSuTienKhachDua;
        private Label lbl_LichSuThanhTien;
        private Label lbl_LichSuKhuyenMai;
        private Label lbl_LichSuTongHoaDon;
        private Label label19;
        private Label label18;
        private Label label13;
        private Label label15;
        private Label label14;
        private Label label16;
        private Label label17;
        private GroupBox groupBox6;
        private DataGridView dtg_lichSuChiTietHoaDon;
        private GroupBox groupBox5;
        private DataGridView dtg_LichSuHoaDon;
        private Label label4;
        private ComboBox cbx_nhanVien;
        private Label label2;
        private Label label1;
        private TextBox txt_timKiem;
        private TextBox txt_khachHang;
        private DateTimePicker dateTime_end;
        private DateTimePicker dateTime_start;
        private Label label3;
        private Label lable5;
        private Label label5;
        private ComboBox cbx_trangThai;
    }
}