
﻿using BUS;


using Data.Modee;


using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
namespace GUI
{
    public partial class FormQLKhachHang : Form
    {
        KhacHangBUS service = new KhacHangBUS();
        string idwhenclick;

        public FormQLKhachHang()
        {
            InitializeComponent();
            loadGird();
        }
        public void loadGird()
        {
            int i = 1;
            dtg_hienthi.ColumnCount = 6;
            dtg_hienthi.Columns[0].Name = "ID";
            dtg_hienthi.Columns[1].Name = "Ten";
            dtg_hienthi.Columns[2].Name = "Gioi tinh";
            dtg_hienthi.Columns[3].Name = "Email";
            dtg_hienthi.Columns[4].Name = "SDT";
            dtg_hienthi.Columns[5].Name = "Dia chi";
            dtg_hienthi.Rows.Clear();
            dtg_hienthi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dtg_hienthi.Columns[0].FillWeight = 50;

            var khachHangs = service.GetKhachHangs(txt_search.Text);
            if (!string.IsNullOrWhiteSpace(txt_search.Text))
            {
                khachHangs = khachHangs.Where(kh => kh.Sdt.Contains(txt_search.Text)).ToList();
            }

            foreach (var kh in service.GetKhachHangs(txt_search.Text))
            {
                string gioitinh;
                if (kh.GioiTinh == true)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }
                if (kh.IdkhachHang == "KH0")
                {

                }
                else
                {
                    dtg_hienthi.Rows.Add(kh.IdkhachHang, kh.Ten, gioitinh, kh.Email, kh.Sdt, kh.Diachi);
                }
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txt_khachhang.Text) ||
        string.IsNullOrWhiteSpace(txt_sdt.Text) ||
        (!rdo_Nam.Checked && !rdo_Nu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.");
                return false;
            }

            if (txt_sdt.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số.");
                return false;
            }

            if (txt_email.Text.Equals("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Địa chỉ email không thể chỉ là @gmail.com.");
                return false;
            }
            if (txt_email.Text.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) &&
                txt_email.Text.Length == "@gmail.com".Length)
            {
                MessageBox.Show("Địa chỉ email không thể chỉ là @gmail.com.");
                return false;
            }

            return true;
        }

        private bool IsPhoneNumberUnique(string phoneNumber, string customerId = null)
        {
            var customers = service.GetKhachHangs(txt_search.Text);
            return !customers.Any(kh => kh.Sdt == phoneNumber && kh.IdkhachHang != customerId);
        }

        private bool IsEmailUnique(string email, string customerId = null)
        {
            var customers = service.GetKhachHangs(txt_search.Text);
            return !customers.Any(kh => kh.Email == email && kh.IdkhachHang != customerId);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            if (!IsPhoneNumberUnique(txt_sdt.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số điện thoại khác.");
                return;
            }

            if (txt_email.Text == "")
            {

            }
            else
            {
                if (!IsEmailUnique(txt_email.Text))
                {
                    MessageBox.Show("Email đã tồn tại. Vui lòng nhập email khác.");
                    return;
                }
            }


            KhachHang newKhachHang = new KhachHang
            {
                IdkhachHang = "KH" + (service.GetKhachHangs(txt_search.Text).Count),
                Ten = txt_khachhang.Text,
                Diachi = txt_diachi.Text,
                Email = txt_email.Text,
                Sdt = txt_sdt.Text,
                GioiTinh = rdo_Nam.Checked
            };

            var result = service.themNV(newKhachHang);
            MessageBox.Show(result == "Thêm thành công" ? "Thêm thông tin thành công!" : result);
            loadGird();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idwhenclick))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
                return;
            }

            if (!ValidateFields())
            {
                return;
            }

            var kh = service.GetKhachHangs(txt_search.Text).FirstOrDefault(x => x.IdkhachHang == idwhenclick);
            if (kh != null)
            {
                kh.Ten = txt_khachhang.Text;
                kh.Diachi = txt_diachi.Text;
                kh.Email = txt_email.Text;
                kh.Sdt = txt_sdt.Text;
                kh.GioiTinh = rdo_Nam.Checked;

                var result = service.suaNV(kh);
                MessageBox.Show(result == "Sửa thành công" ? "Cập nhật thông tin thành công!" : result);

                loadGird();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng cần sửa.");
            }
        }
        public void fillData()
        {
            /*var kh = service.GetKhachHangs(txt_search.Text).FirstOrDefault(x => x.IdkhachHang == idwhenclick);
            if (kh != null)
            {
                txt_khachhang.Text = kh.Ten;
                txt_diachi.Text = kh.Diachi;
                txt_sdt.Text = kh.Sdt;
                txt_email.Text = kh.Email;
                if (kh.GioiTinh == true)
                {
                    rdo_Nam.Checked = true;
                }
                else
                {
                    rdo_Nu.Checked = true;
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy khách hàng với ID: {idwhenclick}");
            }*/

            var kh = service.GetKhachHangs(txt_search.Text).Find(x => x.IdkhachHang == idwhenclick);
            txt_khachhang.Text = kh.Ten;
            txt_diachi.Text = kh.Diachi;
            txt_sdt.Text = kh.Sdt;
            txt_email.Text = kh.Email;
            if (kh.GioiTinh == true)
            {
                rdo_Nam.Checked = true;
            }
            else
            {
                rdo_Nu.Checked = true;
            }
        }

        private void dtg_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= service.GetKhachHangs(txt_search.Text).Count())
            {
                return;
            }
            idwhenclick = dtg_hienthi.Rows[rowIndex].Cells[1].Value.ToString();
            fillData();*/
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dtg_hienthi.Rows.Count-1)
            {
                idwhenclick = dtg_hienthi.Rows[rowIndex].Cells[0].Value.ToString(); // Lấy giá trị ID từ cột ID
                fillData();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //loadGird();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            /*var kh = service.GetKhachHangs(txt_search.Text).Find(x => x.Ten == idwhenclick);
            var chon = MessageBox.Show("Ban co muon xoa khong?", "Xoa thong tin", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                MessageBox.Show(service.xoaNV(kh));
                loadGird();
            }*/
        }

        private void btn_cleah_Click(object sender, EventArgs e)
        {
            txt_diachi.Clear();
            txt_email.Clear();
            //txt_id.Clear();
            txt_khachhang.Clear();
            txt_sdt.Clear();
            txt_search.Clear();
            rdo_Nam.Enabled = false;
            rdo_Nu.Enabled = false;
        }

        private void FormQLKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            loadGird();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_searchPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


    }
}
