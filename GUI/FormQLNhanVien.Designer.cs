namespace GUI
{
    partial class FormQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLNhanVien));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            Nu = new RadioButton();
            Nam = new RadioButton();
            txtIDNhanVien = new TextBox();
            txtTaiKhoan = new TextBox();
            txtTenNhanVien = new TextBox();
            txtSdt = new TextBox();
            txtEmail = new TextBox();
            label9 = new Label();
            txtSeach = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClean = new Button();
            grpDanhSachNhanVien = new GroupBox();
            dtgv_thongtinNhanVien = new DataGridView();
            cboChucVu = new ComboBox();
            rdoFalse = new RadioButton();
            rdoTrue = new RadioButton();
            grpThaoTac = new GroupBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            label12 = new Label();
            cboLoc = new ComboBox();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            grpDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_thongtinNhanVien).BeginInit();
            grpThaoTac.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 208);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1163, 115);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 115);
            label4.Name = "label4";
            label4.Size = new Size(154, 32);
            label4.TabIndex = 3;
            label4.Text = "ID Nhân viên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1163, 299);
            label6.Name = "label6";
            label6.Size = new Size(115, 32);
            label6.TabIndex = 5;
            label6.Text = "Tài khoản";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(107, 299);
            label8.Name = "label8";
            label8.Size = new Size(101, 32);
            label8.TabIndex = 7;
            label8.Text = "Chức vụ";
            // 
            // Nu
            // 
            Nu.AutoSize = true;
            Nu.Location = new Point(618, 0);
            Nu.Name = "Nu";
            Nu.Size = new Size(77, 36);
            Nu.TabIndex = 1;
            Nu.TabStop = true;
            Nu.Text = "Nữ";
            Nu.UseVisualStyleBackColor = true;
            // 
            // Nam
            // 
            Nam.AutoSize = true;
            Nam.Location = new Point(332, 0);
            Nam.Name = "Nam";
            Nam.Size = new Size(96, 36);
            Nam.TabIndex = 0;
            Nam.TabStop = true;
            Nam.Text = "Nam";
            Nam.UseVisualStyleBackColor = true;
            // 
            // txtIDNhanVien
            // 
            txtIDNhanVien.Location = new Point(420, 108);
            txtIDNhanVien.Name = "txtIDNhanVien";
            txtIDNhanVien.ReadOnly = true;
            txtIDNhanVien.Size = new Size(540, 39);
            txtIDNhanVien.TabIndex = 9;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(1476, 291);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(506, 39);
            txtTaiKhoan.TabIndex = 11;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(420, 201);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(540, 39);
            txtTenNhanVien.TabIndex = 13;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(1476, 108);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(506, 39);
            txtSdt.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1476, 201);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(506, 39);
            txtEmail.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(129, 67);
            label9.Name = "label9";
            label9.Size = new Size(310, 32);
            label9.TabIndex = 16;
            label9.Text = "Tìm kiếm(ID/Tên nhân viên)";
            // 
            // txtSeach
            // 
            txtSeach.Location = new Point(470, 64);
            txtSeach.Name = "txtSeach";
            txtSeach.Size = new Size(311, 39);
            txtSeach.TabIndex = 17;
            txtSeach.TextChanged += txtSeach_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSlateBlue;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(1264, 628);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSlateBlue;
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(1585, 628);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.MediumSlateBlue;
            btnClean.ForeColor = SystemColors.Control;
            btnClean.Location = new Point(1897, 628);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(150, 46);
            btnClean.TabIndex = 21;
            btnClean.Text = "Quét sạch";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // grpDanhSachNhanVien
            // 
            grpDanhSachNhanVien.Controls.Add(dtgv_thongtinNhanVien);
            grpDanhSachNhanVien.Location = new Point(72, 1052);
            grpDanhSachNhanVien.Name = "grpDanhSachNhanVien";
            grpDanhSachNhanVien.Size = new Size(2083, 513);
            grpDanhSachNhanVien.TabIndex = 22;
            grpDanhSachNhanVien.TabStop = false;
            grpDanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // dtgv_thongtinNhanVien
            // 
            dtgv_thongtinNhanVien.BackgroundColor = SystemColors.InactiveBorder;
            dtgv_thongtinNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_thongtinNhanVien.Location = new Point(55, 49);
            dtgv_thongtinNhanVien.Name = "dtgv_thongtinNhanVien";
            dtgv_thongtinNhanVien.RowHeadersWidth = 82;
            dtgv_thongtinNhanVien.Size = new Size(1992, 412);
            dtgv_thongtinNhanVien.TabIndex = 0;
            dtgv_thongtinNhanVien.CellClick += dtgv_thongtinNhanVien_CellClick;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Nhân viên", "Admin" });
            cboChucVu.Location = new Point(420, 291);
            cboChucVu.Margin = new Padding(4);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(506, 40);
            cboChucVu.TabIndex = 23;
            // 
            // rdoFalse
            // 
            rdoFalse.AutoSize = true;
            rdoFalse.Location = new Point(618, 0);
            rdoFalse.Name = "rdoFalse";
            rdoFalse.Size = new Size(129, 36);
            rdoFalse.TabIndex = 1;
            rdoFalse.TabStop = true;
            rdoFalse.Text = "Đã nghỉ";
            rdoFalse.UseVisualStyleBackColor = true;
            // 
            // rdoTrue
            // 
            rdoTrue.AutoSize = true;
            rdoTrue.Location = new Point(332, 0);
            rdoTrue.Name = "rdoTrue";
            rdoTrue.Size = new Size(148, 36);
            rdoTrue.TabIndex = 0;
            rdoTrue.TabStop = true;
            rdoTrue.Text = "Đang làm";
            rdoTrue.UseVisualStyleBackColor = true;
            rdoTrue.CheckedChanged += rdoTrue_CheckedChanged;
            // 
            // grpThaoTac
            // 
            grpThaoTac.Controls.Add(label10);
            grpThaoTac.Controls.Add(groupBox2);
            grpThaoTac.Controls.Add(groupBox1);
            grpThaoTac.Controls.Add(btnUpdate);
            grpThaoTac.Controls.Add(txtIDNhanVien);
            grpThaoTac.Controls.Add(btnClean);
            grpThaoTac.Controls.Add(label2);
            grpThaoTac.Controls.Add(cboChucVu);
            grpThaoTac.Controls.Add(btnAdd);
            grpThaoTac.Controls.Add(label3);
            grpThaoTac.Controls.Add(label4);
            grpThaoTac.Controls.Add(label8);
            grpThaoTac.Controls.Add(txtTenNhanVien);
            grpThaoTac.Controls.Add(txtSdt);
            grpThaoTac.Controls.Add(txtTaiKhoan);
            grpThaoTac.Controls.Add(txtEmail);
            grpThaoTac.Controls.Add(label6);
            grpThaoTac.Location = new Point(72, 262);
            grpThaoTac.Margin = new Padding(4);
            grpThaoTac.Name = "grpThaoTac";
            grpThaoTac.Padding = new Padding(4);
            grpThaoTac.Size = new Size(2083, 753);
            grpThaoTac.TabIndex = 24;
            grpThaoTac.TabStop = false;
            grpThaoTac.Text = "Thông tin";
            grpThaoTac.Enter += grpThaoTac_Enter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1163, 208);
            label10.Name = "label10";
            label10.Size = new Size(71, 32);
            label10.TabIndex = 28;
            label10.Text = "Email";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoFalse);
            groupBox2.Controls.Add(rdoTrue);
            groupBox2.Location = new Point(1163, 474);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(959, 61);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trạng thái làm việc";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Nu);
            groupBox1.Controls.Add(Nam);
            groupBox1.Location = new Point(107, 474);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(959, 58);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(873, 67);
            label12.Name = "label12";
            label12.Size = new Size(120, 32);
            label12.TabIndex = 26;
            label12.Text = "Trạng thái";
            // 
            // cboLoc
            // 
            cboLoc.FormattingEnabled = true;
            cboLoc.Items.AddRange(new object[] { "Tất cả", "Đang làm", "Đã nghỉ" });
            cboLoc.Location = new Point(1074, 63);
            cboLoc.Margin = new Padding(4);
            cboLoc.Name = "cboLoc";
            cboLoc.Size = new Size(304, 40);
            cboLoc.TabIndex = 27;
            cboLoc.SelectedIndexChanged += cboLoc_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(cboLoc);
            groupBox4.Controls.Add(txtSeach);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(72, 45);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(2083, 196);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tất cả", "Nhân viên", "Admin" });
            comboBox1.Location = new Point(1687, 63);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(295, 40);
            comboBox1.TabIndex = 29;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1529, 67);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 28;
            label1.Text = "Chức vụ";
            // 
            // FormQLNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 218, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2376, 1601);
            Controls.Add(groupBox4);
            Controls.Add(grpThaoTac);
            Controls.Add(grpDanhSachNhanVien);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormQLNhanVien";
            Text = "FormQLNhanVien";
            Load += FormQLNhanVien_Load;
            grpDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_thongtinNhanVien).EndInit();
            grpThaoTac.ResumeLayout(false);
            grpThaoTac.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label8;
        private TextBox txtIDNhanVien;
        private TextBox txtTaiKhoan;
        private TextBox txtTenNhanVien;
        private RadioButton Nu;
        private RadioButton Nam;
        private TextBox txtSdt;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtSeach;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClean;
        private GroupBox grpDanhSachNhanVien;
        private ComboBox cboChucVu;
        private RadioButton rdoFalse;
        private RadioButton rdoTrue;
        private GroupBox grpThaoTac;
        private Label label12;
        private ComboBox cboLoc;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dtgv_thongtinNhanVien;
        private Label label10;
    }
}