using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNongSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1. Chuỗi kết nối (Connection String)
            string connString = @"Data Source=.;Initial Catalog=QuanLyNongSan;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // 2. Truy vấn kiểm tra tài khoản
                    string sql = "SELECT COUNT(*) FROM NhanVien WHERE Username=@user AND Password=@pass";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Lấy dữ liệu từ TextBox trên Form 1
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());

                    int result = (int)cmd.ExecuteScalar();

                    // 3. Xử lý logic chuyển giao diện
                    if (result > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Eco Farm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide(); // Ẩn Form đăng nhập hiện tại

                        // Mở giao diện mới (Form5 là giao diện Menu bạn đã tạo)
                        Form5 fMenu = new Form5();
                        fMenu.ShowDialog();

                        this.Close(); // Giải phóng bộ nhớ khi tắt Menu
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                }
            }
        }
    }
}
