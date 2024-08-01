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
            grpGioiTinh = new GroupBox();
            rdo_Nu = new RadioButton();
            rdo_Nam = new RadioButton();
            txt_search = new TextBox();
            btn_cleah = new Button();
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
            label1 = new Label();
            btn_Search = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            grpGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hienthi).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Controls.Add(rdo_Nu);
            grpGioiTinh.Controls.Add(rdo_Nam);
            grpGioiTinh.Location = new Point(60, 460);
            grpGioiTinh.Margin = new Padding(2);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Padding = new Padding(2);
            grpGioiTinh.Size = new Size(590, 156);
            grpGioiTinh.TabIndex = 42;
            grpGioiTinh.TabStop = false;
            grpGioiTinh.Text = "Giới tính";
            // 
            // rdo_Nu
            // 
            rdo_Nu.AutoSize = true;
            rdo_Nu.Location = new Point(373, 58);
            rdo_Nu.Margin = new Padding(2);
            rdo_Nu.Name = "rdo_Nu";
            rdo_Nu.Size = new Size(61, 29);
            rdo_Nu.TabIndex = 1;
            rdo_Nu.TabStop = true;
            rdo_Nu.Text = "Nữ";
            rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // rdo_Nam
            // 
            rdo_Nam.AutoSize = true;
            rdo_Nam.Location = new Point(126, 58);
            rdo_Nam.Margin = new Padding(2);
            rdo_Nam.Name = "rdo_Nam";
            rdo_Nam.Size = new Size(75, 29);
            rdo_Nam.TabIndex = 0;
            rdo_Nam.TabStop = true;
            rdo_Nam.Text = "Nam";
            rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(276, 72);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(473, 31);
            txt_search.TabIndex = 41;
            // 
            // btn_cleah
            // 
            btn_cleah.Location = new Point(124, 780);
            btn_cleah.Name = "btn_cleah";
            btn_cleah.Size = new Size(411, 40);
            btn_cleah.TabIndex = 39;
            btn_cleah.Text = "CLEAH";
            btn_cleah.UseVisualStyleBackColor = true;
            btn_cleah.Click += btn_cleah_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(124, 621);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(411, 40);
            btn_add.TabIndex = 37;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(124, 700);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(411, 40);
            btn_update.TabIndex = 36;
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(261, 348);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(389, 31);
            txt_email.TabIndex = 35;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(261, 175);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(389, 31);
            txt_sdt.TabIndex = 34;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(261, 261);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(389, 31);
            txt_diachi.TabIndex = 33;
            // 
            // txt_khachhang
            // 
            txt_khachhang.Location = new Point(261, 90);
            txt_khachhang.Name = "txt_khachhang";
            txt_khachhang.Size = new Size(389, 31);
            txt_khachhang.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 354);
            label8.Name = "label8";
            label8.Size = new Size(54, 25);
            label8.TabIndex = 30;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 181);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 29;
            label7.Text = "Số điện thoại ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 267);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 27;
            label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 96);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 25;
            label3.Text = "Tên khách hàng";
            // 
            // dtg_hienthi
            // 
            dtg_hienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hienthi.Location = new Point(8, 30);
            dtg_hienthi.Name = "dtg_hienthi";
            dtg_hienthi.RowHeadersWidth = 62;
            dtg_hienthi.Size = new Size(1063, 744);
            dtg_hienthi.TabIndex = 23;
            dtg_hienthi.CellClick += dtg_hienthi_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 22;
            label1.Text = "Nhập thông tin";
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(46, 64);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(105, 39);
            btn_Search.TabIndex = 43;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_hienthi);
            groupBox1.Location = new Point(819, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1077, 780);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_khachhang);
            groupBox2.Controls.Add(btn_cleah);
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
            groupBox2.Location = new Point(46, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(703, 879);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // FormQLKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 218, 255);
            ClientSize = new Size(1946, 1106);
            Controls.Add(groupBox2);
            Controls.Add(txt_search);
            Controls.Add(btn_Search);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormQLKhachHang";

            Text = "FormQLKhachHang";
            Load += FormQLKhachHang_Load;

           
            grpGioiTinh.ResumeLayout(false);
            grpGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hienthi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpGioiTinh;
        private RadioButton rdo_Nu;
        private RadioButton rdo_Nam;
        private TextBox txt_search;
        private Button btn_cleah;
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
        private Label label1;
        private Button btn_Search;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}