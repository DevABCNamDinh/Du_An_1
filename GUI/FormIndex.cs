namespace GUI
{
    public partial class FormIndex : Form
    {

        public FormIndex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            oppenForm(new FormHoaDon());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap dangNhap = new FormDangNhap();
            dangNhap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void btn_sanPham_Click(object sender, EventArgs e)
        {
            oppenForm(new FormSanPham());
        }


        private Form formTam;
        private void oppenForm(Form formChild)
        {
            if (formTam != null)
            {
                formTam.Close();
            }
            formTam = formChild;
            formChild.TopLevel = false;
            formChild.Dock = DockStyle.Fill;
            pn_Body.Controls.Add(formChild);
            pn_Body.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }
        private void pn_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_khuyenMai_Click(object sender, EventArgs e)
        {
            oppenForm(new FormKhuyenMai());
        }

        private void btn_quanLyNV_Click(object sender, EventArgs e)
        {
            oppenForm(new FormQLNhanVien());
        }

        private void btn_quanLyKH_Click(object sender, EventArgs e)
        {
            oppenForm(new FormQLKhachHang());
        }

        private void btn_thongTinTK_Click(object sender, EventArgs e)
        {
            oppenForm(new FormThongTinTK());
        }
    }
}
