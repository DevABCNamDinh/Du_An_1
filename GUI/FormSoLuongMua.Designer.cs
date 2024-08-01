namespace GUI
{
    partial class FormSoLuongMua
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
            label3 = new Label();
            txt_soLuong = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 47);
            label3.Name = "label3";
            label3.Size = new Size(180, 37);
            label3.TabIndex = 1;
            label3.Text = "Số lượng?";
            // 
            // txt_soLuong
            // 
            txt_soLuong.Location = new Point(59, 113);
            txt_soLuong.Name = "txt_soLuong";
            txt_soLuong.Size = new Size(304, 39);
            txt_soLuong.TabIndex = 3;
            txt_soLuong.KeyDown += txt_soLuong_KeyDown;
            // 
            // FormSoLuongMua
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 219);
            Controls.Add(txt_soLuong);
            Controls.Add(label3);
            Name = "FormSoLuongMua";
            Text = "FormSoLuongMua";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txt_soLuong;
    }
}