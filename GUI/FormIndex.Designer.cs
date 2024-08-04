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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            btn_hoaDon = new Button();
            btn_sanPham = new Button();
            btn_khuyenMai = new Button();
            btn_quanLyNV = new Button();
            btn_quanLyKH = new Button();
            btn_quanlyhoadon = new Button();
            btn_thongTinTK = new Button();
            btn_dangXuat = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pn_Body = new Panel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Orange;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(btn_hoaDon);
            flowLayoutPanel1.Controls.Add(btn_sanPham);
            flowLayoutPanel1.Controls.Add(btn_khuyenMai);
            flowLayoutPanel1.Controls.Add(btn_quanLyNV);
            flowLayoutPanel1.Controls.Add(btn_quanLyKH);
            flowLayoutPanel1.Controls.Add(btn_quanlyhoadon);
            flowLayoutPanel1.Controls.Add(btn_thongTinTK);
            flowLayoutPanel1.Controls.Add(btn_dangXuat);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(536, 1759);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(528, 249);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btn_hoaDon
            // 
            btn_hoaDon.BackColor = SystemColors.ActiveCaptionText;
            btn_hoaDon.BackgroundImage = (Image)resources.GetObject("btn_hoaDon.BackgroundImage");
            btn_hoaDon.BackgroundImageLayout = ImageLayout.Stretch;
            btn_hoaDon.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btn_hoaDon.ForeColor = Color.Black;
            btn_hoaDon.Location = new Point(4, 261);
            btn_hoaDon.Margin = new Padding(4);
            btn_hoaDon.Name = "btn_hoaDon";
            btn_hoaDon.Size = new Size(532, 148);
            btn_hoaDon.TabIndex = 0;
            btn_hoaDon.Text = "\U0001f6d2Hóa đơn";
            btn_hoaDon.UseVisualStyleBackColor = false;
            btn_hoaDon.Click += button1_Click_1;
            // 
            // btn_sanPham
            // 
            btn_sanPham.BackColor = SystemColors.ActiveCaptionText;
            btn_sanPham.BackgroundImage = (Image)resources.GetObject("btn_sanPham.BackgroundImage");
            btn_sanPham.BackgroundImageLayout = ImageLayout.Stretch;
            btn_sanPham.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btn_sanPham.ForeColor = Color.Black;
            btn_sanPham.Location = new Point(4, 417);
            btn_sanPham.Margin = new Padding(4);
            btn_sanPham.Name = "btn_sanPham";
            btn_sanPham.Size = new Size(532, 148);
            btn_sanPham.TabIndex = 5;
            btn_sanPham.Text = "Sản phẩm";
            btn_sanPham.UseVisualStyleBackColor = false;
            btn_sanPham.Click += btn_sanPham_Click;
            // 
            // btn_khuyenMai
            // 
            btn_khuyenMai.BackColor = SystemColors.ActiveCaptionText;
            btn_khuyenMai.BackgroundImage = (Image)resources.GetObject("btn_khuyenMai.BackgroundImage");
            btn_khuyenMai.BackgroundImageLayout = ImageLayout.Stretch;
            btn_khuyenMai.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btn_khuyenMai.ForeColor = Color.Black;
            btn_khuyenMai.Location = new Point(4, 573);
            btn_khuyenMai.Margin = new Padding(4);
            btn_khuyenMai.Name = "btn_khuyenMai";
            btn_khuyenMai.Size = new Size(528, 145);
            btn_khuyenMai.TabIndex = 6;
            btn_khuyenMai.Text = "Khuyến mãi";
            btn_khuyenMai.UseVisualStyleBackColor = false;
            btn_khuyenMai.Click += btn_khuyenMai_Click;
            // 
            // btn_quanLyNV
            // 
            btn_quanLyNV.BackColor = SystemColors.ActiveCaptionText;
            btn_quanLyNV.BackgroundImage = (Image)resources.GetObject("btn_quanLyNV.BackgroundImage");
            btn_quanLyNV.BackgroundImageLayout = ImageLayout.Stretch;
            btn_quanLyNV.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btn_quanLyNV.ForeColor = Color.Black;
            btn_quanLyNV.Location = new Point(4, 726);
            btn_quanLyNV.Margin = new Padding(4);
            btn_quanLyNV.Name = "btn_quanLyNV";
            btn_quanLyNV.Size = new Size(528, 189);
            btn_quanLyNV.TabIndex = 7;
            btn_quanLyNV.Text = "Quản lý nhân viên";
            btn_quanLyNV.UseVisualStyleBackColor = false;
            btn_quanLyNV.Click += btn_quanLyNV_Click;
            // 
            // btn_quanLyKH
            // 
            btn_quanLyKH.BackColor = SystemColors.ActiveCaptionText;
            btn_quanLyKH.BackgroundImage = (Image)resources.GetObject("btn_quanLyKH.BackgroundImage");
            btn_quanLyKH.BackgroundImageLayout = ImageLayout.Stretch;
            btn_quanLyKH.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btn_quanLyKH.ForeColor = Color.Black;
            btn_quanLyKH.Location = new Point(4, 923);
            btn_quanLyKH.Margin = new Padding(4);
            btn_quanLyKH.Name = "btn_quanLyKH";
            btn_quanLyKH.Size = new Size(528, 189);
            btn_quanLyKH.TabIndex = 8;
            btn_quanLyKH.Text = "Quản lý khách hàng";
            btn_quanLyKH.UseVisualStyleBackColor = false;
            btn_quanLyKH.Click += btn_quanLyKH_Click;
            // 
            // btn_quanlyhoadon
            // 
            btn_quanlyhoadon.BackColor = SystemColors.ActiveCaptionText;
            btn_quanlyhoadon.BackgroundImage = (Image)resources.GetObject("btn_quanlyhoadon.BackgroundImage");
            btn_quanlyhoadon.BackgroundImageLayout = ImageLayout.Stretch;
            btn_quanlyhoadon.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btn_quanlyhoadon.ForeColor = Color.Black;
            btn_quanlyhoadon.Location = new Point(4, 1120);
            btn_quanlyhoadon.Margin = new Padding(4);
            btn_quanlyhoadon.Name = "btn_quanlyhoadon";
            btn_quanlyhoadon.Size = new Size(528, 189);
            btn_quanlyhoadon.TabIndex = 11;
            btn_quanlyhoadon.Text = "Quản lý hóa đơn";
            btn_quanlyhoadon.UseVisualStyleBackColor = false;
            btn_quanlyhoadon.Click += btn_quanlyhoadon_Click;
            // 
            // btn_thongTinTK
            // 
            btn_thongTinTK.BackColor = SystemColors.ActiveCaptionText;
            btn_thongTinTK.BackgroundImage = (Image)resources.GetObject("btn_thongTinTK.BackgroundImage");
            btn_thongTinTK.BackgroundImageLayout = ImageLayout.Stretch;
            btn_thongTinTK.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btn_thongTinTK.ForeColor = Color.Black;
            btn_thongTinTK.Location = new Point(4, 1317);
            btn_thongTinTK.Margin = new Padding(4);
            btn_thongTinTK.Name = "btn_thongTinTK";
            btn_thongTinTK.Size = new Size(528, 189);
            btn_thongTinTK.TabIndex = 9;
            btn_thongTinTK.Text = "Thông tin tài khoản";
            btn_thongTinTK.UseVisualStyleBackColor = false;
            btn_thongTinTK.Click += btn_thongTinTK_Click;
            // 
            // btn_dangXuat
            // 
            btn_dangXuat.BackColor = Color.White;
            btn_dangXuat.BackgroundImageLayout = ImageLayout.Stretch;
            btn_dangXuat.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btn_dangXuat.ForeColor = Color.Black;
            btn_dangXuat.Location = new Point(4, 1514);
            btn_dangXuat.Margin = new Padding(4);
            btn_dangXuat.Name = "btn_dangXuat";
            btn_dangXuat.Size = new Size(524, 221);
            btn_dangXuat.TabIndex = 10;
            btn_dangXuat.Text = "Đăng xuất";
            btn_dangXuat.UseVisualStyleBackColor = false;
            btn_dangXuat.Click += button8_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(536, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2348, 153);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(920, 12);
            label1.Name = "label1";
            label1.Size = new Size(569, 104);
            label1.TabIndex = 0;
            label1.Text = "Sunscreen FPL";
            // 
            // pn_Body
            // 
            pn_Body.BackColor = Color.White;
            pn_Body.Dock = DockStyle.Fill;
            pn_Body.Location = new Point(536, 153);
            pn_Body.Name = "pn_Body";
            pn_Body.Size = new Size(2348, 1606);
            pn_Body.TabIndex = 0;
            // 
            // FormIndex
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2884, 1759);
            Controls.Add(pn_Body);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Name = "FormIndex";
            Text = "Quản lý khách hàng";
            Load += Index_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_hoaDon;
        private Button btn_sanPham;
        private Button btn_khuyenMai;
        private Button btn_quanLyNV;
        private Button btn_quanLyKH;
        private Button btn_thongTinTK;
        private Button btn_dangXuat;
        private Button btn_quanlyhoadon;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Panel pn_Body;
    }
}
