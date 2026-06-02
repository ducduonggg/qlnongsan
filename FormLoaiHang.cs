using QLNongSan.BLL;
using QLNongSan.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNongSan
{
    public partial class FormLoaiHang : Form
    {
        private LoaiHangBLL loaiHangBLL = new LoaiHangBLL();

        public FormLoaiHang()
        {
            InitializeComponent();
        }

        private void FormLoaiHang_Load(object sender, EventArgs e)
        {
            HienThiData();
        }

        private void HienThiData()
        {
            try
            {
                // Giả sử tên DataGridView trên giao diện của bạn là dgvLoaiHang
                dgvLoaiHang.DataSource = loaiHangBLL.GetListLoaiHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách loại hàng: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                // Giả sử tên các ô TextBox của bạn lần lượt là txtMaLoai và txtTenLoai
                LoaiHangDTO lh = new LoaiHangDTO();
                lh.MaLoai = txtMaLoai.Text.Trim();
                lh.TenLoai = txtTenLoai.Text.Trim();

                string ketQua = loaiHangBLL.AddLoaiHang(lh);

                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Thêm loại hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiData(); // Tải lại bảng dữ liệu bên dưới
                    btnLamMoi.PerformClick(); // Kích hoạt nút làm mới dữ liệu đầu vào
                }
                else
                {
                    MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            txtMaLoai.Focus();
        }

        private void LoadDataToGridView()
        {
            // Lấy đúng chuỗi kết nối từ máy của bạn
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNongSan;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaSP as [Mã sản phẩm], TenSP as [Tên sản phẩm], LoaiHang as [Loại hàng], SoLuongTon as [Số lượng tồn], GiaBan as [Giá bán] FROM SanPham";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Nhìn vào dòng 179 của bạn đang ăn theo tên 'dtgSanPham' nên ta đổi đồng bộ thành dtgSanPham
                dgvLoaiHang.DataSource = dt;
            }
        }
        private void dgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}