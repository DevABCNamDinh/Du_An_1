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
            Nu = new RadioButton();
            Nam = new RadioButton();
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
            rdoFalse = new RadioButton();
            rdoTrue = new RadioButton();
            grpThaoTac = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            label12 = new Label();
            cboLoc = new ComboBox();
            grpDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).BeginInit();
            grpThaoTac.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 30);
            label1.TabIndex = 0;
            label1.Text = "Quản lý nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 159);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 223);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 90);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 3;
            label4.Text = "ID Nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 288);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 416);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 5;
            label6.Text = "Tài khoản";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 476);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 6;
            label7.Text = "Mật khẩu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 354);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 7;
            label8.Text = "Chức vụ";
            // 
            // Nu
            // 
            Nu.AutoSize = true;
            Nu.Location = new Point(475, 39);
            Nu.Margin = new Padding(2);
            Nu.Name = "Nu";
            Nu.Size = new Size(61, 29);
            Nu.TabIndex = 1;
            Nu.TabStop = true;
            Nu.Text = "Nữ";
            Nu.UseVisualStyleBackColor = true;
            // 
            // Nam
            // 
            Nam.AutoSize = true;
            Nam.Location = new Point(248, 41);
            Nam.Margin = new Padding(2);
            Nam.Name = "Nam";
            Nam.Size = new Size(75, 29);
            Nam.TabIndex = 0;
            Nam.TabStop = true;
            Nam.Text = "Nam";
            Nam.UseVisualStyleBackColor = true;
            // 
            // txtIDNhanVien
            // 
            txtIDNhanVien.Location = new Point(323, 84);
            txtIDNhanVien.Margin = new Padding(2);
            txtIDNhanVien.Name = "txtIDNhanVien";
            txtIDNhanVien.ReadOnly = true;
            txtIDNhanVien.Size = new Size(497, 31);
            txtIDNhanVien.TabIndex = 9;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(323, 410);
            txtTaiKhoan.Margin = new Padding(2);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(497, 31);
            txtTaiKhoan.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(323, 470);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(497, 31);
            txtMatKhau.TabIndex = 12;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(323, 153);
            txtTenNhanVien.Margin = new Padding(2);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(497, 31);
            txtTenNhanVien.TabIndex = 13;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(323, 217);
            txtSdt.Margin = new Padding(2);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(497, 31);
            txtSdt.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(323, 282);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(497, 31);
            txtEmail.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 76);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(193, 25);
            label9.TabIndex = 16;
            label9.Text = "Tìm nhân viên theo tên";
            // 
            // txtSeach
            // 
            txtSeach.Location = new Point(266, 70);
            txtSeach.Margin = new Padding(2);
            txtSeach.Name = "txtSeach";
            txtSeach.Size = new Size(770, 31);
            txtSeach.TabIndex = 17;
            txtSeach.TextChanged += txtSeach_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSlateBlue;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(118, 777);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(702, 53);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSlateBlue;
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(118, 855);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(702, 53);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.MediumSlateBlue;
            btnClean.ForeColor = SystemColors.Control;
            btnClean.Location = new Point(118, 931);
            btnClean.Margin = new Padding(2);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(702, 53);
            btnClean.TabIndex = 21;
            btnClean.Text = "CLEAN";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // grpDanhSachNhanVien
            // 
            grpDanhSachNhanVien.Controls.Add(dgvDanhSachNhanVien);
            grpDanhSachNhanVien.Location = new Point(1127, 137);
            grpDanhSachNhanVien.Margin = new Padding(2);
            grpDanhSachNhanVien.Name = "grpDanhSachNhanVien";
            grpDanhSachNhanVien.Padding = new Padding(2);
            grpDanhSachNhanVien.Size = new Size(1195, 1028);
            grpDanhSachNhanVien.TabIndex = 22;
            grpDanhSachNhanVien.TabStop = false;
            grpDanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // dgvDanhSachNhanVien
            // 
            dgvDanhSachNhanVien.BackgroundColor = Color.LightSteelBlue;
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanVien.Location = new Point(4, 28);
            dgvDanhSachNhanVien.Margin = new Padding(2);
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.RowHeadersWidth = 62;
            dgvDanhSachNhanVien.Size = new Size(1187, 996);
            dgvDanhSachNhanVien.TabIndex = 0;
            dgvDanhSachNhanVien.CellClick += dgvDanhSachNhanVien_CellClick;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Nhân viên", "Admin" });
            cboChucVu.Location = new Point(323, 346);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(497, 33);
            cboChucVu.TabIndex = 23;
            // 
            // rdoFalse
            // 
            rdoFalse.AutoSize = true;
            rdoFalse.Location = new Point(475, 41);
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
            rdoTrue.Location = new Point(248, 41);
            rdoTrue.Margin = new Padding(2);
            rdoTrue.Name = "rdoTrue";
            rdoTrue.Size = new Size(114, 29);
            rdoTrue.TabIndex = 0;
            rdoTrue.TabStop = true;
            rdoTrue.Text = "Đang làm";
            rdoTrue.UseVisualStyleBackColor = true;
            // 
            // grpThaoTac
            // 
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
            grpThaoTac.Controls.Add(label5);
            grpThaoTac.Controls.Add(label8);
            grpThaoTac.Controls.Add(txtTenNhanVien);
            grpThaoTac.Controls.Add(txtMatKhau);
            grpThaoTac.Controls.Add(txtSdt);
            grpThaoTac.Controls.Add(txtTaiKhoan);
            grpThaoTac.Controls.Add(txtEmail);
            grpThaoTac.Controls.Add(label7);
            grpThaoTac.Controls.Add(label6);
            grpThaoTac.Location = new Point(42, 137);
            grpThaoTac.Name = "grpThaoTac";
            grpThaoTac.Size = new Size(994, 1028);
            grpThaoTac.TabIndex = 24;
            grpThaoTac.TabStop = false;
            grpThaoTac.Text = "Thao Tác";
            grpThaoTac.Enter += grpThaoTac_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoFalse);
            groupBox2.Controls.Add(rdoTrue);
            groupBox2.Location = new Point(82, 651);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(738, 97);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trạng thái làm việc";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Nu);
            groupBox1.Controls.Add(Nam);
            groupBox1.Location = new Point(82, 539);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 97);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1127, 73);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(242, 25);
            label12.TabIndex = 26;
            label12.Text = "Lọc nhân viên theo trạng thái";
            // 
            // cboLoc
            // 
            cboLoc.FormattingEnabled = true;
            cboLoc.Items.AddRange(new object[] { "Đang làm", "Đã nghỉ" });
            cboLoc.Location = new Point(1397, 65);
            cboLoc.Name = "cboLoc";
            cboLoc.Size = new Size(921, 33);
            cboLoc.TabIndex = 27;
            cboLoc.SelectedIndexChanged += cboLoc_SelectedIndexChanged;
            // 
            // FormQLNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 218, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2460, 1504);
            Controls.Add(cboLoc);
            Controls.Add(label12);
            Controls.Add(grpThaoTac);
            Controls.Add(grpDanhSachNhanVien);
            Controls.Add(txtSeach);
            Controls.Add(label9);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormQLNhanVien";
            Text = "FormQLNhanVien";
            Load += FormQLNhanVien_Load;
            grpDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).EndInit();
            grpThaoTac.ResumeLayout(false);
            grpThaoTac.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TextBox txtIDNhanVien;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
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
        private DataGridView dgvDanhSachNhanVien;
        private ComboBox cboChucVu;
        private RadioButton rdoFalse;
        private RadioButton rdoTrue;
        private GroupBox grpThaoTac;
        private Label label12;
        private ComboBox cboLoc;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}