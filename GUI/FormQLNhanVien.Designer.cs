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
            txtIDChucVu = new TextBox();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            txtTenNhanVien = new TextBox();
            txtSdt = new TextBox();
            txtEmail = new TextBox();
            label9 = new Label();
            txtSeach = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClean = new Button();
            grpDanhSachNhanVien = new GroupBox();
            dgvDanhSachNhanVien = new DataGridView();
            grpGioiTinh.SuspendLayout();
            grpDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 0;
            label1.Text = "Nhập thông tin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(657, 78);
            label2.Name = "label2";
            label2.Size = new Size(142, 30);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(657, 136);
            label3.Name = "label3";
            label3.Size = new Size(135, 30);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 83);
            label4.Name = "label4";
            label4.Size = new Size(135, 30);
            label4.TabIndex = 3;
            label4.Text = "ID Nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(657, 198);
            label5.Name = "label5";
            label5.Size = new Size(63, 30);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 203);
            label6.Name = "label6";
            label6.Size = new Size(101, 30);
            label6.TabIndex = 5;
            label6.Text = "Tài khoản";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 259);
            label7.Name = "label7";
            label7.Size = new Size(101, 30);
            label7.TabIndex = 6;
            label7.Text = "Mật khẩu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 141);
            label8.Name = "label8";
            label8.Size = new Size(115, 30);
            label8.TabIndex = 7;
            label8.Text = "ID Chức vụ";
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Controls.Add(rdoNu);
            grpGioiTinh.Controls.Add(rdoNam);
            grpGioiTinh.Location = new Point(657, 254);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Size = new Size(495, 102);
            grpGioiTinh.TabIndex = 8;
            grpGioiTinh.TabStop = false;
            grpGioiTinh.Text = "Giới tính";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(310, 47);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(66, 34);
            rdoNu.TabIndex = 1;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(91, 47);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(83, 34);
            rdoNam.TabIndex = 0;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtIDNhanVien
            // 
            txtIDNhanVien.Location = new Point(234, 78);
            txtIDNhanVien.Name = "txtIDNhanVien";
            txtIDNhanVien.Size = new Size(320, 35);
            txtIDNhanVien.TabIndex = 9;
            // 
            // txtIDChucVu
            // 
            txtIDChucVu.Location = new Point(234, 136);
            txtIDChucVu.Name = "txtIDChucVu";
            txtIDChucVu.Size = new Size(320, 35);
            txtIDChucVu.TabIndex = 10;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(234, 198);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(320, 35);
            txtTaiKhoan.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(234, 254);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(320, 35);
            txtMatKhau.TabIndex = 12;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(832, 73);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(320, 35);
            txtTenNhanVien.TabIndex = 13;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(832, 131);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(320, 35);
            txtSdt.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(832, 193);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 35);
            txtEmail.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 326);
            label9.Name = "label9";
            label9.Size = new Size(75, 30);
            label9.TabIndex = 16;
            label9.Text = "Search";
            // 
            // txtSeach
            // 
            txtSeach.Location = new Point(234, 321);
            txtSeach.Name = "txtSeach";
            txtSeach.Size = new Size(320, 35);
            txtSeach.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(150, 385);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 41);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(937, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 41);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(414, 385);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 41);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(657, 385);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(119, 41);
            btnClean.TabIndex = 21;
            btnClean.Text = "CLEAN";
            btnClean.UseVisualStyleBackColor = true;
            // 
            // grpDanhSachNhanVien
            // 
            grpDanhSachNhanVien.Controls.Add(dgvDanhSachNhanVien);
            grpDanhSachNhanVien.Location = new Point(12, 432);
            grpDanhSachNhanVien.Name = "grpDanhSachNhanVien";
            grpDanhSachNhanVien.Size = new Size(1196, 269);
            grpDanhSachNhanVien.TabIndex = 22;
            grpDanhSachNhanVien.TabStop = false;
            grpDanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // dgvDanhSachNhanVien
            // 
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanVien.Location = new Point(6, 34);
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.RowHeadersWidth = 62;
            dgvDanhSachNhanVien.Size = new Size(1184, 225);
            dgvDanhSachNhanVien.TabIndex = 0;
            // 
            // FormQLNhanVien
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 751);
            Controls.Add(grpDanhSachNhanVien);
            Controls.Add(btnClean);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtSeach);
            Controls.Add(label9);
            Controls.Add(txtEmail);
            Controls.Add(txtSdt);
            Controls.Add(txtTenNhanVien);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(txtIDChucVu);
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
            Name = "FormQLNhanVien";
            Text = "FormQLNhanVien";
            grpGioiTinh.ResumeLayout(false);
            grpGioiTinh.PerformLayout();
            grpDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtIDChucVu;
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
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClean;
        private GroupBox grpDanhSachNhanVien;
        private DataGridView dgvDanhSachNhanVien;
    }
}