namespace GUI
{
    partial class FormSanPham
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
            btnAddSp = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnUpdateSp = new Button();
            btnClearSp = new Button();
            btnDeleteSp = new Button();
            txtIdSanPham = new TextBox();
            txtTenSanPham = new TextBox();
            txtSoLuong = new TextBox();
            txtNguonGoc = new TextBox();
            label5 = new Label();
            txtTimKiemSp = new TextBox();
            dgvSanPham = new DataGridView();
            grpdssanpham = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            grpdssanpham.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddSp
            // 
            btnAddSp.Location = new Point(1110, 329);
            btnAddSp.Name = "btnAddSp";
            btnAddSp.Size = new Size(150, 46);
            btnAddSp.TabIndex = 1;
            btnAddSp.Text = "ADD";
            btnAddSp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            label1.Location = new Point(62, 111);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 2;
            label1.Text = "ID Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            label2.Location = new Point(62, 195);
            label2.Name = "label2";
            label2.Size = new Size(195, 37);
            label2.TabIndex = 3;
            label2.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            label3.Location = new Point(62, 290);
            label3.Name = "label3";
            label3.Size = new Size(138, 37);
            label3.TabIndex = 4;
            label3.Text = "Số Lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            label4.Location = new Point(62, 396);
            label4.Name = "label4";
            label4.Size = new Size(160, 37);
            label4.TabIndex = 5;
            label4.Text = "Nguồn Gốc";
            // 
            // btnUpdateSp
            // 
            btnUpdateSp.Location = new Point(1342, 329);
            btnUpdateSp.Name = "btnUpdateSp";
            btnUpdateSp.Size = new Size(150, 46);
            btnUpdateSp.TabIndex = 8;
            btnUpdateSp.Text = "UPDATE";
            btnUpdateSp.UseVisualStyleBackColor = true;
            // 
            // btnClearSp
            // 
            btnClearSp.Location = new Point(1110, 463);
            btnClearSp.Name = "btnClearSp";
            btnClearSp.Size = new Size(150, 46);
            btnClearSp.TabIndex = 9;
            btnClearSp.Text = "CLEAR";
            btnClearSp.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSp
            // 
            btnDeleteSp.Location = new Point(1342, 463);
            btnDeleteSp.Name = "btnDeleteSp";
            btnDeleteSp.Size = new Size(150, 46);
            btnDeleteSp.TabIndex = 10;
            btnDeleteSp.Text = "DELETE";
            btnDeleteSp.UseVisualStyleBackColor = true;
            // 
            // txtIdSanPham
            // 
            txtIdSanPham.Location = new Point(301, 112);
            txtIdSanPham.Name = "txtIdSanPham";
            txtIdSanPham.Size = new Size(200, 39);
            txtIdSanPham.TabIndex = 11;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(301, 195);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(200, 39);
            txtTenSanPham.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(301, 291);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(200, 39);
            txtSoLuong.TabIndex = 13;
            // 
            // txtNguonGoc
            // 
            txtNguonGoc.Location = new Point(301, 396);
            txtNguonGoc.Name = "txtNguonGoc";
            txtNguonGoc.Size = new Size(200, 39);
            txtNguonGoc.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(747, 119);
            label5.Name = "label5";
            label5.Size = new Size(102, 37);
            label5.TabIndex = 16;
            label5.Text = "Sreach";
            // 
            // txtTimKiemSp
            // 
            txtTimKiemSp.Location = new Point(904, 116);
            txtTimKiemSp.Name = "txtTimKiemSp";
            txtTimKiemSp.Size = new Size(532, 39);
            txtTimKiemSp.TabIndex = 17;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(6, 38);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 82;
            dgvSanPham.Size = new Size(1450, 345);
            dgvSanPham.TabIndex = 18;
            // 
            // grpdssanpham
            // 
            grpdssanpham.Controls.Add(dgvSanPham);
            grpdssanpham.Location = new Point(79, 548);
            grpdssanpham.Name = "grpdssanpham";
            grpdssanpham.Size = new Size(1462, 389);
            grpdssanpham.TabIndex = 19;
            grpdssanpham.TabStop = false;
            grpdssanpham.Text = "Danh Sach San Pham";
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1580, 961);
            Controls.Add(grpdssanpham);
            Controls.Add(txtTimKiemSp);
            Controls.Add(label5);
            Controls.Add(txtNguonGoc);
            Controls.Add(txtSoLuong);
            Controls.Add(txtTenSanPham);
            Controls.Add(txtIdSanPham);
            Controls.Add(btnDeleteSp);
            Controls.Add(btnClearSp);
            Controls.Add(btnUpdateSp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddSp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSanPham";
            Text = "FormSanPham";
            Load += FormSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            grpdssanpham.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddSp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnUpdateSp;
        private Button btnClearSp;
        private Button btnDeleteSp;
        private TextBox txtIdSanPham;
        private TextBox txtTenSanPham;
        private TextBox txtSoLuong;
        private TextBox txtNguonGoc;
        private Label label5;
        private TextBox txtTimKiemSp;
        private DataGridView dgvSanPham;
        private GroupBox grpdssanpham;
    }
}