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
            label1 = new Label();
            grb_thongtindangnhap = new GroupBox();
            btn_thoat = new Button();
            btn_dangnhap = new Button();
            txt_matkhau = new TextBox();
            txt_taikhoan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            grb_thongtindangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(340, 87);
            label1.Name = "label1";
            label1.Size = new Size(465, 59);
            label1.TabIndex = 9;
            label1.Text = "Đăng Nhập Hệ Thống";
            // 
            // grb_thongtindangnhap
            // 
            grb_thongtindangnhap.BackColor = Color.Transparent;
            grb_thongtindangnhap.Controls.Add(btn_thoat);
            grb_thongtindangnhap.Controls.Add(btn_dangnhap);
            grb_thongtindangnhap.Controls.Add(txt_matkhau);
            grb_thongtindangnhap.Controls.Add(txt_taikhoan);
            grb_thongtindangnhap.Controls.Add(label3);
            grb_thongtindangnhap.Controls.Add(label2);
            grb_thongtindangnhap.ForeColor = Color.White;
            grb_thongtindangnhap.Location = new Point(457, 223);
            grb_thongtindangnhap.Name = "grb_thongtindangnhap";
            grb_thongtindangnhap.Size = new Size(561, 299);
            grb_thongtindangnhap.TabIndex = 8;
            grb_thongtindangnhap.TabStop = false;
            grb_thongtindangnhap.Text = "Thông tin đăng nhập";
            grb_thongtindangnhap.Enter += grb_thongtindangnhap_Enter;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.White;
            btn_thoat.ForeColor = Color.Black;
            btn_thoat.Location = new Point(316, 213);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(150, 46);
            btn_thoat.TabIndex = 5;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.BackColor = Color.White;
            btn_dangnhap.ForeColor = Color.Black;
            btn_dangnhap.Location = new Point(68, 213);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(150, 46);
            btn_dangnhap.TabIndex = 4;
            btn_dangnhap.Text = "Đăng nhập";
            btn_dangnhap.UseVisualStyleBackColor = false;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(159, 127);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(335, 39);
            txt_matkhau.TabIndex = 3;
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(159, 58);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(335, 39);
            txt_taikhoan.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 134);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 65);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(111, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(301, 299);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1088, 642);
            Controls.Add(label1);
            Controls.Add(grb_thongtindangnhap);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            grb_thongtindangnhap.ResumeLayout(false);
            grb_thongtindangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grb_thongtindangnhap;
        private Button btn_thoat;
        private Button btn_dangnhap;
        private TextBox txt_matkhau;
        private TextBox txt_taikhoan;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
    }
}