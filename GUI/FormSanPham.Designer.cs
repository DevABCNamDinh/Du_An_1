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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPham));
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
            groupBox1 = new GroupBox();
            label15 = new Label();
            groupBox2 = new GroupBox();
            txtLsp = new TextBox();
            btnSua = new Button();
            btnThem = new Button();
            cbbIdKm = new ComboBox();
            label16 = new Label();
            grpLoaiSP = new GroupBox();
            dgvLoaiSP = new DataGridView();
            cbbTrangThai = new ComboBox();
            label17 = new Label();
            groupBox3 = new GroupBox();
            label1 = new Label();
            txtSoLuong1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            grpdssanpham.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grpLoaiSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSP).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddSp
            // 
            btnAddSp.BackColor = Color.FromArgb(128, 128, 255);
            btnAddSp.ForeColor = SystemColors.ButtonHighlight;
            btnAddSp.Location = new Point(674, 464);
            btnAddSp.Name = "btnAddSp";
            btnAddSp.Size = new Size(150, 46);
            btnAddSp.TabIndex = 1;
            btnAddSp.Text = "Thêm";
            btnAddSp.UseVisualStyleBackColor = false;
            btnAddSp.Click += btnAddSp_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 71);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 3;
            label2.Text = "Tên Sản Phẩm";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(629, -52);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 4;
            label3.Text = "Số Lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(53, 198);
            label4.Name = "label4";
            label4.Size = new Size(136, 32);
            label4.TabIndex = 5;
            label4.Text = "Nguồn Gốc";
            // 
            // btnUpdateSp
            // 
            btnUpdateSp.BackColor = Color.FromArgb(128, 128, 255);
            btnUpdateSp.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateSp.Location = new Point(900, 464);
            btnUpdateSp.Name = "btnUpdateSp";
            btnUpdateSp.Size = new Size(150, 46);
            btnUpdateSp.TabIndex = 8;
            btnUpdateSp.Text = "Sửa";
            btnUpdateSp.UseVisualStyleBackColor = false;
            btnUpdateSp.Click += btnUpdateSp_Click;
            // 
            // btnClearSp
            // 
            btnClearSp.BackColor = Color.FromArgb(128, 128, 255);
            btnClearSp.ForeColor = SystemColors.ButtonHighlight;
            btnClearSp.Location = new Point(1086, 464);
            btnClearSp.Name = "btnClearSp";
            btnClearSp.Size = new Size(150, 46);
            btnClearSp.TabIndex = 9;
            btnClearSp.Text = "CLEAR";
            btnClearSp.UseVisualStyleBackColor = false;
            btnClearSp.Click += btnClearSp_Click;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(272, 68);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(407, 39);
            txtTenSanPham.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(805, -52);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(380, 39);
            txtSoLuong.TabIndex = 13;
            // 
            // txtNguonGoc
            // 
            txtNguonGoc.Location = new Point(272, 195);
            txtNguonGoc.Name = "txtNguonGoc";
            txtNguonGoc.Size = new Size(407, 39);
            txtNguonGoc.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 60);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 16;
            label5.Text = "Tìm kiếm ";
            // 
            // txtTimKiemSp
            // 
            txtTimKiemSp.Location = new Point(193, 56);
            txtTimKiemSp.Name = "txtTimKiemSp";
            txtTimKiemSp.Size = new Size(320, 39);
            txtTimKiemSp.TabIndex = 17;
            txtTimKiemSp.TextChanged += txtTimKiemSp_TextChanged;
            // 
            // dgvSanPham
            // 
            dgvSanPham.BackgroundColor = SystemColors.InactiveBorder;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(35, 65);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 82;
            dgvSanPham.Size = new Size(1288, 543);
            dgvSanPham.TabIndex = 18;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            dgvSanPham.CellContentClick += dgvSanPham_CellContentClick;
            // 
            // grpdssanpham
            // 
            grpdssanpham.BackColor = Color.FromArgb(210, 218, 255);
            grpdssanpham.Controls.Add(dgvSanPham);
            grpdssanpham.Location = new Point(60, 904);
            grpdssanpham.Name = "grpdssanpham";
            grpdssanpham.Size = new Size(1381, 650);
            grpdssanpham.TabIndex = 19;
            grpdssanpham.TabStop = false;
            grpdssanpham.Text = "Danh sách sản phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(53, 263);
            label6.Name = "label6";
            label6.Size = new Size(125, 32);
            label6.TabIndex = 20;
            label6.Text = "Chỉ số SPF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(53, 337);
            label7.Name = "label7";
            label7.Size = new Size(113, 32);
            label7.TabIndex = 21;
            label7.Text = "Chỉ số FA";
            // 
            // txtSPF
            // 
            txtSPF.Location = new Point(272, 260);
            txtSPF.Name = "txtSPF";
            txtSPF.Size = new Size(407, 39);
            txtSPF.TabIndex = 24;
            // 
            // txtFA
            // 
            txtFA.Location = new Point(272, 334);
            txtFA.Name = "txtFA";
            txtFA.Size = new Size(407, 39);
            txtFA.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F);
            label9.Location = new Point(772, 75);
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
            label10.Location = new Point(772, 145);
            label10.Name = "label10";
            label10.Size = new Size(154, 29);
            label10.TabIndex = 28;
            label10.Text = "Hạn Sử Dụng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F);
            label11.Location = new Point(772, 202);
            label11.Name = "label11";
            label11.Size = new Size(114, 29);
            label11.TabIndex = 29;
            label11.Text = "Giá Nhập";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F);
            label12.Location = new Point(772, 267);
            label12.Name = "label12";
            label12.Size = new Size(98, 29);
            label12.TabIndex = 30;
            label12.Text = "Giá Bán";
            // 
            // txtKhoiLuong
            // 
            txtKhoiLuong.Location = new Point(947, 70);
            txtKhoiLuong.Name = "txtKhoiLuong";
            txtKhoiLuong.Size = new Size(324, 39);
            txtKhoiLuong.TabIndex = 31;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(947, 197);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(324, 39);
            txtGiaNhap.TabIndex = 33;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(947, 262);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(324, 39);
            txtGiaBan.TabIndex = 34;
            txtGiaBan.TextChanged += textBox4_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F);
            label13.Location = new Point(53, 143);
            label13.Name = "label13";
            label13.Size = new Size(181, 29);
            label13.TabIndex = 35;
            label13.Text = " Loại Sản Phẩm";
            label13.Click += label13_Click;
            // 
            // datetimeHsd
            // 
            datetimeHsd.Format = DateTimePickerFormat.Short;
            datetimeHsd.Location = new Point(947, 140);
            datetimeHsd.Name = "datetimeHsd";
            datetimeHsd.Size = new Size(324, 39);
            datetimeHsd.TabIndex = 37;
            // 
            // cbbLoaiSP
            // 
            cbbLoaiSP.FormattingEnabled = true;
            cbbLoaiSP.Location = new Point(272, 137);
            cbbLoaiSP.Name = "cbbLoaiSP";
            cbbLoaiSP.Size = new Size(407, 40);
            cbbLoaiSP.TabIndex = 38;
            cbbLoaiSP.SelectedIndexChanged += cbbLoaiSP_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.Location = new Point(772, 341);
            label8.Name = "label8";
            label8.Size = new Size(131, 29);
            label8.TabIndex = 39;
            label8.Text = "Trạng Thái";
            // 
            // rdoConBan
            // 
            rdoConBan.AutoSize = true;
            rdoConBan.Location = new Point(947, 337);
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
            rdoNgungBan.Location = new Point(1126, 337);
            rdoNgungBan.Name = "rdoNgungBan";
            rdoNgungBan.Size = new Size(166, 36);
            rdoNgungBan.TabIndex = 41;
            rdoNgungBan.TabStop = true;
            rdoNgungBan.Text = "Ngừng Bán";
            rdoNgungBan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(210, 218, 255);
            groupBox1.Controls.Add(txtSoLuong1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(cbbLoaiSP);
            groupBox1.Controls.Add(txtNguonGoc);
            groupBox1.Controls.Add(btnClearSp);
            groupBox1.Controls.Add(rdoNgungBan);
            groupBox1.Controls.Add(btnUpdateSp);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnAddSp);
            groupBox1.Controls.Add(rdoConBan);
            groupBox1.Controls.Add(txtSPF);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(datetimeHsd);
            groupBox1.Controls.Add(txtFA);
            groupBox1.Controls.Add(txtGiaBan);
            groupBox1.Controls.Add(txtGiaNhap);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtKhoiLuong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(59, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1382, 568);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản Phẩm";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(96, 153);
            label15.Name = "label15";
            label15.Size = new Size(172, 32);
            label15.TabIndex = 48;
            label15.Text = "ID Khuyến Mãi";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(210, 218, 255);
            groupBox2.Controls.Add(txtLsp);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(cbbIdKm);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Location = new Point(1486, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(844, 568);
            groupBox2.TabIndex = 49;
            groupBox2.TabStop = false;
            groupBox2.Text = "Loại Sản Phẩm";
            // 
            // txtLsp
            // 
            txtLsp.Location = new Point(322, 65);
            txtLsp.Name = "txtLsp";
            txtLsp.Size = new Size(333, 39);
            txtLsp.TabIndex = 55;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(128, 128, 255);
            btnSua.ForeColor = SystemColors.ButtonHighlight;
            btnSua.Location = new Point(508, 464);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 54;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(128, 128, 255);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(186, 464);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 53;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cbbIdKm
            // 
            cbbIdKm.FormattingEnabled = true;
            cbbIdKm.Items.AddRange(new object[] { "Không KM" });
            cbbIdKm.Location = new Point(322, 145);
            cbbIdKm.Name = "cbbIdKm";
            cbbIdKm.Size = new Size(336, 40);
            cbbIdKm.TabIndex = 52;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(93, 72);
            label16.Name = "label16";
            label16.Size = new Size(170, 32);
            label16.TabIndex = 49;
            label16.Text = "Loại Sản Phẩm";
            // 
            // grpLoaiSP
            // 
            grpLoaiSP.BackColor = Color.FromArgb(210, 218, 255);
            grpLoaiSP.Controls.Add(dgvLoaiSP);
            grpLoaiSP.Location = new Point(1486, 904);
            grpLoaiSP.Name = "grpLoaiSP";
            grpLoaiSP.Size = new Size(844, 650);
            grpLoaiSP.TabIndex = 50;
            grpLoaiSP.TabStop = false;
            grpLoaiSP.Text = "Danh sách loại sản phẩm";
            // 
            // dgvLoaiSP
            // 
            dgvLoaiSP.BackgroundColor = SystemColors.InactiveBorder;
            dgvLoaiSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiSP.GridColor = SystemColors.InactiveCaption;
            dgvLoaiSP.Location = new Point(35, 65);
            dgvLoaiSP.Name = "dgvLoaiSP";
            dgvLoaiSP.RowHeadersWidth = 82;
            dgvLoaiSP.Size = new Size(750, 543);
            dgvLoaiSP.TabIndex = 0;
            dgvLoaiSP.CellClick += dgvLoaiSP_CellClick;
            // 
            // cbbTrangThai
            // 
            cbbTrangThai.FormattingEnabled = true;
            cbbTrangThai.Items.AddRange(new object[] { "Còn Bán", "Ngừng Bán" });
            cbbTrangThai.Location = new Point(815, 60);
            cbbTrangThai.Name = "cbbTrangThai";
            cbbTrangThai.Size = new Size(324, 40);
            cbbTrangThai.TabIndex = 54;
            cbbTrangThai.SelectedIndexChanged += cbbTrangThai_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(663, 63);
            label17.Name = "label17";
            label17.Size = new Size(120, 32);
            label17.TabIndex = 55;
            label17.Text = "Trạng thái";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTimKiemSp);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(cbbTrangThai);
            groupBox3.Location = new Point(60, 39);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1382, 203);
            groupBox3.TabIndex = 42;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 396);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 51;
            label1.Text = "Số lượng";
            // 
            // txtSoLuong1
            // 
            txtSoLuong1.Location = new Point(272, 396);
            txtSoLuong1.Name = "txtSoLuong1";
            txtSoLuong1.Size = new Size(407, 39);
            txtSoLuong1.TabIndex = 52;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 218, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2377, 1601);
            Controls.Add(groupBox3);
            Controls.Add(grpLoaiSP);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpdssanpham);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSanPham";
            Load += FormSanPham_Load_3;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            grpdssanpham.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpLoaiSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSP).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Label label15;
        private GroupBox groupBox2;
        private Label label16;
        private ComboBox cbbIdKm;
        private Button btnThem;
        private GroupBox grpLoaiSP;
        private DataGridView dgvLoaiSP;
        private Button btnSua;
        private ComboBox cbbTrangThai;
        private TextBox txtLsp;
        private Label label17;
        private GroupBox groupBox3;
        private TextBox txtSoLuong1;
        private Label label1;
    }
}