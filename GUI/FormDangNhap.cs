using BUS;
using Data.DataBase;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDangNhap : Form
    {
        DangNhapBUS dangNhapBUS = new DangNhapBUS();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void grb_thongtindangnhap_Enter(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public NhanVien nv()
        {
            var username = txt_taikhoan.Text;
            var password = txt_matkhau.Text;
            return dangNhapBUS.DangNhap(username, password);

        }
        public void dangNhap()
        {
            var username = txt_taikhoan.Text;
            var password = txt_matkhau.Text;
            if (username == "" && password == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (username == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản ", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (password == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var dangNhap = dangNhapBUS.DangNhap(username, password);
            if (dangNhap != null)
            {
                this.Hide();
                //FormHoaDon formHoaDon = new FormHoaDon(dangNhap);
                //formHoaDon.FormClosed += FormBanHang_FormClosed;
                //formHoaDon.Show();
                FormIndex formIndex = new FormIndex(dangNhap);
                formIndex.FormClosed += FormBanHang_FormClosed;
                formIndex.Show();
                MessageBox.Show("Đăng nhập thành công.", "Đăng nhập", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {


        }

        private void FormBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Đóng form đăng nhập khi form bán hàng đóng
            this.Close();
        }

        private void txt_taikhoan_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangNhap();
            }
        }

        private void btn_dangnhap_Click_1(object sender, EventArgs e)
        {
            dangNhap();

        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt_taikhoan_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangNhap();
            }
        }

        private void txt_matkhau_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangNhap();
            }
        }
    }
}
