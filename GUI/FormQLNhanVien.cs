using BUS;

using System.Text.RegularExpressions;



using Data.Modee;
using System.Net;
using System.Net.Mail;






using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace GUI
{
    public partial class FormQLNhanVien : Form
    {

        NhanVien NhanVien { get; set; }
        TQLNhanVienBUS _qlnvBUS = new TQLNhanVienBUS();

        DChucVuBUS _chucvuBUS = new DChucVuBUS();

        List<string> _lstchucvu = new List<string>();

        private string _idCellClick;
        public FormQLNhanVien(NhanVien nv)
        {
            InitializeComponent();
            LoadGrid(dtgv_thongtinNhanVien, null);
            NhanVien = nv;
        }




        public void LoadGrid(DataGridView dataGridView, string input)
        {

            int stt = 1;

            dataGridView.ColumnCount = 9;

            dataGridView.Columns[0].Name = "STT";
            dataGridView.Columns[1].Name = "ID nhân viên";
            dataGridView.Columns[2].Name = "Chức vụ";
            dataGridView.Columns[3].Name = "Tên nhân viên";
            dataGridView.Columns[4].Name = "Email";
            dataGridView.Columns[5].Name = "Sđt";
            dataGridView.Columns[6].Name = "Giới tính";
            dataGridView.Columns[7].Name = "Tài khoản";
            dataGridView.Columns[8].Name = "Trạng thái làm việc";

            dataGridView.Rows.Clear();



            foreach (var item in _qlnvBUS.GetAllNV(input))
            {
                string gioitinh;
                if (item.GioiTinh == true)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }

                string trangthai;
                if (item.TrangThaiLamViec == true)
                {
                    trangthai = "Đang làm";
                }
                else
                {
                    trangthai = "Đã nghỉ";
                }
                var tenchucvu = _chucvuBUS.Getbyid(item.IdchucVu).ChucVu1;
                dataGridView.Rows.Add(stt++, item.IdnhanVien, tenchucvu, item.TenNhanVien, item.Email, item.Sdt, gioitinh, item.Taikhoan, /*item.MatKhau,*/ trangthai);
            }
        }





        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            dtgv_thongtinNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }






        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool gioitinh = false;
            if (Nam.Checked == true)
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }

            bool trangthailamviec = false;
            if (rdoTrue.Checked == true)
            {
                trangthailamviec = true;
            }
            else
            {
                trangthailamviec = false;
            }
            string idChucvu = "";
            if (cboChucVu.Text == "Admin")
            {
                idChucvu = "CV001";
            }
            else if (cboChucVu.Text == "Nhân viên")
            {
                idChucvu = "CV002";
            }



            
            NhanVien nhanVien = new NhanVien()
            {
                //IdnhanVien = txtIDNhanVien.Text,
                IdnhanVien = "NV" + (_qlnvBUS.Getallnhanvien().Count + 1),
                IdchucVu = idChucvu,
                TenNhanVien = txtTenNhanVien.Text,
                Email = txtEmail.Text,
                Sdt = txtSdt.Text,
                GioiTinh = gioitinh,
                Taikhoan = txtTaiKhoan.Text,
                MatKhau = txtMatKhau.Text,
                TrangThaiLamViec = trangthailamviec,
            };

            if (cboChucVu.Text == "" || txtTaiKhoan.Text == "" || txtMatKhau.Text == "" ||
                txtTenNhanVien.Text == "" || txtSdt.Text == "" || txtEmail.Text == "" ||
                (Nam.Checked == false && Nu.Checked == false) || (rdoTrue.Checked == false && rdoFalse.Checked == false))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else if (txtSdt.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ !");
            }

            else if (rdoFalse.Checked == true)
            {
                MessageBox.Show("Nhân viên thêm mới phải ở trạng thái 'Đang làm' !");
            }

            else if(txtSdt.Text.Length == 10)
            {
                string phoneNumber = txtSdt.Text; // số điện thoại cần kiểm tra
                string emailCheck = txtEmail.Text;
                if (IsValidPhoneNumber(phoneNumber))
                {
                    if (IsValidEmail(emailCheck))
                    {
                        if (_qlnvBUS.Create(nhanVien))
                        {
                            SendMail();
                            MessageBox.Show("Thêm nhân viên thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thất bại");
                        }

                    }
                    

                    txtMatKhau.Clear();
                    LoadGrid(dtgv_thongtinNhanVien, null);
                    
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.");
                }
            }

        }


        static bool IsValidEmail(string email)
        {
            // Kiểm tra định dạng email bằng regular expression
            string emailPattern = @"^[a-zA-Z0-9]+@(gmail)+\.(com)$";
            var a = Regex.IsMatch(email, emailPattern);
            if (!a)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng gmail !");
                return false;
            }
            return true;
        }


        static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Biểu thức chính quy để kiểm tra số điện thoại chỉ chứa số
            string pattern = @"^\d+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }







        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIDNhanVien.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để Cập nhật !");
            }
            else
            {
                if (cboChucVu.Text == "" || txtTaiKhoan.Text == "" ||
                txtTenNhanVien.Text == "" || txtSdt.Text == "" || txtEmail.Text == "" ||
                (Nam.Checked == false && Nu.Checked == false) || (rdoTrue.Checked == false && rdoFalse.Checked == false))
                {
                    MessageBox.Show("Vui lòng không để trống thông tin !");
                }
                else
                {
                    string idnhanvien = txtIDNhanVien.Text;
                    string idchucvu = "";
                    if (cboChucVu.Text == "Admin")
                    {
                        idchucvu = "CV001";
                    }
                    else if (cboChucVu.Text == "Nhân viên")
                    {
                        idchucvu = "CV002";
                    }
                    string tennhanvien = txtTenNhanVien.Text;
                    string email = txtEmail.Text;
                    string sdt = txtSdt.Text;


                    bool gioitinh = false;
                    if (Nam.Checked)
                    {
                        gioitinh = true;
                    }
                    else if (Nu.Checked)
                    {
                        gioitinh = false;
                    }
                    string taikhoan = txtTaiKhoan.Text;
                    //string matkhau = txtMatKhau.Text;


                    bool trangthai = false;
                    if (rdoTrue.Checked)
                    {
                        trangthai = true;
                    }
                    else if (rdoFalse.Checked)
                    {
                        trangthai = false;
                    }


                    DialogResult dl = MessageBox.Show("Ban có muốn sửa không?", "Sửa thành công", MessageBoxButtons.YesNo);
                    if (dl == DialogResult.Yes)
                    {
                        
                        if (txtMatKhau.Text != "")
                        {
                            MessageBox.Show("Bạn không thể thay đổi mật khẩu !");
                            txtMatKhau.Clear();
                        }
                        else if (txtSdt.Text.Length != 10)
                        {
                            MessageBox.Show("Số điện thoại không hợp lệ !");
                        }
                        else if (txtSdt.Text.Length == 10)
                        {
                            string phoneNumber = txtSdt.Text;
                            if (IsValidPhoneNumber(phoneNumber))
                            {
                                if (IsValidPhoneNumber(phoneNumber))
                                {
                                    string kq = _qlnvBUS.Update(idnhanvien, idchucvu, tennhanvien, email, sdt, gioitinh, taikhoan, /*matkhau,*/ trangthai);

                                    SendMailUpdate();
                                    MessageBox.Show(kq);

                                    LoadGrid(dtgv_thongtinNhanVien, null);
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Số điện thoại không hợp lệ.");
                                }
                                txtMatKhau.Clear();
                                LoadGrid(dtgv_thongtinNhanVien, null);

                            }

                        }
                        else
                        {
                            //SendMailUpdate();
                        }

                    }
                    else if (dl == DialogResult.No)
                    {
                        LoadGrid(dtgv_thongtinNhanVien, null);
                        return;
                    }
                    
                }
            }

           
        }


        public void Clear()
        {
            cboChucVu.Text = "";
            txtIDNhanVien.Clear();
            txtEmail.Clear();
            txtSdt.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtTenNhanVien.Clear();
            Nam.Checked = false;
            Nu.Checked = false;
            rdoTrue.Checked = false;
            rdoFalse.Checked = false;
            cboLoc.Text = "";
            txtSeach.Clear();
        }



        private void btnClean_Click(object sender, EventArgs e)
        {
            if (txtIDNhanVien.Text == "")
            {
                MessageBox.Show("Form đang trống !");
                LoadGrid(dtgv_thongtinNhanVien, null);
            }
            else
            {
                Clear();
                LoadGrid(dtgv_thongtinNhanVien, null);
            }

        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(dtgv_thongtinNhanVien, txtSeach.Text/*.ToUpper()*/);
        }



        public void LoadGrid2(DataGridView dataGridView, List<NhanVien> nhanViens)
        {
            int stt = 1;
            dataGridView.ColumnCount = 9;

            dataGridView.Columns[0].Name = "STT";
            dataGridView.Columns[1].Name = "ID nhân viên";
            dataGridView.Columns[2].Name = "Chức vụ";
            dataGridView.Columns[3].Name = "Tên nhân viên";
            dataGridView.Columns[4].Name = "Email";
            dataGridView.Columns[5].Name = "Sđt";
            dataGridView.Columns[6].Name = "Giới tính";
            dataGridView.Columns[7].Name = "Tài khoản";
            dataGridView.Columns[8].Name = "Trạng thái làm việc";

            dataGridView.Rows.Clear();

            foreach (var item in nhanViens)
            {
                string gioitinh = item.GioiTinh == true ? "Nam" : "Nữ";
                string trangthai = item.TrangThaiLamViec == true ? "Đang làm" : "Đã nghỉ";
                var tenchucvu = _chucvuBUS.Getbyid(item.IdchucVu).ChucVu1;

                dataGridView.Rows.Add(stt++, item.IdnhanVien, tenchucvu, item.TenNhanVien, item.Email, item.Sdt, gioitinh, item.Taikhoan, trangthai);
            }
        }

        private void grpThaoTac_Enter(object sender, EventArgs e)
        {

        }

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool trangThai = cboLoc.SelectedItem.ToString() == "Đang làm";
            List<NhanVien> nhanViens = _qlnvBUS.CNLocTheoTrangThai(trangThai);
            LoadGrid2(dtgv_thongtinNhanVien, nhanViens);
        }

        private void rdoTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_thongtinNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= _qlnvBUS.Getallnhanvien().Count()) return;
            _idCellClick = Convert.ToString(dtgv_thongtinNhanVien.Rows[rowIndex].Cells[1].Value);
            var obj = _qlnvBUS.GetById(_idCellClick);

            if (obj != null)
            {
                txtIDNhanVien.Text = obj.IdnhanVien;
                cboChucVu.Text = _chucvuBUS.Getbyid(obj.IdchucVu).ChucVu1;
                txtTenNhanVien.Text = obj.TenNhanVien;
                txtEmail.Text = obj.Email;
                txtSdt.Text = obj.Sdt;
                txtTaiKhoan.Text = obj.Taikhoan;
                //txtMatKhau.Text = obj.MatKhau;

                if (obj.GioiTinh == true)
                {
                    Nam.Checked = true;


                }
                else
                {
                    Nu.Checked = true;
                }


                if (obj.TrangThaiLamViec == true)
                {
                    rdoTrue.Checked = true;
                }
                else
                {
                    rdoFalse.Checked = true;
                }
            }
        }


        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chucvui = "";
            if (comboBox1.Text == "Nhân viên")
            {
                chucvui = "CV002";
                List<NhanVien> nhanViens = _qlnvBUS.CNLocTheoChucVu(chucvui);
                LoadGrid2(dtgv_thongtinNhanVien, nhanViens);
            }

            else if(comboBox1.Text == "Admin")
            {
                chucvui = "CV001";
                List<NhanVien> nhanViens = _qlnvBUS.CNLocTheoChucVu(chucvui);
                LoadGrid2(dtgv_thongtinNhanVien, nhanViens);
            }

        }


        public void SendMail()
        {
            string fromEmail = "trungbdph49009@gmail.com";
            string toEmail = txtEmail.Text.Trim();
            string pass = "idrk sger pfbu mdvv";
            string tieude = "CHÀO MỪNG ĐẾN VỚI SUNSCREEN FPL";
            string content = $"Xin chào {txtTenNhanVien.Text}, Chúng tôi gửi Email này để xác nhận thông tin thành viên của bạn: ";
            string id = $"ID nhân viên: {txtIDNhanVien.Text}";
            string ten = $"Họ và tên: {txtTenNhanVien.Text}";
            string sdt = $"Số điện thoại: {txtSdt.Text}";
            string email = $"Emai: {txtEmail.Text}";
            string chucvu = $"Chức vụ: {cboChucVu.Text}";
            string tk = $"Tên đăng nhập: {txtTaiKhoan.Text}";
            string mk = $"Mật khẩu: {txtMatKhau.Text}";
            string thongdiep = "Sau khi nhận được email này, bạn vui lòng đăng nhập vào hệ thống và đổi mật khẩu mới !";

            MailMessage mail = new MailMessage();
            mail.To.Add(toEmail);
            mail.From = new MailAddress(fromEmail);
            mail.Subject = tieude;
            mail.Body = content + "\n" + ten + "\n" + sdt + "\n" + email + "\n" + chucvu + "\n" + tk + "\n" + mk + "\n" + thongdiep;

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




        public void SendMailUpdate()
        {
            string fromEmail = "trungbdph49009@gmail.com";
            string toEmail = txtEmail.Text.Trim();
            string pass = "idrk sger pfbu mdvv";
            string tieude = "SUNSCREEN - THÔNG BÁO CẬP NHẬT THÔNG TIN";
            string content = $"Xin chào {txtTenNhanVien.Text}, Thông tin cá nhân của bạn trên hệ thống Sunscreen FPL đã được Admin cập nhật. Vui lòng kiểm tra lại thông tin mới: ";
            string id = $"ID nhân viên: {txtIDNhanVien.Text}";
            string ten = $"Họ và tên: {txtTenNhanVien.Text}";
            string sdt = $"Số điện thoại: {txtSdt.Text}";
            string email = $"Emai: {txtEmail.Text}";
            string chucvu = $"Chức vụ: {cboChucVu.Text}";
            string tk = $"Tên đăng nhập: {txtTaiKhoan.Text}";
            string mk = $"Mật khẩu: {txtMatKhau.Text}";
            string thongdiep = "Nếu thông tin cá nhân không chính xác, vui lòng liên hệ với quản lý !";

            MailMessage mail = new MailMessage();
            mail.To.Add(toEmail);
            mail.From = new MailAddress(fromEmail);
            mail.Subject = tieude;
            mail.Body = content + "\n" + ten + "\n" + sdt + "\n" + email + "\n" + chucvu + "\n" + tk + "\n" + thongdiep;

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