using BUS;
using DAL;



using Data.Data;



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormThongTinTK : Form
    {
        DChucVuBUS _chucvuBUS = new DChucVuBUS();
        TQLNhanVienBUS _qlnvBUS = new TQLNhanVienBUS();
        DQLNhanVienDAL X = new DQLNhanVienDAL();
        NhanVien NhanVien { get; set; }
        public FormThongTinTK(NhanVien nv)
        {
            InitializeComponent();
            NhanVien = nv;


        }


        private void FormThongTinTK_Load(object sender, EventArgs e)
        {
            LoadTTTK();
        }



        public void LoadTTTK()
        {
            HamClear();
            var nv = X.GetNhanVienByID(NhanVien.IdnhanVien);

            txtIDNhanVien.Text = nv.IdnhanVien;
            txtHoVaTen.Text = nv.TenNhanVien;
            txtTenDangNhap.Text = nv.Taikhoan;
            txtMatKhau.Text = nv.MatKhau;
           

            //txtChucVu.Text = NhanVien.IdchucVu;
            txtChucVu.Text = _chucvuBUS.Getbyid(nv.IdchucVu).ChucVu1;

            txtEmail.Text = nv.Email;
            txtSdt.Text = nv.Sdt;
            if (nv.GioiTinh == true)
            {
                rdoNam.Checked = true;
            }
            else { rdoNu.Checked = true; }
        }



        public void HamClear()
        {
            txtIDNhanVien.Clear();
            txtHoVaTen.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtChucVu.Clear();
            txtEmail.Clear();
            txtSdt.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var update = _qlnvBUS.GetnhanvienByID(NhanVien.IdnhanVien);
            bool gioitinh = false;
            if (rdoNam.Checked)
            {
                gioitinh = true;
            }
            else if (rdoNu.Checked)
            {
                gioitinh = false;
            }
            update.TenNhanVien = txtHoVaTen.Text;
            update.Taikhoan = txtTenDangNhap.Text;
            update.MatKhau = txtMatKhau.Text;
            update.Email = txtEmail.Text;
            update.Sdt = txtSdt.Text;
            update.GioiTinh = gioitinh;

            DialogResult dl = MessageBox.Show("Ban có muốn sửa không?", "Sửa thành công", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                string kq = _qlnvBUS.Update2(update);
              
                SendMailUpdate();
                MessageBox.Show(kq);
                return;

            }
            LoadTTTK();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void SendMailUpdate()
        {
            string fromEmail = "trungbdph49009@gmail.com";
            string toEmail = txtEmail.Text.Trim();
            string pass = "idrk sger pfbu mdvv";
            string tieude = "SUNSCREEN - THÔNG BÁO CẬP NHẬT THÔNG TIN";
            string content = $"Xin chào {txtHoVaTen.Text}, Thông tin cá nhân của bạn trên hệ thống Sunscreen FPL đã được bạn cập nhật. Vui lòng kiểm tra lại thông tin mới: ";
            string id = $"ID nhân viên: {txtIDNhanVien.Text}";
            string ten = $"Họ và tên: {txtHoVaTen.Text}";
            string sdt = $"Số điện thoại: {txtSdt.Text}";
            string email = $"Emai: {txtEmail.Text}";
            string chucvu = $"Chức vụ: {txtChucVu.Text}";
            string tk = $"Tên đăng nhập: {txtTenDangNhap.Text}";
            string mk = $"Mật khẩu: {txtMatKhau.Text}";

            string thongdiep = "Nếu thông tin cá nhân không chính xác, vui lòng liên hệ với quản lý !";

            MailMessage mail = new MailMessage();
            mail.To.Add(toEmail);
            mail.From = new MailAddress(fromEmail);
            mail.Subject = tieude;
            mail.Body = content + "\n" + id + "\n" + ten + "\n" + sdt + "\n" + email + "\n" + chucvu + "\n" + tk + "\n" + mk + "\n" + thongdiep;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromEmail, pass); // fromEmail: email người gửi, pass: mật khẩu email người gửi
            try
            {
                smtp.Send(mail);
                //MessageBox.Show("đã gửi email");
            }
            catch (Exception ex)
            {
                MessageBox.Show("gửi email thất bại");
            }
        }
    }
}
