using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLNongSan
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn loại báo cáo chưa
if (comboBox1.SelectedIndex == -1) 
{
    MessageBox.Show("Cậu chọn loại báo cáo trước đã nhé!", "Thông báo");
    return;
}

dataGridView1.Columns.Clear();
dataGridView1.Rows.Clear();

switch (comboBox1.Text)
{
    case "Báo cáo Doanh thu":
        dataGridView1.Columns.Add("MaHD", "Mã Hóa Đơn");
        dataGridView1.Columns.Add("NgayBan", "Ngày Bán");
        dataGridView1.Columns.Add("KhachHang", "Tên Khách Hàng");
        dataGridView1.Columns.Add("TongTien", "Tổng Tiền");
        dataGridView1.Columns.Add("TrangThai", "Trạng Thái Thanh Toán");
        break;

    case "Báo cáo Tồn kho":
        dataGridView1.Columns.Add("MaSP", "Mã Sản Phẩm");
        dataGridView1.Columns.Add("TenSP", "Tên Nông Sản");
        dataGridView1.Columns.Add("DanhMuc", "Danh Mục");
        dataGridView1.Columns.Add("TonKho", "Số Lượng Tồn");
        dataGridView1.Columns.Add("DonVi", "Đơn Vị Tính");
        dataGridView1.Columns.Add("NgayNhap", "Ngày Nhập Kho");
        break;

    case "Báo cáo Hao hụt / Hủy hàng":
        dataGridView1.Columns.Add("MaSP", "Mã Sản Phẩm");
        dataGridView1.Columns.Add("TenSP", "Tên Nông Sản");
        dataGridView1.Columns.Add("KhoiLuong", "Khối Lượng Hủy");
        dataGridView1.Columns.Add("LyDo", "Lý Do Hủy");
        dataGridView1.Columns.Add("NgayHuy", "Ngày Ghi Nhận");
        dataGridView1.Columns.Add("NguoiKiem", "Người Kiểm Định");
        break;
}

dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
