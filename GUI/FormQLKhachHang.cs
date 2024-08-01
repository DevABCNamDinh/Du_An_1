using BUS.Service;
using DTO.Modeles;
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
    public partial class FormQLKhachHang : Form
    {
        KhachHangService service = new KhachHangService();
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
                    
                dtg_hienthi.Rows.Add(kh.IdkhachHang, kh.Ten,gioitinh, kh.Email, kh.Sdt, kh.Diachi);
            }
        }
        

        private void btn_add_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.IdkhachHang = "KH" + (service.GetKhachHangs(txt_search.Text).Count + 1);
            kh.Ten = txt_khachhang.Text;
            kh.Diachi = txt_diachi.Text;
            kh.Email = txt_email.Text;
            kh.Sdt = txt_sdt.Text;
           // kh.IdkhachHang = txt_id.Text;
            //Giới tính
            MessageBox.Show(service.themNV(kh));
            loadGird();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var kh = service.GetKhachHangs(txt_search.Text).Find(x => x.Ten == idwhenclick);
            txt_khachhang.Text = kh.Ten;
            txt_diachi.Text = kh.Diachi;
            txt_sdt.Text = kh.Sdt;
            txt_email.Text = kh.Email;
            //txt_id.Text = kh.IdkhachHang;
            //Giới tính
            MessageBox.Show(service.suaNV(kh));
            loadGird();
        }
        public void fillData()
        {
            var kh = service.GetKhachHangs(txt_search.Text).Find(x => x.Ten == idwhenclick);
            txt_khachhang.Text = kh.Ten;
            txt_diachi.Text = kh.Diachi;
            txt_sdt.Text = kh.Sdt;
            txt_email.Text = kh.Email;
            //txt_id.Text = kh.IdkhachHang;
            if(kh.GioiTinh == true)
            {
                rdo_Nam.Checked = true;
            }
            else
            {
                rdo_Nu.Checked = true ;
            }
        }

        private void dtg_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= service.GetKhachHangs(txt_search.Text).Count())
            {
                return;
            }
            idwhenclick = dtg_hienthi.Rows[rowIndex].Cells[1].Value.ToString();
            fillData();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            loadGird();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var kh = service.GetKhachHangs(txt_search.Text).Find(x => x.Ten == idwhenclick);
            var chon = MessageBox.Show("Ban co muon xoa khong?", "Xoa thong tin", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                MessageBox.Show(service.xoaNV(kh));
                loadGird();
            }
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
    }
}
