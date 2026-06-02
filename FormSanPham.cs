using System;
using System.Windows.Forms;
using QLNongSan.BLL;  // Nhớ đổi tên theo Namespace dự án của bạn
using QLNongSan.DTO;  // Nhớ đổi tên theo Namespace dự án của bạn

namespace QLNongSan
{
    public partial class FormSanPham : Form
    {
        // 1. Khai báo đối tượng tầng BLL để dùng chung cho cả Form
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();

        public FormSanPham()
        {
            InitializeComponent();
        }

        // 2. Sự kiện Load Form - Tự động tải dữ liệu lên bảng khi mở giao diện
        private void FormSanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
        }

        // 3. Hàm tải dữ liệu thông qua tầng BLL
        private void HienThiDanhSachSanPham()
        {
            try
            {
                // Gọi sang BLL lấy bảng dữ liệu đổ vào dgvSanPham
                dgvSanPham.DataSource = sanPhamBLL.GetListSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách sản phẩm: " + ex.Message, "Lỗi");
            }
        }

        // 4. Sự kiện Click của nút THÊM dữ liệu theo chuẩn 3 lớp
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước A: Thu thập thông tin từ các ô nhập liệu và đóng gói vào DTO
                SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = txtMaSP.Text.Trim();
                sp.TenSP = txtTenSP.Text.Trim();
                sp.LoaiHang = cboLoaiHang.Text;
                sp.SoLuongTon = int.Parse(txtSoLuongTon.Text.Trim());
                sp.GiaBan = decimal.Parse(txtGiaBan.Text.Trim());

                // Bước B: Đẩy đối tượng sang tầng BLL để kiểm tra logic nghiệp vụ và lưu
                string ketQua = sanPhamBLL.AddSanPham(sp);

                // Bước C: Xử lý kết quả trả về từ tầng BLL
                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Thêm sản phẩm mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSachSanPham(); // Tải lại bảng dưới giao diện
                    btnLamMoi.PerformClick();  // Tự động kích hoạt nút làm mới dữ liệu ô nhập
                }
                else
                {
                    // Hiển thị các cảnh báo nghiệp vụ từ BLL (Ví dụ: Để trống, số âm, trùng mã...)
                    MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập định dạng số cho ô 'Số lượng tồn' và 'Giá bán'!", "Sai định dạng");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi: " + ex.Message, "Lỗi hệ thống");
            }
        }

        // 5. Sự kiện Click của nút LÀM MỚI (Xóa trắng ô nhập liệu)
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoaiHang.SelectedIndex = -1; // Bỏ chọn loại hàng
            txtSoLuongTon.Clear();
            txtGiaBan.Clear();
            txtMaSP.Focus(); // Đưa con trỏ chuột về lại ô đầu tiên
        }
    }
}