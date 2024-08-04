using BUS;
using DAL;
using Data.Models;

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
            txtChucVu.Text = _chucvuBUS.Getbyid(NhanVien.IdchucVu).ChucVu1;

            txtEmail.Text = NhanVien.Email;
            txtSdt.Text = NhanVien.Sdt;
            if (NhanVien.GioiTinh == true)
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
            else if (rdoNam.Checked)
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
                MessageBox.Show(kq);

                return;

            }
            LoadTTTK();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
