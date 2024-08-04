using BUS;


using Data.Data;



using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using DAL;
using System.Net.Mail;
using System.Net;



namespace GUI
{
    public partial class FormKhuyenMai : Form
    {
        string idwhenClick;

        public FormKhuyenMai()
        {
            InitializeComponent();

            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Dock = DockStyle.Fill;
            this.Controls.Add(textBox);


        }
        QKhuyenMaiBUS BUS = new QKhuyenMaiBUS();




        public void ShowData(List<KhuyenMai> khuyenMais)
        {
            if (khuyenMais == null || !khuyenMais.Any())
            {
                dgvKhuyenMai.DataSource = null; // Đặt nguồn dữ liệu là null nếu danh sách rỗng
                dgvKhuyenMai.Rows.Clear();
                return; // Không làm gì khác nếu không có dữ liệu
            }

            dgvKhuyenMai.DataSource = null; // Xóa nguồn dữ liệu hiện tại
            dgvKhuyenMai.Rows.Clear(); // Xóa tất cả các hàng

            // Thiết lập cấu trúc cột nếu chưa được thiết lập
            if (dgvKhuyenMai.Columns.Count == 0)
            {
                dgvKhuyenMai.ColumnCount = 8;
                dgvKhuyenMai.Columns[0].HeaderText = "STT";
                dgvKhuyenMai.Columns[1].HeaderText = "ID Khuyến Mãi";
                dgvKhuyenMai.Columns[1].Visible=false;
                dgvKhuyenMai.Columns[2].HeaderText = "TenKhuyenMai";
                dgvKhuyenMai.Columns[3].HeaderText = "NgayBatDau";
                dgvKhuyenMai.Columns[4].HeaderText = "NgayKetThuc";
                dgvKhuyenMai.Columns[5].HeaderText = "PhanTramGiamGia";
                dgvKhuyenMai.Columns[6].HeaderText = "MoTa";
                dgvKhuyenMai.Columns[7].HeaderText = "TrangThai";
                dgvKhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

            // Thiết lập màu sắc cho tiêu đề cột và hàng
            //dgvKhuyenMai.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
            //dgvKhuyenMai.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dgvKhuyenMai.DefaultCellStyle.SelectionBackColor = Color.HotPink;
            //dgvKhuyenMai.DefaultCellStyle.SelectionForeColor = Color.White;
            //dgvKhuyenMai.EnableHeadersVisualStyles = false;

            int stt = 1;

            foreach (var item in khuyenMais)
            {
                string trangThai = item.TrangThai.HasValue
                    ? (item.TrangThai.Value ? "Đang hoạt động" : "Đã tắt")
                    : "Không xác định";

                // Thêm hàng mới vào DataGridView
                if (item.IdkhuyenMai == "KM000")
                {

                }
                else
                {
                    dgvKhuyenMai.Rows.Add(stt++, item.IdkhuyenMai, item.TenKhuyenMai, item.NgayBatDau, item.NgayKetThuc, item.PhanTramGiamGia+"%", item.MoTa, trangThai);

                }
            }
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvKhuyenMai.Rows[e.RowIndex];

                    idwhenClick = row.Cells[1].Value?.ToString();
                    txtTenKhuyenMai.Text = row.Cells[2].Value?.ToString();
                    if (row.Cells[3].Value != null && DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime ngayBatDau))
                    {
                        dateNgayBatDau.Text = ngayBatDau.ToString("dd-MM-yyyy");
                    }
                    else
                    {
                        dateNgayBatDau.Text = "";
                    }

                    if (row.Cells[4].Value != null && DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime ngayKetThuc))
                    {
                        dateNgayKetThuc.Text = ngayKetThuc.ToString("dd-MM-yyyy");
                    }
                    else
                    {
                        dateNgayKetThuc.Text = "";
                    }

                    txtGiamGia.Text = row.Cells[5].Value?.ToString();
                    txtMoTaKM.Text = row.Cells[6].Value?.ToString();


                    if (Convert.ToString(row.Cells[7].Value) == "Đang hoạt động")
                    {
                        rdoBat.Checked = true;
                    }
                    else if (Convert.ToString(row.Cells[7].Value) == "Đã tắt") { rdoTat.Checked = true; }




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string TenKM = txtTenKhuyenMai.Text;
            DateTime NgayBD = dateNgayBatDau.Value;
            DateTime NgayKT = dateNgayKetThuc.Value;
            double GiamGia;

            if (string.IsNullOrWhiteSpace(TenKM))
            {
                MessageBox.Show("Vui lòng nhập tên khuyến mãi.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (NgayBD > NgayKT)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateNgayKetThuc.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày kết thúc không thể nhỏ hơn ngày hiện tại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNgayKetThuc.Value = DateTime.Now; // Đặt lại giá trị ngày kết thúc về hiện tại
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGiamGia.Text) || !double.TryParse(txtGiamGia.Text, out GiamGia) || GiamGia < 0 || GiamGia > 100)
            {
                MessageBox.Show("Vui lòng nhập phần trăm giảm giá hợp lệ (từ 0 đến 100).", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            var MoTa = txtMoTaKM.Text;
            if (string.IsNullOrWhiteSpace(MoTa))
            {
                MessageBox.Show("Vui lòng nhập mô tả khuyến mãi.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool TrangThai = false;


            if (rdoBat.Checked == true)
            {
                TrangThai = true;
            }
            else
            {
                TrangThai = false;
            }

            string id = "KM" + (BUS.CNHien().Count );

            DialogResult dl = MessageBox.Show("Bạn có muốn thêm khuyến mãi không?", "Thêm Mới", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                string kq = BUS.CNThem(id, TenKM, NgayBD, NgayKT, GiamGia, MoTa, TrangThai);
                MessageBox.Show(kq);
                List<KhuyenMai> km = BUS.CNHien();
                ShowData(km);
                return;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          
            string TenKM = txtTenKhuyenMai.Text;
            DateTime NgayBD = dateNgayBatDau.Value;
            DateTime NgayKT = dateNgayKetThuc.Value;
            double GiamGia;


            if (string.IsNullOrWhiteSpace(idwhenClick) || string.IsNullOrWhiteSpace(TenKM) ||
                NgayBD > NgayKT ||
                string.IsNullOrWhiteSpace(txtGiamGia.Text) ||
                !double.TryParse(txtGiamGia.Text, out GiamGia) || GiamGia < 0 || GiamGia > 100)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập vào.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string MoTa = txtMoTaKM.Text;
            if (string.IsNullOrWhiteSpace(MoTa))
            {
                MessageBox.Show("Vui lòng nhập mô tả khuyến mãi.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool TrangThai;
            if (rdoBat.Checked == true)
            {
                TrangThai = true;
            }
            else
            {
                TrangThai = false;
            }

            DialogResult dl = MessageBox.Show("Bạn có muốn sửa khuyến mãi không?", "Sửa Mới", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                try
                {

                    string kq = BUS.CNSua(idwhenClick, TenKM, NgayBD, NgayKT, GiamGia, MoTa, TrangThai);
                    MessageBox.Show(kq);

                    List<KhuyenMai> km = BUS.CNHien();
                    ShowData(km);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }







        private void btnShow_Click(object sender, EventArgs e)
        {
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void FormKhuyenMai_Load_1(object sender, EventArgs e)
        {
            List<KhuyenMai> khuyenMais = BUS.CNHien();

            ShowData(khuyenMais);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            cbbTrangThai.Items.Add("Tất cả");
            cbbTrangThai.Items.Add("Đang hoạt động");
            cbbTrangThai.Items.Add("Đã tắt");
            cbbTrangThai.SelectedIndex = 0;

            dateNgayBatDau.Value = DateTime.Now; // Ngày bắt đầu mặc định là thời điểm hiện tại
            dateNgayKetThuc.Value = DateTime.Now.AddDays(1);


            //cbbIDKhuyenMai.Items.Clear();
            //foreach (var km in khuyenMais)
            //{
            //    cbbIDKhuyenMai.Items.Add(km.IdkhuyenMai);
            //}




        }



        private void panel1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void FormKhuyenMai_Resize(object sender, EventArgs e)
        {

        }



        private void txtLocPhanTramTu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private string filterId;
        private DateTime? filterDate;
        private double? filterDiscount;
        private bool? filterStatus;

        private void btnLocID_Click(object sender, EventArgs e)
        {
            filterId = txtLocID.Text;
            ApplyFilters();
        }

        private void btnLocNgay_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(dateLocNBD.Text, out DateTime selectedDate))
            {
                filterDate = selectedDate;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ngày hợp lệ.");
                return;
            }
            ApplyFilters();
        }

        private void btnLocGiamGia_Click(object sender, EventArgs e)
        {
            //if (double.TryParse(txtLocGiamGiaTu.Text, out double discount))
            //{
            //    filterDiscount = discount;
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập phần trăm giảm giá hợp lệ.");
            //    return;
            //}
            //ApplyFilters();
        }

        private void btnLocTrangThai_Click(object sender, EventArgs e)
        {
            if (cbbTrangThai.SelectedItem != null)
            {
                filterStatus = cbbTrangThai.SelectedItem.ToString() == "Đang hoạt động";
            }
            ApplyFilters();
        }

        private void btnLM_Click(object sender, EventArgs e)
        {

            filterId = null;
            filterDate = null;
            filterDiscount = null;
            filterStatus = null;

            List<KhuyenMai> km = BUS.CNHien();
            ShowData(km);
        }

        private void ApplyFilters()
        {
            List<KhuyenMai> filteredList = BUS.CNHien();

            if (!string.IsNullOrEmpty(filterId))
            {
                filteredList = filteredList.Where(km => km.IdkhuyenMai.Contains(filterId)).ToList();
            }

            if (filterDate.HasValue)
            {
                filteredList = filteredList.Where(km => km.NgayBatDau.HasValue && km.NgayBatDau.Value.Date == filterDate.Value.Date).ToList();
            }

            if (filterDiscount.HasValue)
            {
                filteredList = filteredList.Where(km => km.PhanTramGiamGia >= filterDiscount.Value).ToList();
            }




            if (dateLocNBD.Value <= dateLocNKT.Value) // So sánh đầy đủ bao gồm cả giờ
            {
                filteredList = filteredList.Where(km => km.NgayBatDau.HasValue
                    && km.NgayBatDau.Value >= dateLocNBD.Value
                    && km.NgayBatDau.Value <= dateLocNKT.Value).ToList();
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu phải trước hoặc cùng ngày với ngày kết thúc.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không lọc dữ liệu nếu ngày không hợp lệ
            }



            ShowData(filteredList);
        }




        private void btnXuat_Click_1(object sender, EventArgs e)
        {
            //string selectedFormat = cbbXuat.SelectedItem?.ToString();

            //if (string.IsNullOrEmpty(selectedFormat))
            //{
            //    MessageBox.Show("Vui lòng chọn định dạng xuất.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //switch (selectedFormat)
            //{

            //    case "PDF":
            //        ExportToPDF();
            //        break;
            //    default:
            //        MessageBox.Show("Định dạng không hợp lệ.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        break;
            //}
        }
        //private void ExportToPDF()
        //{
        //    var khuyenMais = BUS.CNHien();
        //    using (Document doc = new Document())
        //    {
        //        SaveFileDialog saveFileDialog = new SaveFileDialog
        //        {
        //            FileName = "DanhSachKhuyenMai.pdf",
        //            Filter = "PDF File|*.pdf"
        //        };
        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
        //            doc.Open();
        //            doc.Add(new Paragraph("Danh Sách Khuyến Mãi"));

        //            PdfPTable table = new PdfPTable(7);
        //            table.AddCell("ID Khuyến Mãi");
        //            table.AddCell("Tên Khuyến Mãi");
        //            table.AddCell("Ngày Bắt Đầu");
        //            table.AddCell("Ngày Kết Thúc");
        //            table.AddCell("Phần Trăm Giảm Giá");
        //            table.AddCell("Mô Tả");
        //            table.AddCell("Trạng Thái");

        //            foreach (var item in khuyenMais)
        //            {
        //                table.AddCell(item.IdkhuyenMai);
        //                table.AddCell(item.TenKhuyenMai);
        //                table.AddCell(item.NgayBatDau.HasValue ? item.NgayBatDau.Value.ToString("yyyy-MM-dd") : "");
        //                table.AddCell(item.NgayKetThuc.HasValue ? item.NgayKetThuc.Value.ToString("yyyy-MM-dd") : "");
        //                table.AddCell(item.PhanTramGiamGia.ToString());
        //                table.AddCell(item.MoTa);
        //                table.AddCell(item.TrangThai.HasValue && item.TrangThai.Value ? "Đang hoạt động" : "Đã tắt");
        //            }

        //            doc.Add(table);
        //            doc.Close();
        //            MessageBox.Show("Xuất file PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //}



        private void cbbIDKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLocHan_Click(object sender, EventArgs e)
        {
            //bool conHan = rdoConHan.Checked;
            //List<KhuyenMai> khuyenMais = BUS.LocHan(conHan);
            //ShowData(khuyenMais);
        }

        private void btnCheckNgay_Click(object sender, EventArgs e)
        {
            //if (cbbIDKhuyenMai.SelectedItem != null)
            //{
            //    string selectedID = cbbIDKhuyenMai.SelectedItem.ToString();
            //    KhuyenMai khuyenMai = BUS.CNTim(selectedID);

            //    if (khuyenMai != null)
            //    {
            //        DateTime? ngayKetThuc = khuyenMai.NgayKetThuc;

            //        if (ngayKetThuc.HasValue)
            //        {
            //            TimeSpan timeLeft = ngayKetThuc.Value - DateTime.Now;

            //            if (timeLeft.TotalDays > 0)
            //            {
            //                MessageBox.Show($"Khuyến mãi '{khuyenMai.TenKhuyenMai}' còn {timeLeft.Days} ngày nữa sẽ hết hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else
            //            {
            //                MessageBox.Show($"Khuyến mãi '{khuyenMai.TenKhuyenMai}' đã hết hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show($"Khuyến mãi '{khuyenMai.TenKhuyenMai}' không có ngày kết thúc xác định.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không tìm thấy thông tin khuyến mãi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn khuyến mãi từ danh sách.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private CancellationTokenSource cancellationTokenSource;

        private async void txtTim_TextChanged_1(object sender, EventArgs e)
        {
            string searchTerm = txtTim.Text.Trim();


            if (string.IsNullOrEmpty(searchTerm))
            {
                List<KhuyenMai> khuyenMais = BUS.CNHien();
                ShowData(khuyenMais);
                return;
            }


            cancellationTokenSource?.Cancel();
            cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            try
            {
                await Task.Delay(5, token);

                List<KhuyenMai> khuyenMais = BUS.CNTimByPartialTen(searchTerm);

                ShowData(khuyenMais);
            }
            catch (TaskCanceledException)
            {

            }
        }


        private async void txtLocID_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtLocID.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                List<KhuyenMai> khuyenMais = BUS.CNHien(); // Lấy tất cả khuyến mãi nếu không có từ khóa
                ShowData(khuyenMais);
                return;
            }

            cancellationTokenSource?.Cancel();
            cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            try
            {
                await Task.Delay(300, token); // Chờ một chút để tránh việc gọi quá nhiều lần

                List<KhuyenMai> khuyenMais = BUS.GetKhuyenMaisById(searchTerm); // Gọi phương thức BUS để tìm kiếm

                ShowData(khuyenMais);
            }
            catch (TaskCanceledException)
            {
                // Tác vụ bị hủy, không làm gì cả
            }
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbTrangThai.SelectedItem == null)
            {
                List<KhuyenMai> khuyenMais = BUS.CNHien();
                ShowData(khuyenMais);
                return;
            }


            if (cbbTrangThai.SelectedItem.ToString() == "Tất cả")
            {

                List<KhuyenMai> khuyenMais = BUS.CNHien();
                ShowData(khuyenMais);
                return;
            }


            bool status = cbbTrangThai.SelectedItem.ToString() == "Đang hoạt động";
            List<KhuyenMai> filteredKhuyenMais = BUS.LocTrangThai(status);
            ShowData(filteredKhuyenMais);


        }

        private void dateLocNBD_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dateLocNKT_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
    


