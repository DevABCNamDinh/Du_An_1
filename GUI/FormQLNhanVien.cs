using BUS;
using Data.Models;
using System.Text.RegularExpressions;
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
            LoadGrid(dgvDanhSachNhanVien, null);
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
            dgvDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

         


            else
            {
                if (_qlnvBUS.Create(nhanVien))
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại");
                }

                txtMatKhau.Clear();
                LoadGrid(dgvDanhSachNhanVien, null);
            }

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
                    if (dl == DialogResult.Yes && txtMatKhau.Text == "")
                    {
                        string kq = _qlnvBUS.Update(idnhanvien, idchucvu, tennhanvien, email, sdt, gioitinh, taikhoan, /*matkhau,*/ trangthai);
                        
                        MessageBox.Show(kq);

                        LoadGrid(dgvDanhSachNhanVien, null);
                        return;

                    }
                    else if(dl == DialogResult.No && txtMatKhau.Text == ""){
                        LoadGrid(dgvDanhSachNhanVien, null);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Bạn không thể thay đổi mật khẩu !");
                        txtMatKhau.Clear();
                    }
                }
            }







        }

        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= _qlnvBUS.Getallnhanvien().Count()) return;
            _idCellClick = Convert.ToString(dgvDanhSachNhanVien.Rows[rowIndex].Cells[1].Value);
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
            }
            else
            {
                Clear();
            }

        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(dgvDanhSachNhanVien, txtSeach.Text/*.ToUpper()*/);
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
            LoadGrid2(dgvDanhSachNhanVien, nhanViens);
        }
    }
}       