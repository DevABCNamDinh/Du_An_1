

using Data.data;


namespace GUI

{
    public partial class FormIndex : Form
    {
        NhanVien _nhanVien { get; set; }
        TQLNhanVienBUS _qlnvBUS = new TQLNhanVienBUS();
        FormDangNhap DangNhap;
        private bool isFullScreen = false;
        public FormIndex(NhanVien nv)
        {
            _nhanVien = nv;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {

           
            oppenForm(new FormHoaDon(_nhanVien));

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
            oppenForm(new FormHoaDon(_nhanVien));

        }

        private void btn_sanPham_Click(object sender, EventArgs e)
        {
            oppenForm(new FormSanPham());
        }


        private Form formTam;
        public void oppenForm(Form formChild)
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

            if (_nhanVien.IdchucVu == "CV001" && _nhanVien.TrangThaiLamViec == true)
            {
                oppenForm(new FormQLNhanVien(_nhanVien));
            }
            else if(_nhanVien.IdchucVu == "CV001" && _nhanVien.TrangThaiLamViec == false)
            {
                MessageBox.Show("Bạn không còn quyền truy cập !");
            }
            else
            {
                MessageBox.Show("Bạn không phải Admin. Chỉ Admin mới có quyền truy cập !");
            }

        }

        private void btn_quanLyKH_Click(object sender, EventArgs e)
        {


            oppenForm(new FormQLKhachHang());
        }

        private void btn_thongTinTK_Click(object sender, EventArgs e)
        {

            oppenForm(new FormThongTinTK(_nhanVien));

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (isFullScreen)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

            isFullScreen = !isFullScreen;
        }
    }
}
