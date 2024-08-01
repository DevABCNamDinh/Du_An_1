using BUS;
using Data.data;
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
        private CsdlDuAn1NewNewContext dbcontext = new CsdlDuAn1NewNewContext();
        DQLNhanVienBUS _qlnvBUS = new DQLNhanVienBUS();
        DChucVuBUS _chucvuBUS = new DChucVuBUS();

        List<string> _lstchucvu = new List<string>();

        private string _idCellClick;
        public FormQLNhanVien()
        {
            InitializeComponent();
            LoadGrid(dgvDanhSachNhanVien);
            //LoadCbo();
        }

        public void LoadGrid(DataGridView dataGridView)
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
            //dataGridView.Columns[8].Name = "Mật khẩu";
            dataGridView.Columns[8].Name = "Trạng thái làm việc";

            dataGridView.Rows.Clear();



            foreach (var item in _qlnvBUS.Getallnhanvien())
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
        //public void LoadCbo()
        //{
        //    foreach (var item in _chucvuBUS.Getallchucvu())
        //    {
        //        cboChucVu.Items.Add(item.ChucVu1);
        //        _lstchucvu.Add(item.IdchucVu);
        //        cboChucVu.SelectedIndex = 0;
        //    }
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool gioitinh = false;
            if (rdoNam.Checked == true)
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
                (rdoNam.Checked == false && rdoNu.Checked == false) || (rdoTrue.Checked == false && rdoFalse.Checked == false))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
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
                LoadGrid(dgvDanhSachNhanVien);
            }

        }


        //private void btnUpdateSp_Click(object sender, EventArgs e)
        //{
        //    string IdSanPham = txtIdSanPham.Text;
        //    string IdKhuyenMai = txtIdKhuyenMai.Text;
        //    string Idlsp = txtIdlsp.Text;
        //    string TenSanPham = txtTenSanPham.Text;
        //    string NguonGoc = txtNguonGoc.Text;
        //    int SoLuong = Convert.ToInt32(txtSoLuong.Text);
        //    decimal GiaNhap = Convert.ToDecimal(txtGiaNhap.Text);
        //    double KhoiLuong = Convert.ToDouble(txtKhoiLuong.Text);
        //    DateOnly HanSuDung = DateOnly.FromDateTime(datetimeHsd.Value);
        //    string ChiSoSpf = txtSPF.Text;
        //    string ChiSoFa = txtFA.Text;
        //    decimal GiaBan = Convert.ToDecimal(txtGiaBan.Text);


        //    DialogResult dl = MessageBox.Show("ban co muon sua  khong?", "sua thanh cong ", MessageBoxButtons.YesNo);
        //    if (dl == DialogResult.Yes)
        //    {
        //        string kq = sanPhamBLL.UpdateSanPham(IdSanPham,
        //       IdKhuyenMai,
        //       Idlsp,
        //        TenSanPham,
        //        SoLuong,
        //        GiaNhap,
        //        KhoiLuong,
        //        NguonGoc,
        //     HanSuDung,
        //        ChiSoSpf,
        //        ChiSoFa,
        //        GiaBan);
        //        MessageBox.Show(kq);

        //        List<SanPham> sanPhams = sanPhamBLL.GetAllSanPham();
        //        ShowDate(sanPhams);
        //        load();

        //        return;
        //    }
        //}



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //var obj = _qlnvBUS.Getallnhanvien().First(x => x.IdnhanVien == _idCellClick);
            string idnhanvien = txtIDNhanVien.Text;
            //string idchucvu = _chucvuBUS.Getbyid(obj.IdchucVu).ChucVu1;
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
            if (rdoNam.Checked)
            {
                gioitinh = true;
            }
            else if (rdoNu.Checked)
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
                string kq = _qlnvBUS.Update(idnhanvien, idchucvu, tennhanvien, email, sdt, gioitinh, taikhoan, /*matkhau,*/ trangthai);
                MessageBox.Show(kq);

                LoadGrid(dgvDanhSachNhanVien);
                return;
            }



        }

        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dataGridView = new DataGridView();
            //dataGridView.Rows.Clear();
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= _qlnvBUS.Getallnhanvien().Count()) return;
            _idCellClick = Convert.ToString(dgvDanhSachNhanVien.Rows[rowIndex].Cells[1].Value);
            //var obj = _qlnvBUS.Getallnhanvien().First(x => x.IdnhanVien == _idCellClick);
            var obj = _qlnvBUS.GetById(_idCellClick);

            if (obj != null)
            {
                txtIDNhanVien.Text = obj.IdnhanVien;
                cboChucVu.SelectedIndex = _lstchucvu.FindIndex(x => x == obj.IdchucVu);
                cboChucVu.Text = _chucvuBUS.Getbyid(obj.IdchucVu).ChucVu1;
                txtTenNhanVien.Text = obj.TenNhanVien;
                txtEmail.Text = obj.Email;
                txtSdt.Text = obj.Sdt;
                txtTaiKhoan.Text = obj.Taikhoan;
                //txtMatKhau.Text = obj.MatKhau;

                if (obj.GioiTinh == true)
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string idNhanVien = txtIDNhanVien.Text;

                NhanVien nhanVien = new NhanVien()
                {
                    IdnhanVien = idNhanVien
                };

                bool capNhatThanhCong = _qlnvBUS.UpdateTTLV(nhanVien);

                if (capNhatThanhCong)
                {
                    MessageBox.Show("Cập nhật trạng thái làm việc thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

            LoadGrid(dgvDanhSachNhanVien);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cboChucVu.Text = "";
            txtIDNhanVien.Clear();
            txtEmail.Clear();
            txtSdt.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtTenNhanVien.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            rdoTrue.Checked = false;
            rdoFalse.Checked = false;
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpDanhSachNhanVien_Enter(object sender, EventArgs e)
        {

        }
    }
}       