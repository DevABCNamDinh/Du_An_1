namespace GUI
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
            panel1 = new Panel();
            txtMoTaKM = new TextBox();
            label9 = new Label();
            txtGiamGia = new TextBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateNgayBatDau = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            txtTenKhuyenMai = new TextBox();
            label5 = new Label();
            IDKhuyenMaiCT = new TextBox();
            label4 = new Label();
            txtIDSanPham = new TextBox();
            label3 = new Label();
            txtIDKhuyenMai = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 241, 255);
            panel1.Controls.Add(txtMoTaKM);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtGiamGia);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(dateNgayBatDau);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtTenKhuyenMai);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(IDKhuyenMaiCT);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtIDSanPham);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtIDKhuyenMai);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(812, 58);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 1033);
            panel1.TabIndex = 0;
            // 
            // txtMoTaKM
            // 
            txtMoTaKM.Cursor = Cursors.IBeam;
            txtMoTaKM.Font = new Font("Segoe UI Variable Display", 10.8F);
            txtMoTaKM.Location = new Point(79, 949);
            txtMoTaKM.Margin = new Padding(6);
            txtMoTaKM.Multiline = true;
            txtMoTaKM.Name = "txtMoTaKM";
            txtMoTaKM.Size = new Size(794, 54);
            txtMoTaKM.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display", 10.2F);
            label9.ForeColor = Color.DarkSlateBlue;
            label9.Location = new Point(86, 897);
            label9.Name = "label9";
            label9.Size = new Size(93, 37);
            label9.TabIndex = 15;
            label9.Text = "Mô Tả";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Cursor = Cursors.IBeam;
            txtGiamGia.Font = new Font("Segoe UI Variable Display", 10.8F);
            txtGiamGia.Location = new Point(86, 823);
            txtGiamGia.Margin = new Padding(6);
            txtGiamGia.Multiline = true;
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(787, 54);
            txtGiamGia.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display", 10.2F);
            label8.ForeColor = Color.DarkSlateBlue;
            label8.Location = new Point(86, 770);
            label8.Name = "label8";
            label8.Size = new Size(255, 37);
            label8.TabIndex = 13;
            label8.Text = "Phần trăm giảm giá";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI Variable Display", 9F);
            dateTimePicker1.CalendarForeColor = Color.FromArgb(177, 178, 255);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(177, 178, 255);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(177, 178, 255);
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(177, 178, 255);
            dateTimePicker1.CalendarTrailingForeColor = Color.FromArgb(177, 178, 255);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(563, 710);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(246, 39);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.Value = new DateTime(2022, 12, 16, 21, 3, 0, 0);
            // 
            // dateNgayBatDau
            // 
            dateNgayBatDau.CalendarFont = new Font("Segoe UI Variable Display", 9F);
            dateNgayBatDau.CalendarForeColor = Color.FromArgb(177, 178, 255);
            dateNgayBatDau.CalendarMonthBackground = Color.FromArgb(177, 178, 255);
            dateNgayBatDau.CalendarTitleBackColor = Color.FromArgb(177, 178, 255);
            dateNgayBatDau.CalendarTitleForeColor = Color.FromArgb(177, 178, 255);
            dateNgayBatDau.CalendarTrailingForeColor = Color.FromArgb(177, 178, 255);
            dateNgayBatDau.Format = DateTimePickerFormat.Custom;
            dateNgayBatDau.Location = new Point(86, 710);
            dateNgayBatDau.Name = "dateNgayBatDau";
            dateNgayBatDau.Size = new Size(246, 39);
            dateNgayBatDau.TabIndex = 11;
            dateNgayBatDau.Value = new DateTime(2022, 12, 16, 21, 3, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 10.2F);
            label6.ForeColor = Color.DarkSlateBlue;
            label6.Location = new Point(563, 658);
            label6.Name = "label6";
            label6.Size = new Size(197, 37);
            label6.TabIndex = 10;
            label6.Text = "Ngày Kết Thúc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display", 10.2F);
            label7.ForeColor = Color.DarkSlateBlue;
            label7.Location = new Point(86, 658);
            label7.Name = "label7";
            label7.Size = new Size(185, 37);
            label7.TabIndex = 9;
            label7.Text = "Ngày Bắt Đầu";
            // 
            // txtTenKhuyenMai
            // 
            txtTenKhuyenMai.Cursor = Cursors.IBeam;
            txtTenKhuyenMai.Font = new Font("Segoe UI Variable Display", 10.8F);
            txtTenKhuyenMai.Location = new Point(79, 575);
            txtTenKhuyenMai.Margin = new Padding(6);
            txtTenKhuyenMai.Multiline = true;
            txtTenKhuyenMai.Name = "txtTenKhuyenMai";
            txtTenKhuyenMai.Size = new Size(794, 54);
            txtTenKhuyenMai.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 10.2F);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(79, 522);
            label5.Name = "label5";
            label5.Size = new Size(223, 37);
            label5.TabIndex = 7;
            label5.Text = "Tên Khuyến Mãi*";
            // 
            // IDKhuyenMaiCT
            // 
            IDKhuyenMaiCT.Cursor = Cursors.IBeam;
            IDKhuyenMaiCT.Font = new Font("Segoe UI Variable Display", 10.8F);
            IDKhuyenMaiCT.Location = new Point(563, 401);
            IDKhuyenMaiCT.Margin = new Padding(6);
            IDKhuyenMaiCT.Multiline = true;
            IDKhuyenMaiCT.Name = "IDKhuyenMaiCT";
            IDKhuyenMaiCT.Size = new Size(317, 54);
            IDKhuyenMaiCT.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 10.2F);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(563, 348);
            label4.Name = "label4";
            label4.Size = new Size(310, 37);
            label4.TabIndex = 5;
            label4.Text = "ID Khuyến Mãi Chi Tiết*";
            // 
            // txtIDSanPham
            // 
            txtIDSanPham.Cursor = Cursors.IBeam;
            txtIDSanPham.Font = new Font("Segoe UI Variable Display", 10.8F);
            txtIDSanPham.Location = new Point(86, 401);
            txtIDSanPham.Margin = new Padding(6);
            txtIDSanPham.Multiline = true;
            txtIDSanPham.Name = "txtIDSanPham";
            txtIDSanPham.Size = new Size(304, 54);
            txtIDSanPham.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 10.2F);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(86, 348);
            label3.Name = "label3";
            label3.Size = new Size(183, 37);
            label3.TabIndex = 3;
            label3.Text = "ID Sản Phẩm*";
            // 
            // txtIDKhuyenMai
            // 
            txtIDKhuyenMai.Cursor = Cursors.IBeam;
            txtIDKhuyenMai.Font = new Font("Segoe UI Variable Display", 10.8F);
            txtIDKhuyenMai.Location = new Point(86, 248);
            txtIDKhuyenMai.Margin = new Padding(6);
            txtIDKhuyenMai.Multiline = true;
            txtIDKhuyenMai.Name = "txtIDKhuyenMai";
            txtIDKhuyenMai.Size = new Size(794, 54);
            txtIDKhuyenMai.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 10.2F);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(86, 195);
            label2.Name = "label2";
            label2.Size = new Size(207, 37);
            label2.TabIndex = 1;
            label2.Text = "ID Khuyến Mãi*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Bold);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(191, 65);
            label1.Name = "label1";
            label1.Size = new Size(631, 85);
            label1.TabIndex = 0;
            label1.Text = "THÊM KHUYẾN MÃI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 218, 255);
            ClientSize = new Size(2455, 1341);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKhuyenMai";
            Text = "FormKhuyenMai";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtIDKhuyenMai;
        private Label label2;
        private TextBox IDKhuyenMaiCT;
        private Label label4;
        private TextBox txtIDSanPham;
        private Label label3;
        private DateTimePicker dateNgayBatDau;
        private Label label6;
        private Label label7;
        private TextBox txtTenKhuyenMai;
        private Label label5;
        private TextBox txtMoTaKM;
        private Label label9;
        private TextBox txtGiamGia;
        private Label label8;
        private DateTimePicker dateTimePicker1;
    }
}