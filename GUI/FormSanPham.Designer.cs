namespace GUI
{
    partial class FormSanPham
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
            btnAddSp = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnUpdateSp = new Button();
            btnClearSp = new Button();
            txtTenSanPham = new TextBox();
            txtSoLuong = new TextBox();
            txtNguonGoc = new TextBox();
            label5 = new Label();
            txtTimKiemSp = new TextBox();
            dgvSanPham = new DataGridView();
            grpdssanpham = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            txtSPF = new TextBox();
            txtFA = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtKhoiLuong = new TextBox();
            txtGiaNhap = new TextBox();
            txtGiaBan = new TextBox();
            label13 = new Label();
            datetimeHsd = new DateTimePicker();
            cbbLoaiSP = new ComboBox();
            label8 = new Label();
            rdoConBan = new RadioButton();
            rdoNgungBan = new RadioButton();
            label1 = new Label();
            txtIDSanPham = new TextBox();
            groupBox1 = new GroupBox();
            label14 = new Label();
            label15 = new Label();
            groupBox2 = new GroupBox();
            txtLsp = new TextBox();
            btnSua = new Button();
            btnThem = new Button();
            cbbIdKm = new ComboBox();
            txtIDLSP = new TextBox();
            label16 = new Label();
            grpLoaiSP = new GroupBox();
            dgvLoaiSP = new DataGridView();
            cbbTrangThai = new ComboBox();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            grpdssanpham.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grpLoaiSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSP).BeginInit();
            SuspendLayout();
            // 
            // btnAddSp
            // 
            btnAddSp.BackColor = Color.FromArgb(128, 128, 255);
            btnAddSp.ForeColor = SystemColors.ButtonHighlight;
            btnAddSp.Location = new Point(670, 824);
            btnAddSp.Name = "btnAddSp";
            btnAddSp.Size = new Size(150, 46);
            btnAddSp.TabIndex = 1;
            btnAddSp.Text = "ADD";
            btnAddSp.UseVisualStyleBackColor = false;
            btnAddSp.Click += btnAddSp_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 122);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 3;
            label2.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(705, 271);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 4;
            label3.Text = "Số Lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(94, 540);
            label4.Name = "label4";
            label4.Size = new Size(136, 32);
            label4.TabIndex = 5;
            label4.Text = "Nguồn Gốc";
            // 
            // btnUpdateSp
            // 
            btnUpdateSp.BackColor = Color.FromArgb(128, 128, 255);
            btnUpdateSp.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateSp.Location = new Point(901, 824);
            btnUpdateSp.Name = "btnUpdateSp";
            btnUpdateSp.Size = new Size(150, 46);
            btnUpdateSp.TabIndex = 8;
            btnUpdateSp.Text = "UPDATE";
            btnUpdateSp.UseVisualStyleBackColor = false;
            btnUpdateSp.Click += btnUpdateSp_Click;
            // 
            // btnClearSp
            // 
            btnClearSp.BackColor = Color.FromArgb(128, 128, 255);
            btnClearSp.ForeColor = SystemColors.ButtonHighlight;
            btnClearSp.Location = new Point(1152, 824);
            btnClearSp.Name = "btnClearSp";
            btnClearSp.Size = new Size(150, 46);
            btnClearSp.TabIndex = 9;
            btnClearSp.Text = "CLEAR";
            btnClearSp.UseVisualStyleBackColor = false;
            btnClearSp.Click += btnClearSp_Click;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(243, 115);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(320, 39);
            txtTenSanPham.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(881, 271);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(380, 39);
            txtSoLuong.TabIndex = 13;
            // 
            // txtNguonGoc
            // 
            txtNguonGoc.Location = new Point(257, 537);
            txtNguonGoc.Name = "txtNguonGoc";
            txtNguonGoc.Size = new Size(318, 39);
            txtNguonGoc.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 66);
            label5.Name = "label5";
            label5.Size = new Size(186, 32);
            label5.TabIndex = 16;
            label5.Text = "Tìm kiếm tên sp";
            // 
            // txtTimKiemSp
            // 
            txtTimKiemSp.Location = new Point(255, 66);
            txtTimKiemSp.Name = "txtTimKiemSp";
            txtTimKiemSp.Size = new Size(320, 39);
            txtTimKiemSp.TabIndex = 17;
            txtTimKiemSp.TextChanged += txtTimKiemSp_TextChanged;
            // 
            // dgvSanPham
            // 
            dgvSanPham.BackgroundColor = Color.LightSteelBlue;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(7, 38);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 82;
            dgvSanPham.Size = new Size(1266, 359);
            dgvSanPham.TabIndex = 18;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            dgvSanPham.CellContentClick += dgvSanPham_CellContentClick;
            // 
            // grpdssanpham
            // 
            grpdssanpham.Controls.Add(dgvSanPham);
            grpdssanpham.Location = new Point(54, 903);
            grpdssanpham.Name = "grpdssanpham";
            grpdssanpham.Size = new Size(1289, 411);
            grpdssanpham.TabIndex = 19;
            grpdssanpham.TabStop = false;
            grpdssanpham.Text = "Danh Sach San Pham";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(102, 623);
            label6.Name = "label6";
            label6.Size = new Size(125, 32);
            label6.TabIndex = 20;
            label6.Text = "Chỉ số SPF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(102, 725);
            label7.Name = "label7";
            label7.Size = new Size(113, 32);
            label7.TabIndex = 21;
            label7.Text = "Chỉ số FA";
            // 
            // txtSPF
            // 
            txtSPF.Location = new Point(255, 623);
            txtSPF.Name = "txtSPF";
            txtSPF.Size = new Size(324, 39);
            txtSPF.TabIndex = 24;
            // 
            // txtFA
            // 
            txtFA.Location = new Point(255, 725);
            txtFA.Name = "txtFA";
            txtFA.Size = new Size(320, 39);
            txtFA.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F);
            label9.Location = new Point(706, 360);
            label9.Name = "label9";
            label9.Size = new Size(135, 29);
            label9.TabIndex = 27;
            label9.Text = "Khối Lượng";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F);
            label10.Location = new Point(705, 458);
            label10.Name = "label10";
            label10.Size = new Size(154, 29);
            label10.TabIndex = 28;
            label10.Text = "Hạn Sử Dụng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F);
            label11.Location = new Point(706, 547);
            label11.Name = "label11";
            label11.Size = new Size(114, 29);
            label11.TabIndex = 29;
            label11.Text = "Giá Nhập";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F);
            label12.Location = new Point(706, 645);
            label12.Name = "label12";
            label12.Size = new Size(98, 29);
            label12.TabIndex = 30;
            label12.Text = "Giá Bán";
            // 
            // txtKhoiLuong
            // 
            txtKhoiLuong.Location = new Point(881, 350);
            txtKhoiLuong.Name = "txtKhoiLuong";
            txtKhoiLuong.Size = new Size(380, 39);
            txtKhoiLuong.TabIndex = 31;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(881, 538);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(380, 39);
            txtGiaNhap.TabIndex = 33;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(881, 637);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(380, 39);
            txtGiaBan.TabIndex = 34;
            txtGiaBan.TextChanged += textBox4_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F);
            label13.Location = new Point(49, 194);
            label13.Name = "label13";
            label13.Size = new Size(181, 29);
            label13.TabIndex = 35;
            label13.Text = " Loại Sản Phẩm";
            label13.Click += label13_Click;
            // 
            // datetimeHsd
            // 
            datetimeHsd.Location = new Point(881, 450);
            datetimeHsd.Name = "datetimeHsd";
            datetimeHsd.Size = new Size(380, 39);
            datetimeHsd.TabIndex = 37;
            // 
            // cbbLoaiSP
            // 
            cbbLoaiSP.FormattingEnabled = true;
            cbbLoaiSP.Location = new Point(243, 188);
            cbbLoaiSP.Name = "cbbLoaiSP";
            cbbLoaiSP.Size = new Size(320, 40);
            cbbLoaiSP.TabIndex = 38;
            cbbLoaiSP.SelectedIndexChanged += cbbLoaiSP_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.Location = new Point(705, 723);
            label8.Name = "label8";
            label8.Size = new Size(131, 29);
            label8.TabIndex = 39;
            label8.Text = "Trạng Thái";
            // 
            // rdoConBan
            // 
            rdoConBan.AutoSize = true;
            rdoConBan.Location = new Point(881, 723);
            rdoConBan.Name = "rdoConBan";
            rdoConBan.Size = new Size(135, 36);
            rdoConBan.TabIndex = 40;
            rdoConBan.TabStop = true;
            rdoConBan.Text = "Còn Bán";
            rdoConBan.UseVisualStyleBackColor = true;
            // 
            // rdoNgungBan
            // 
            rdoNgungBan.AutoSize = true;
            rdoNgungBan.Location = new Point(1095, 721);
            rdoNgungBan.Name = "rdoNgungBan";
            rdoNgungBan.Size = new Size(166, 36);
            rdoNgungBan.TabIndex = 41;
            rdoNgungBan.TabStop = true;
            rdoNgungBan.Text = "Ngừng Bán";
            rdoNgungBan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 45);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 42;
            label1.Text = "ID Sản Phẩm ";
            // 
            // txtIDSanPham
            // 
            txtIDSanPham.Location = new Point(243, 38);
            txtIDSanPham.Name = "txtIDSanPham";
            txtIDSanPham.ReadOnly = true;
            txtIDSanPham.Size = new Size(320, 39);
            txtIDSanPham.TabIndex = 43;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIDSanPham);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(cbbLoaiSP);
            groupBox1.Location = new Point(12, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 291);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản Phẩm";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(50, 62);
            label14.Name = "label14";
            label14.Size = new Size(200, 32);
            label14.TabIndex = 47;
            label14.Text = "ID Loại Sản Phẩm";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(50, 164);
            label15.Name = "label15";
            label15.Size = new Size(172, 32);
            label15.TabIndex = 48;
            label15.Text = "ID Khuyến Mãi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLsp);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(cbbIdKm);
            groupBox2.Controls.Add(txtIDLSP);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Location = new Point(1606, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(725, 596);
            groupBox2.TabIndex = 49;
            groupBox2.TabStop = false;
            groupBox2.Text = "Loại Sản Phẩm";
            // 
            // txtLsp
            // 
            txtLsp.Location = new Point(279, 252);
            txtLsp.Name = "txtLsp";
            txtLsp.Size = new Size(239, 39);
            txtLsp.TabIndex = 55;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(128, 128, 255);
            btnSua.ForeColor = SystemColors.ButtonHighlight;
            btnSua.Location = new Point(383, 410);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 54;
            btnSua.Text = "UPDATE";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(128, 128, 255);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(86, 410);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 53;
            btnThem.Text = "ADD";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cbbIdKm
            // 
            cbbIdKm.FormattingEnabled = true;
            cbbIdKm.Items.AddRange(new object[] { "Không KM" });
            cbbIdKm.Location = new Point(276, 156);
            cbbIdKm.Name = "cbbIdKm";
            cbbIdKm.Size = new Size(242, 40);
            cbbIdKm.TabIndex = 52;
            // 
            // txtIDLSP
            // 
            txtIDLSP.Location = new Point(279, 55);
            txtIDLSP.Name = "txtIDLSP";
            txtIDLSP.ReadOnly = true;
            txtIDLSP.Size = new Size(239, 39);
            txtIDLSP.TabIndex = 50;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(50, 259);
            label16.Name = "label16";
            label16.Size = new Size(170, 32);
            label16.TabIndex = 49;
            label16.Text = "Loại Sản Phẩm";
            // 
            // grpLoaiSP
            // 
            grpLoaiSP.Controls.Add(dgvLoaiSP);
            grpLoaiSP.Location = new Point(1533, 903);
            grpLoaiSP.Name = "grpLoaiSP";
            grpLoaiSP.Size = new Size(750, 420);
            grpLoaiSP.TabIndex = 50;
            grpLoaiSP.TabStop = false;
            grpLoaiSP.Text = "Danh Sách Loại Sản Phẩm";
            // 
            // dgvLoaiSP
            // 
            dgvLoaiSP.BackgroundColor = SystemColors.ActiveCaption;
            dgvLoaiSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiSP.GridColor = SystemColors.InactiveCaption;
            dgvLoaiSP.Location = new Point(28, 39);
            dgvLoaiSP.Name = "dgvLoaiSP";
            dgvLoaiSP.RowHeadersWidth = 82;
            dgvLoaiSP.Size = new Size(716, 358);
            dgvLoaiSP.TabIndex = 0;
            dgvLoaiSP.CellClick += dgvLoaiSP_CellClick;
            // 
            // cbbTrangThai
            // 
            cbbTrangThai.FormattingEnabled = true;
            cbbTrangThai.Items.AddRange(new object[] { "Còn Bán", "Ngừng Bán" });
            cbbTrangThai.Location = new Point(255, 152);
            cbbTrangThai.Name = "cbbTrangThai";
            cbbTrangThai.Size = new Size(324, 40);
            cbbTrangThai.TabIndex = 54;
            cbbTrangThai.SelectedIndexChanged += cbbTrangThai_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(65, 155);
            label17.Name = "label17";
            label17.Size = new Size(173, 32);
            label17.TabIndex = 55;
            label17.Text = "Lọc Trạng Thái:";
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 218, 255);
            ClientSize = new Size(2460, 1504);
            Controls.Add(label17);
            Controls.Add(cbbTrangThai);
            Controls.Add(grpLoaiSP);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(rdoNgungBan);
            Controls.Add(rdoConBan);
            Controls.Add(label8);
            Controls.Add(datetimeHsd);
            Controls.Add(txtGiaBan);
            Controls.Add(txtGiaNhap);
            Controls.Add(txtKhoiLuong);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtFA);
            Controls.Add(txtSPF);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(grpdssanpham);
            Controls.Add(txtTimKiemSp);
            Controls.Add(label5);
            Controls.Add(txtNguonGoc);
            Controls.Add(txtSoLuong);
            Controls.Add(btnClearSp);
            Controls.Add(btnUpdateSp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAddSp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSanPham";
            Text = "FormSanPham";
            Load += FormSanPham_Load_3;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            grpdssanpham.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpLoaiSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddSp;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnUpdateSp;
        private Button btnClearSp;
        private TextBox txtTenSanPham;
        private TextBox txtSoLuong;
        private TextBox txtNguonGoc;
        private Label label5;
        private TextBox txtTimKiemSp;
        private DataGridView dgvSanPham;
        private GroupBox grpdssanpham;
        private Label label6;
        private Label label7;
        private TextBox txtSPF;
        private TextBox txtFA;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtKhoiLuong;
        private TextBox txtGiaNhap;
        private TextBox txtGiaBan;
        private Label label13;
        private DateTimePicker datetimeHsd;
        private ComboBox cbbLoaiSP;
        private Label label8;
        private RadioButton rdoConBan;
        private RadioButton rdoNgungBan;
        private Label label1;
        private TextBox txtIDSanPham;
        private GroupBox groupBox1;
        private Label label14;
        private Label label15;
        private GroupBox groupBox2;
        private Label label16;
        private ComboBox cbbIdKm;
        private TextBox txtIDLSP;
        private Button btnThem;
        private GroupBox grpLoaiSP;
        private DataGridView dgvLoaiSP;
        private Button btnSua;
        private ComboBox cbbTrangThai;
        private TextBox txtLsp;
        private Label label17;
    }
}