namespace GUI
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            grb_thongtindangnhap = new GroupBox();
            btn_thoat = new Button();
            btn_dangnhap = new Button();
            txt_matkhau = new TextBox();
            txt_taikhoan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            grb_thongtindangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grb_thongtindangnhap
            // 
            grb_thongtindangnhap.BackColor = Color.Black;
            grb_thongtindangnhap.BackgroundImage = (Image)resources.GetObject("grb_thongtindangnhap.BackgroundImage");
            grb_thongtindangnhap.BackgroundImageLayout = ImageLayout.Stretch;
            grb_thongtindangnhap.Controls.Add(btn_thoat);
            grb_thongtindangnhap.Controls.Add(btn_dangnhap);
            grb_thongtindangnhap.Controls.Add(txt_matkhau);
            grb_thongtindangnhap.Controls.Add(txt_taikhoan);
            grb_thongtindangnhap.Controls.Add(label3);
            grb_thongtindangnhap.Controls.Add(label2);
            grb_thongtindangnhap.ForeColor = Color.Black;
            grb_thongtindangnhap.Location = new Point(558, 206);
            grb_thongtindangnhap.Name = "grb_thongtindangnhap";
            grb_thongtindangnhap.Size = new Size(697, 330);
            grb_thongtindangnhap.TabIndex = 12;
            grb_thongtindangnhap.TabStop = false;
            grb_thongtindangnhap.Text = "Thông tin đăng nhập";
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.White;
            btn_thoat.ForeColor = Color.Black;
            btn_thoat.Location = new Point(463, 245);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(150, 46);
            btn_thoat.TabIndex = 5;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click_1;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.BackColor = Color.White;
            btn_dangnhap.ForeColor = Color.Black;
            btn_dangnhap.Location = new Point(105, 245);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(150, 46);
            btn_dangnhap.TabIndex = 4;
            btn_dangnhap.Text = "Đăng nhập";
            btn_dangnhap.UseVisualStyleBackColor = false;
            btn_dangnhap.Click += btn_dangnhap_Click_1;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(275, 144);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(352, 39);
            txt_matkhau.TabIndex = 3;
            txt_matkhau.KeyDown += txt_matkhau_KeyDown_1;
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(275, 75);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(352, 39);
            txt_taikhoan.TabIndex = 2;
            txt_taikhoan.KeyDown += txt_taikhoan_KeyDown_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(71, 151);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(71, 82);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(404, 81);
            label4.Name = "label4";
            label4.Size = new Size(545, 71);
            label4.TabIndex = 6;
            label4.Text = "Đăng nhập hệ thống";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1303, 774);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(grb_thongtindangnhap);
            DoubleBuffered = true;
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            grb_thongtindangnhap.ResumeLayout(false);
            grb_thongtindangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grb_thongtindangnhap;
        private Button btn_thoat;
        private Button btn_dangnhap;
        private TextBox txt_matkhau;
        private TextBox txt_taikhoan;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
    }
}