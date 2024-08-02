﻿namespace GUI
{
    partial class FormKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhuyenMai));
            rdoTat = new RadioButton();
            rdoBat = new RadioButton();
            btnSua = new Button();
            btnThem = new Button();
            txtMoTaKM = new TextBox();
            txtGiamGia = new TextBox();
            dateNgayKetThuc = new DateTimePicker();
            dateNgayBatDau = new DateTimePicker();
            txtTenKhuyenMai = new TextBox();
            cbbTrangThai = new ComboBox();
            dateLocNKT = new DateTimePicker();
            dateLocNBD = new DateTimePicker();
            txtLocID = new TextBox();
            btnTim = new Button();
            txtTim = new TextBox();
            txtIDKhuyenMai = new TextBox();
            groupBox1 = new GroupBox();
            label18 = new Label();
            label17 = new Label();
            label12 = new Label();
            label16 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label36 = new Label();
            label35 = new Label();
            label34 = new Label();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            label19 = new Label();
            groupBox3 = new GroupBox();
            dgvKhuyenMai = new DataGridView();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhuyenMai).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rdoTat
            // 
            rdoTat.AutoSize = true;
            rdoTat.Location = new Point(1886, 292);
            rdoTat.Name = "rdoTat";
            rdoTat.Size = new Size(142, 36);
            rdoTat.TabIndex = 37;
            rdoTat.TabStop = true;
            rdoTat.Text = "Đang Tắt";
            rdoTat.UseVisualStyleBackColor = true;
            // 
            // rdoBat
            // 
            rdoBat.AutoSize = true;
            rdoBat.Location = new Point(1592, 292);
            rdoBat.Name = "rdoBat";
            rdoBat.Size = new Size(226, 36);
            rdoBat.TabIndex = 36;
            rdoBat.TabStop = true;
            rdoBat.Text = "Đang Hoạt Động";
            rdoBat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SlateBlue;
            btnSua.Font = new Font("Microsoft Sans Serif", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = SystemColors.Window;
            btnSua.Location = new Point(1859, 373);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(169, 91);
            btnSua.TabIndex = 28;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SlateBlue;
            btnThem.BackgroundImage = Properties.Resources.png_clipart_plus_and_minus_signs_symbol_add_sign_s_cross_sign_removebg_preview;
            btnThem.BackgroundImageLayout = ImageLayout.Center;
            btnThem.Font = new Font("Microsoft Sans Serif", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.Window;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(1414, 373);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(185, 91);
            btnThem.TabIndex = 27;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtMoTaKM
            // 
            txtMoTaKM.Cursor = Cursors.IBeam;
            txtMoTaKM.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtMoTaKM.Location = new Point(1592, 193);
            txtMoTaKM.Margin = new Padding(6);
            txtMoTaKM.Multiline = true;
            txtMoTaKM.Name = "txtMoTaKM";
            txtMoTaKM.Size = new Size(436, 39);
            txtMoTaKM.TabIndex = 16;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Cursor = Cursors.IBeam;
            txtGiamGia.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtGiamGia.Location = new Point(1592, 97);
            txtGiamGia.Margin = new Padding(6);
            txtGiamGia.Multiline = true;
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(241, 39);
            txtGiamGia.TabIndex = 14;
            // 
            // dateNgayKetThuc
            // 
            dateNgayKetThuc.CalendarFont = new Font("Microsoft Sans Serif", 9F);
            dateNgayKetThuc.CalendarForeColor = Color.FromArgb(177, 178, 255);
            dateNgayKetThuc.CalendarMonthBackground = Color.FromArgb(177, 178, 255);
            dateNgayKetThuc.CalendarTitleBackColor = Color.FromArgb(177, 178, 255);
            dateNgayKetThuc.CalendarTitleForeColor = Color.FromArgb(177, 178, 255);
            dateNgayKetThuc.CalendarTrailingForeColor = Color.FromArgb(177, 178, 255);
            dateNgayKetThuc.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dateNgayKetThuc.Location = new Point(801, 291);
            dateNgayKetThuc.Name = "dateNgayKetThuc";
            dateNgayKetThuc.Size = new Size(303, 39);
            dateNgayKetThuc.TabIndex = 12;
            dateNgayKetThuc.Value = new DateTime(2022, 12, 16, 21, 3, 0, 0);
            // 
            // dateNgayBatDau
            // 
            dateNgayBatDau.CalendarFont = new Font("Microsoft Sans Serif", 9F);
            dateNgayBatDau.CalendarForeColor = Color.FromArgb(177, 178, 255);
            dateNgayBatDau.CalendarMonthBackground = Color.FromArgb(177, 178, 255);
            dateNgayBatDau.CalendarTitleBackColor = Color.FromArgb(177, 178, 255);
            dateNgayBatDau.CalendarTitleForeColor = Color.FromArgb(177, 178, 255);
            dateNgayBatDau.CalendarTrailingForeColor = Color.FromArgb(177, 178, 255);
            dateNgayBatDau.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateNgayBatDau.DropDownAlign = LeftRightAlignment.Right;
            dateNgayBatDau.Format = DateTimePickerFormat.Custom;
            dateNgayBatDau.Location = new Point(373, 291);
            dateNgayBatDau.Name = "dateNgayBatDau";
            dateNgayBatDau.Size = new Size(294, 39);
            dateNgayBatDau.TabIndex = 11;
            dateNgayBatDau.Value = new DateTime(2022, 12, 16, 21, 3, 0, 0);
            // 
            // txtTenKhuyenMai
            // 
            txtTenKhuyenMai.Cursor = Cursors.IBeam;
            txtTenKhuyenMai.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtTenKhuyenMai.Location = new Point(373, 193);
            txtTenKhuyenMai.Margin = new Padding(6);
            txtTenKhuyenMai.Multiline = true;
            txtTenKhuyenMai.Name = "txtTenKhuyenMai";
            txtTenKhuyenMai.Size = new Size(278, 39);
            txtTenKhuyenMai.TabIndex = 8;
            // 
            // cbbTrangThai
            // 
            cbbTrangThai.FormattingEnabled = true;
            cbbTrangThai.Location = new Point(1719, 57);
            cbbTrangThai.Name = "cbbTrangThai";
            cbbTrangThai.Size = new Size(387, 40);
            cbbTrangThai.TabIndex = 56;
            // 
            // dateLocNKT
            // 
            dateLocNKT.CalendarFont = new Font("Microsoft Sans Serif", 9F);
            dateLocNKT.CalendarForeColor = Color.FromArgb(177, 178, 255);
            dateLocNKT.CalendarMonthBackground = Color.FromArgb(177, 178, 255);
            dateLocNKT.CalendarTitleBackColor = Color.FromArgb(177, 178, 255);
            dateLocNKT.CalendarTitleForeColor = Color.FromArgb(177, 178, 255);
            dateLocNKT.CalendarTrailingForeColor = Color.FromArgb(177, 178, 255);
            dateLocNKT.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateLocNKT.Format = DateTimePickerFormat.Custom;
            dateLocNKT.Location = new Point(1529, 170);
            dateLocNKT.Name = "dateLocNKT";
            dateLocNKT.Size = new Size(303, 39);
            dateLocNKT.TabIndex = 42;
            dateLocNKT.Value = new DateTime(2022, 12, 16, 21, 3, 0, 0);
            // 
            // dateLocNBD
            // 
            dateLocNBD.CalendarFont = new Font("Microsoft Sans Serif", 9F);
            dateLocNBD.CalendarForeColor = Color.FromArgb(177, 178, 255);
            dateLocNBD.CalendarMonthBackground = Color.FromArgb(177, 178, 255);
            dateLocNBD.CalendarTitleBackColor = Color.FromArgb(177, 178, 255);
            dateLocNBD.CalendarTitleForeColor = Color.FromArgb(177, 178, 255);
            dateLocNBD.CalendarTrailingForeColor = Color.FromArgb(177, 178, 255);
            dateLocNBD.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateLocNBD.DropDownAlign = LeftRightAlignment.Right;
            dateLocNBD.Format = DateTimePickerFormat.Custom;
            dateLocNBD.Location = new Point(1084, 170);
            dateLocNBD.Name = "dateLocNBD";
            dateLocNBD.Size = new Size(294, 39);
            dateLocNBD.TabIndex = 41;
            dateLocNBD.Value = new DateTime(2022, 12, 16, 21, 3, 0, 0);
            // 
            // txtLocID
            // 
            txtLocID.Cursor = Cursors.IBeam;
            txtLocID.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtLocID.Location = new Point(1084, 60);
            txtLocID.Margin = new Padding(6);
            txtLocID.Multiline = true;
            txtLocID.Name = "txtLocID";
            txtLocID.Size = new Size(276, 39);
            txtLocID.TabIndex = 38;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.SlateBlue;
            btnTim.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.ForeColor = SystemColors.Window;
            btnTim.Location = new Point(536, 63);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(150, 46);
            btnTim.TabIndex = 33;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // txtTim
            // 
            txtTim.BackColor = SystemColors.ControlLightLight;
            txtTim.Cursor = Cursors.IBeam;
            txtTim.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtTim.Location = new Point(217, 67);
            txtTim.Margin = new Padding(6);
            txtTim.Multiline = true;
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(267, 39);
            txtTim.TabIndex = 18;
            // 
            // txtIDKhuyenMai
            // 
            txtIDKhuyenMai.Cursor = Cursors.IBeam;
            txtIDKhuyenMai.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtIDKhuyenMai.Location = new Point(373, 97);
            txtIDKhuyenMai.Margin = new Padding(6);
            txtIDKhuyenMai.Multiline = true;
            txtIDKhuyenMai.Name = "txtIDKhuyenMai";
            txtIDKhuyenMai.Size = new Size(278, 39);
            txtIDKhuyenMai.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTim);
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(txtLocID);
            groupBox1.Controls.Add(dateLocNBD);
            groupBox1.Controls.Add(dateLocNKT);
            groupBox1.Controls.Add(cbbTrangThai);
            groupBox1.Location = new Point(75, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2158, 279);
            groupBox1.TabIndex = 75;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1529, 60);
            label18.Name = "label18";
            label18.Size = new Size(120, 32);
            label18.TabIndex = 43;
            label18.Text = "Trạng thái";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1430, 175);
            label17.Name = "label17";
            label17.Size = new Size(47, 32);
            label17.TabIndex = 42;
            label17.Text = "Tới";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(874, 177);
            label12.Name = "label12";
            label12.Size = new Size(114, 32);
            label12.TabIndex = 40;
            label12.Text = "Thời gian";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(874, 67);
            label16.Name = "label16";
            label16.Size = new Size(169, 32);
            label16.TabIndex = 39;
            label16.Text = "ID khuyến mãi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 71);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 34;
            label3.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoTat);
            groupBox2.Controls.Add(label36);
            groupBox2.Controls.Add(rdoBat);
            groupBox2.Controls.Add(label35);
            groupBox2.Controls.Add(label34);
            groupBox2.Controls.Add(label33);
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(txtIDKhuyenMai);
            groupBox2.Controls.Add(txtTenKhuyenMai);
            groupBox2.Controls.Add(dateNgayBatDau);
            groupBox2.Controls.Add(dateNgayKetThuc);
            groupBox2.Controls.Add(txtGiamGia);
            groupBox2.Controls.Add(txtMoTaKM);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Location = new Point(75, 408);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2158, 481);
            groupBox2.TabIndex = 75;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khuyến mãi";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(1258, 294);
            label36.Name = "label36";
            label36.Size = new Size(120, 32);
            label36.TabIndex = 18;
            label36.Text = "Trạng thái";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(1258, 196);
            label35.Name = "label35";
            label35.Size = new Size(77, 32);
            label35.TabIndex = 17;
            label35.Text = "Mô tả";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(1258, 100);
            label34.Name = "label34";
            label34.Size = new Size(222, 32);
            label34.TabIndex = 15;
            label34.Text = "Phần trăm giảm giá";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(724, 294);
            label33.Name = "label33";
            label33.Size = new Size(42, 32);
            label33.TabIndex = 14;
            label33.Text = "tới";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(163, 294);
            label32.Name = "label32";
            label32.Size = new Size(114, 32);
            label32.TabIndex = 13;
            label32.Text = "Thời gian";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(163, 196);
            label31.Name = "label31";
            label31.Size = new Size(184, 32);
            label31.TabIndex = 4;
            label31.Text = "Tên khuyến mãi";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(163, 100);
            label19.Name = "label19";
            label19.Size = new Size(169, 32);
            label19.TabIndex = 3;
            label19.Text = "ID khuyến mãi";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(210, 218, 255);
            groupBox3.Controls.Add(dgvKhuyenMai);
            groupBox3.Location = new Point(75, 919);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(2158, 634);
            groupBox3.TabIndex = 75;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách khuyến mại";
            // 
            // dgvKhuyenMai
            // 
            dgvKhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvKhuyenMai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKhuyenMai.BackgroundColor = Color.FromArgb(238, 241, 255);
            dgvKhuyenMai.ColumnHeadersHeight = 46;
            dgvKhuyenMai.GridColor = Color.Violet;
            dgvKhuyenMai.Location = new Point(74, 69);
            dgvKhuyenMai.Name = "dgvKhuyenMai";
            dgvKhuyenMai.RowHeadersWidth = 82;
            dgvKhuyenMai.Size = new Size(2042, 512);
            dgvKhuyenMai.TabIndex = 74;
            dgvKhuyenMai.CellClick += dgvKhuyenMai_CellClick;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2377, 1601);
            panel1.TabIndex = 75;
            // 
            // FormKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 218, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2377, 1601);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKhuyenMai";
            Text = "FormKhuyenMai";
            Load += FormKhuyenMai_Load_1;
            Resize += FormKhuyenMai_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhuyenMai).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtIDKhuyenMai;
        private DateTimePicker dateNgayBatDau;
        private TextBox txtTenKhuyenMai;
        private TextBox txtMoTaKM;
        private TextBox txtGiamGia;
        private DateTimePicker dateNgayKetThuc;
        private TextBox txtTim;
        private Button btnSua;
        private Button btnThem;
        private Button btnTim;
        private RadioButton rdoTat;
        private RadioButton rdoBat;
        private DateTimePicker dateLocNKT;
        private DateTimePicker dateLocNBD;
        private TextBox txtLocID;
        private ComboBox cbbTrangThai;
        private Panel panel3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label16;
        private TextBox textBox21;
        private TextBox textBox22;
        private Button button2;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private TextBox textBox26;
        private TextBox textBox27;
        private TextBox textBox28;
        private ComboBox comboBox1;
        private TextBox textBox29;
        private ComboBox comboBox2;
        private Button button3;
        private TextBox textBox30;
        private ComboBox comboBox3;
        private Button button4;
        private TextBox textBox31;
        private Button button5;
        private Label label17;
        private TextBox textBox32;
        private TextBox textBox33;
        private Button button6;
        private Button button7;
        private Label label18;
        private TextBox textBox34;
        private TextBox textBox35;
        private Button button8;
        private TextBox textBox36;
        private Label label19;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label20;
        private Label label21;
        private TextBox textBox37;
        private Label label22;
        private TextBox textBox38;
        private Panel panel4;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label23;
        private Button button9;
        private TextBox textBox39;
        private Button button10;
        private Button button11;
        private Button button12;
        private DataGridView dgvKhuyenMaii;
        private TextBox textBox40;
        private TextBox textBox41;
        private TextBox textBox42;
        private TextBox textBox43;
        private Label label24;
        private TextBox textBox44;
        private Label label25;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Label label26;
        private Label label27;
        private TextBox textBox45;
        private Label label28;
        private TextBox textBox46;
        private Label label29;
        private Label label30;
        private TextBox textBox47;
        private TextBox textBox48;
        private GroupBox groupBox1;
        private Label label3;
        private Label label12;
        private GroupBox groupBox2;
        private Label label31;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private GroupBox groupBox3;
        private DataGridView dgvKhuyenMai;
        private Panel panel1;
    }
}