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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            grpGioiTinh = new GroupBox();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            txtIDNhanVien = new TextBox();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            txtTenNhanVien = new TextBox();
            txtSdt = new TextBox();
            txtEmail = new TextBox();
            label9 = new Label();
            txtSeach = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClean = new Button();
            grpDanhSachNhanVien = new GroupBox();
            dgvDanhSachNhanVien = new DataGridView();
            cboChucVu = new ComboBox();
            grpTrangThaiLamViec = new GroupBox();
            rdoFalse = new RadioButton();
            rdoTrue = new RadioButton();
            grpGioiTinh.SuspendLayout();
            grpDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).BeginInit();
            grpTrangThaiLamViec.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập thông tin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 202);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 266);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 133);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 3;
            label4.Text = "ID Nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 331);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(675, 168);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 5;
            label6.Text = "Tài khoản";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(675, 228);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 6;
            label7.Text = "Mật khẩu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 394);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 7;
            label8.Text = "Chức vụ";
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Controls.Add(rdoNu);
            grpGioiTinh.Controls.Add(rdoNam);
            grpGioiTinh.Location = new Point(677, 283);
            grpGioiTinh.Margin = new Padding(2);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Padding = new Padding(2);
            grpGioiTinh.Size = new Size(541, 85);
            grpGioiTinh.TabIndex = 8;
            grpGioiTinh.TabStop = false;
            grpGioiTinh.Text = "Giới tính";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(363, 39);
            rdoNu.Margin = new Padding(2);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(61, 29);
            rdoNu.TabIndex = 1;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(114, 39);
            rdoNam.Margin = new Padding(2);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(75, 29);
            rdoNam.TabIndex = 0;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtIDNhanVien
            // 
            txtIDNhanVien.Location = new Point(195, 129);
            txtIDNhanVien.Margin = new Padding(2);
            txtIDNhanVien.Name = "txtIDNhanVien";
            txtIDNhanVien.ReadOnly = true;
            txtIDNhanVien.Size = new Size(390, 31);
            txtIDNhanVien.TabIndex = 9;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(828, 164);
            txtTaiKhoan.Margin = new Padding(2);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(390, 31);
            txtTaiKhoan.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(828, 224);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(390, 31);
            txtMatKhau.TabIndex = 12;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(195, 198);
            txtTenNhanVien.Margin = new Padding(2);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(396, 31);
            txtTenNhanVien.TabIndex = 13;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(195, 262);
            txtSdt.Margin = new Padding(2);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(396, 31);
            txtSdt.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(195, 327);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(396, 31);
            txtEmail.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 60);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 16;
            label9.Text = "Search";
            // 
            // txtSeach
            // 
            txtSeach.Location = new Point(195, 56);
            txtSeach.Margin = new Padding(2);
            txtSeach.Name = "txtSeach";
            txtSeach.Size = new Size(1023, 31);
            txtSeach.TabIndex = 17;
            txtSeach.TextChanged += txtSeach_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSlateBlue;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(173, 479);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 42);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSlateBlue;
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(326, 479);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 42);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.MediumSlateBlue;
            btnClean.ForeColor = SystemColors.Control;
            btnClean.Location = new Point(492, 479);
            btnClean.Margin = new Padding(2);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(99, 42);
            btnClean.TabIndex = 21;
            btnClean.Text = "CLEAN";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // grpDanhSachNhanVien
            // 
            grpDanhSachNhanVien.Controls.Add(dgvDanhSachNhanVien);
            grpDanhSachNhanVien.Location = new Point(10, 549);
            grpDanhSachNhanVien.Margin = new Padding(2);
            grpDanhSachNhanVien.Name = "grpDanhSachNhanVien";
            grpDanhSachNhanVien.Padding = new Padding(2);
            grpDanhSachNhanVien.Size = new Size(1314, 352);
            grpDanhSachNhanVien.TabIndex = 22;
            grpDanhSachNhanVien.TabStop = false;
            grpDanhSachNhanVien.Text = "Danh sách nhân viên";
            grpDanhSachNhanVien.Enter += grpDanhSachNhanVien_Enter;
            // 
            // dgvDanhSachNhanVien
            // 
            dgvDanhSachNhanVien.BackgroundColor = Color.LightSteelBlue;
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanVien.Location = new Point(5, 28);
            dgvDanhSachNhanVien.Margin = new Padding(2);
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.RowHeadersWidth = 62;
            dgvDanhSachNhanVien.Size = new Size(1305, 386);
            dgvDanhSachNhanVien.TabIndex = 0;
            dgvDanhSachNhanVien.CellClick += dgvDanhSachNhanVien_CellClick;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Nhân viên", "Admin" });
            cboChucVu.Location = new Point(195, 391);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(396, 33);
            cboChucVu.TabIndex = 23;
            // 
            // grpTrangThaiLamViec
            // 
            grpTrangThaiLamViec.Controls.Add(rdoFalse);
            grpTrangThaiLamViec.Controls.Add(rdoTrue);
            grpTrangThaiLamViec.Location = new Point(677, 390);
            grpTrangThaiLamViec.Margin = new Padding(2);
            grpTrangThaiLamViec.Name = "grpTrangThaiLamViec";
            grpTrangThaiLamViec.Padding = new Padding(2);
            grpTrangThaiLamViec.Size = new Size(541, 85);
            grpTrangThaiLamViec.TabIndex = 9;
            grpTrangThaiLamViec.TabStop = false;
            grpTrangThaiLamViec.Text = "Trạng thái làm việc";
            // 
            // rdoFalse
            // 
            rdoFalse.AutoSize = true;
            rdoFalse.Location = new Point(363, 38);
            rdoFalse.Margin = new Padding(2);
            rdoFalse.Name = "rdoFalse";
            rdoFalse.Size = new Size(99, 29);
            rdoFalse.TabIndex = 1;
            rdoFalse.TabStop = true;
            rdoFalse.Text = "Đã nghỉ";
            rdoFalse.UseVisualStyleBackColor = true;
            // 
            // rdoTrue
            // 
            rdoTrue.AutoSize = true;
            rdoTrue.Location = new Point(114, 38);
            rdoTrue.Margin = new Padding(2);
            rdoTrue.Name = "rdoTrue";
            rdoTrue.Size = new Size(114, 29);
            rdoTrue.TabIndex = 0;
            rdoTrue.TabStop = true;
            rdoTrue.Text = "Đang làm";
            rdoTrue.UseVisualStyleBackColor = true;
            // 
            // FormQLNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 218, 255);
            ClientSize = new Size(1335, 912);
            Controls.Add(grpTrangThaiLamViec);
            Controls.Add(cboChucVu);
            Controls.Add(grpDanhSachNhanVien);
            Controls.Add(btnClean);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSeach);
            Controls.Add(label9);
            Controls.Add(txtEmail);
            Controls.Add(txtSdt);
            Controls.Add(txtTenNhanVien);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(txtIDNhanVien);
            Controls.Add(grpGioiTinh);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);

            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormQLNhanVien";
            Text = "FormQLNhanVien";

            Load += FormQLNhanVien_Load;
            grpGioiTinh.ResumeLayout(false);
            grpGioiTinh.PerformLayout();
            grpDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).EndInit();
            grpTrangThaiLamViec.ResumeLayout(false);
            grpTrangThaiLamViec.PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox grpGioiTinh;
        private TextBox txtIDNhanVien;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private TextBox txtTenNhanVien;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private TextBox txtSdt;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtSeach;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClean;
        private GroupBox grpDanhSachNhanVien;
        private DataGridView dgvDanhSachNhanVien;
        private ComboBox cboChucVu;
        private GroupBox grpTrangThaiLamViec;
        private RadioButton rdoFalse;
        private RadioButton rdoTrue;
    }
}