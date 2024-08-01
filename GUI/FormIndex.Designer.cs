namespace GUI
{
    partial class FormIndex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            txt_tieude = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_hoaDon = new Button();
            btn_sanPham = new Button();
            btn_khuyenMai = new Button();
            btn_quanLyNV = new Button();
            btn_quanLyKH = new Button();
            btn_thongTinTK = new Button();
            btn_dangXuat = new Button();
            pn_Body = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txt_tieude);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 51);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1800, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(122, 49);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(55, 46);
            button1.TabIndex = 6;
            button1.Text = "❐";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(60, 0);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(55, 46);
            button2.TabIndex = 2;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txt_tieude
            // 
            txt_tieude.AutoSize = true;
            txt_tieude.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_tieude.Location = new Point(469, 6);
            txt_tieude.Margin = new Padding(2, 0, 2, 0);
            txt_tieude.Name = "txt_tieude";
            txt_tieude.Size = new Size(0, 32);
            txt_tieude.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(482, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(btn_hoaDon);
            flowLayoutPanel1.Controls.Add(btn_sanPham);
            flowLayoutPanel1.Controls.Add(btn_khuyenMai);
            flowLayoutPanel1.Controls.Add(btn_quanLyNV);
            flowLayoutPanel1.Controls.Add(btn_quanLyKH);
            flowLayoutPanel1.Controls.Add(btn_thongTinTK);
            flowLayoutPanel1.Controls.Add(btn_dangXuat);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 51);
            flowLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(185, 999);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btn_hoaDon
            // 
            btn_hoaDon.BackColor = SystemColors.ActiveCaptionText;
            btn_hoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_hoaDon.ForeColor = SystemColors.ButtonHighlight;
            btn_hoaDon.Location = new Point(2, 2);
            btn_hoaDon.Margin = new Padding(2, 2, 2, 2);
            btn_hoaDon.Name = "btn_hoaDon";
            btn_hoaDon.Size = new Size(173, 62);
            btn_hoaDon.TabIndex = 0;
            btn_hoaDon.Text = "\U0001f6d2Hóa đơn";
            btn_hoaDon.UseVisualStyleBackColor = false;
            btn_hoaDon.Click += button1_Click_1;
            // 
            // btn_sanPham
            // 
            btn_sanPham.BackColor = SystemColors.ActiveCaptionText;
            btn_sanPham.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sanPham.ForeColor = SystemColors.ButtonHighlight;
            btn_sanPham.Location = new Point(2, 68);
            btn_sanPham.Margin = new Padding(2, 2, 2, 2);
            btn_sanPham.Name = "btn_sanPham";
            btn_sanPham.Size = new Size(173, 62);
            btn_sanPham.TabIndex = 5;
            btn_sanPham.Text = "Sản phẩm";
            btn_sanPham.UseVisualStyleBackColor = false;
            btn_sanPham.Click += btn_sanPham_Click;
            // 
            // btn_khuyenMai
            // 
            btn_khuyenMai.BackColor = SystemColors.ActiveCaptionText;
            btn_khuyenMai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_khuyenMai.ForeColor = SystemColors.ButtonHighlight;
            btn_khuyenMai.Location = new Point(2, 134);
            btn_khuyenMai.Margin = new Padding(2, 2, 2, 2);
            btn_khuyenMai.Name = "btn_khuyenMai";
            btn_khuyenMai.Size = new Size(173, 62);
            btn_khuyenMai.TabIndex = 6;
            btn_khuyenMai.Text = "Khuyến mãi";
            btn_khuyenMai.UseVisualStyleBackColor = false;
            btn_khuyenMai.Click += btn_khuyenMai_Click;
            // 
            // btn_quanLyNV
            // 
            btn_quanLyNV.BackColor = SystemColors.ActiveCaptionText;
            btn_quanLyNV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_quanLyNV.ForeColor = SystemColors.ButtonHighlight;
            btn_quanLyNV.Location = new Point(2, 200);
            btn_quanLyNV.Margin = new Padding(2, 2, 2, 2);
            btn_quanLyNV.Name = "btn_quanLyNV";
            btn_quanLyNV.Size = new Size(173, 90);
            btn_quanLyNV.TabIndex = 7;
            btn_quanLyNV.Text = "Quản lý nhân viên";
            btn_quanLyNV.UseVisualStyleBackColor = false;
            btn_quanLyNV.Click += btn_quanLyNV_Click;
            // 
            // btn_quanLyKH
            // 
            btn_quanLyKH.BackColor = SystemColors.ActiveCaptionText;
            btn_quanLyKH.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_quanLyKH.ForeColor = SystemColors.ButtonHighlight;
            btn_quanLyKH.Location = new Point(2, 294);
            btn_quanLyKH.Margin = new Padding(2, 2, 2, 2);
            btn_quanLyKH.Name = "btn_quanLyKH";
            btn_quanLyKH.Size = new Size(173, 90);
            btn_quanLyKH.TabIndex = 8;
            btn_quanLyKH.Text = "Quản lý khách hàng";
            btn_quanLyKH.UseVisualStyleBackColor = false;
            btn_quanLyKH.Click += btn_quanLyKH_Click;
            // 
            // btn_thongTinTK
            // 
            btn_thongTinTK.BackColor = SystemColors.ActiveCaptionText;
            btn_thongTinTK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_thongTinTK.ForeColor = SystemColors.ButtonHighlight;
            btn_thongTinTK.Location = new Point(2, 388);
            btn_thongTinTK.Margin = new Padding(2, 2, 2, 2);
            btn_thongTinTK.Name = "btn_thongTinTK";
            btn_thongTinTK.Size = new Size(173, 90);
            btn_thongTinTK.TabIndex = 9;
            btn_thongTinTK.Text = "Thông tin tài khoản";
            btn_thongTinTK.UseVisualStyleBackColor = false;
            btn_thongTinTK.Click += btn_thongTinTK_Click;
            // 
            // btn_dangXuat
            // 
            btn_dangXuat.BackColor = SystemColors.ActiveCaptionText;
            btn_dangXuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangXuat.ForeColor = SystemColors.ButtonHighlight;
            btn_dangXuat.Location = new Point(2, 482);
            btn_dangXuat.Margin = new Padding(2, 2, 2, 2);
            btn_dangXuat.Name = "btn_dangXuat";
            btn_dangXuat.Size = new Size(173, 90);
            btn_dangXuat.TabIndex = 10;
            btn_dangXuat.Text = "Đăng xuất";
            btn_dangXuat.UseVisualStyleBackColor = false;
            btn_dangXuat.Click += button8_Click;
            // 
            // pn_Body
            // 
            pn_Body.BackgroundImageLayout = ImageLayout.None;
            pn_Body.Dock = DockStyle.Fill;
            pn_Body.Location = new Point(185, 51);
            pn_Body.Margin = new Padding(2, 2, 2, 2);
            pn_Body.Name = "pn_Body";
            pn_Body.Size = new Size(1739, 999);
            pn_Body.TabIndex = 3;
            pn_Body.Paint += pn_Body_Paint;
            // 
            // FormIndex
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(pn_Body);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormIndex";
            Text = "Quản lý khách hàng";
            Load += Index_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_hoaDon;
        private Button btn_sanPham;
        private Button btn_khuyenMai;
        private Button btn_quanLyNV;
        private Button btn_quanLyKH;
        private Button btn_thongTinTK;
        private Button btn_dangXuat;
        private Button button2;
        private Panel pn_Body;
        private Label label1;
        private Label txt_tieude;
        private Button button1;
        private Panel panel2;
    }
}
