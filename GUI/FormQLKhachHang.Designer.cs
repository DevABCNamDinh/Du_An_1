namespace GUI
{
    partial class FormQLKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLKhachHang));
            grpGioiTinh = new GroupBox();
            rdo_Nu = new RadioButton();
            rdo_Nam = new RadioButton();
            txt_search = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            txt_email = new TextBox();
            txt_sdt = new TextBox();
            txt_diachi = new TextBox();
            txt_khachhang = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            dtg_hienthi = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            grpGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hienthi).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Controls.Add(rdo_Nu);
            grpGioiTinh.Controls.Add(rdo_Nam);
            grpGioiTinh.Location = new Point(148, 347);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Size = new Size(767, 55);
            grpGioiTinh.TabIndex = 42;
            grpGioiTinh.TabStop = false;
            grpGioiTinh.Text = "Giới tính";
            // 
            // rdo_Nu
            // 
            rdo_Nu.AutoSize = true;
            rdo_Nu.Location = new Point(402, 0);
            rdo_Nu.Name = "rdo_Nu";
            rdo_Nu.Size = new Size(77, 36);
            rdo_Nu.TabIndex = 1;
            rdo_Nu.TabStop = true;
            rdo_Nu.Text = "Nữ";
            rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // rdo_Nam
            // 
            rdo_Nam.AutoSize = true;
            rdo_Nam.Location = new Point(199, 0);
            rdo_Nam.Name = "rdo_Nam";
            rdo_Nam.Size = new Size(96, 36);
            rdo_Nam.TabIndex = 0;
            rdo_Nam.TabStop = true;
            rdo_Nam.Text = "Nam";
            rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(218, 55);
            txt_search.Margin = new Padding(4);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(614, 39);
            txt_search.TabIndex = 41;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(128, 128, 255);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(1447, 480);
            btn_add.Margin = new Padding(4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(150, 46);
            btn_add.TabIndex = 37;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(128, 128, 255);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(1801, 480);
            btn_update.Margin = new Padding(4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(150, 46);
            btn_update.TabIndex = 36;
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(1447, 223);
            txt_email.Margin = new Padding(4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(504, 39);
            txt_email.TabIndex = 35;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(410, 233);
            txt_sdt.Margin = new Padding(4);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(504, 39);
            txt_sdt.TabIndex = 34;
            txt_sdt.KeyPress += txt_sdt_KeyPress;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(1447, 113);
            txt_diachi.Margin = new Padding(4);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(504, 39);
            txt_diachi.TabIndex = 33;
            // 
            // txt_khachhang
            // 
            txt_khachhang.Location = new Point(410, 124);
            txt_khachhang.Margin = new Padding(4);
            txt_khachhang.Name = "txt_khachhang";
            txt_khachhang.Size = new Size(504, 39);
            txt_khachhang.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1186, 230);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 32);
            label8.TabIndex = 30;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(148, 241);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 32);
            label7.TabIndex = 29;
            label7.Text = "Số điện thoại ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1186, 120);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 32);
            label5.TabIndex = 27;
            label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 132);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(183, 32);
            label3.TabIndex = 25;
            label3.Text = "Tên khách hàng";
            // 
            // dtg_hienthi
            // 
            dtg_hienthi.BackgroundColor = SystemColors.InactiveBorder;
            dtg_hienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hienthi.Location = new Point(32, 59);
            dtg_hienthi.Margin = new Padding(4);
            dtg_hienthi.Name = "dtg_hienthi";
            dtg_hienthi.RowHeadersWidth = 62;
            dtg_hienthi.Size = new Size(1942, 460);
            dtg_hienthi.TabIndex = 23;
            dtg_hienthi.CellClick += dtg_hienthi_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_hienthi);
            groupBox1.Location = new Point(120, 820);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(2070, 561);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_khachhang);
            groupBox2.Controls.Add(btn_add);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_sdt);
            groupBox2.Controls.Add(btn_update);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txt_diachi);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(grpGioiTinh);
            groupBox2.Controls.Add(txt_email);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(120, 195);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(2070, 602);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txt_search);
            groupBox3.Location = new Point(120, 29);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(2070, 140);
            groupBox3.TabIndex = 46;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 55);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 44;
            label1.Text = "Tìm kiếm";
            // 
            // FormQLKhachHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 218, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2292, 1178);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormQLKhachHang";
            Text = "FormQLKhachHang";
            Load += FormQLKhachHang_Load;
            grpGioiTinh.ResumeLayout(false);
            grpGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hienthi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpGioiTinh;
        private RadioButton rdo_Nu;
        private RadioButton rdo_Nam;
        private TextBox txt_search;
        private Button btn_add;
        private Button btn_update;
        private TextBox txt_email;
        private TextBox txt_sdt;
        private TextBox txt_diachi;
        private TextBox txt_khachhang;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label3;
        private DataGridView dtg_hienthi;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
    }
}