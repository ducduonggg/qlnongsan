using System;
using System.Drawing; // Cần thêm dòng này để dùng được Color
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLNongSan
{
    public partial class Form5 : Form
    {
        // 1. Biến lưu trữ Form đang hiển thị hiện tại
        private Form? currentChildForm;

        public Form5()
        {
            InitializeComponent();
        }

        // 2. Hàm dùng chung để mở Form con vào Panel
        private void OpenChildForm(Form childForm, object btnSender)
        {
            // 1. Đóng Form cũ nếu đang mở
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            // 2. Thiết lập thuộc tính
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // 3. Hiển thị vào Panel
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;

            // QUAN TRỌNG: Đẩy Form con ra sau để không đè lên Menu nếu Panel bị tràn
            childForm.SendToBack();

            childForm.Show();

            // 4. Đổi màu nút
            HighlightButton(btnSender);
        }

        // 3. Hàm đổi màu nút khi được bấm
        private void HighlightButton(object btnSender)
        {
            if (btnSender is Button btnActive)
            {
                // Thay vì tìm trong groupBox1, ta tìm trực tiếp trong Form hoặc Panel chứa nút
                // Giả sử các nút của bạn nằm trong cái Panel bên trái, hãy thay 'this' bằng tên Panel đó
                foreach (Control ctrl in btnActive.Parent.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.Black;
                    }
                }

                // Tô màu cho nút vừa bấm
                btnActive.BackColor = Color.FromArgb(235, 245, 235);
                btnActive.ForeColor = Color.ForestGreen;
            }
        }

        // 4. Các sự kiện Click của bạn (Ví dụ)
        private void button1_Click(object sender, EventArgs e)
        {
            // Giờ đây 'FormSanPham' đã tồn tại, dòng này sẽ không còn bị gạch đỏ
            OpenChildForm(new FormSanPham(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tương tự cho Loại hàng
            OpenChildForm(new FormLoaiHang(), sender);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Để trống cũng được
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}