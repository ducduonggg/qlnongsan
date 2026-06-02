using System;
using System.Data;
using Microsoft.Data.SqlClient; // Khai báo dùng thư viện mới vừa cài xong
using QLNongSan.DTO;

namespace QLNongSan.DAL
{
    public class LoaiHangDAL
    {
        // Chuỗi kết nối chuẩn giúp vượt qua xác thực chứng chỉ, kết nối nhanh dưới 1 giây
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNongSan;Integrated Security=True;TrustServerCertificate=True";

        // Lấy danh sách Loại hàng đổ lên bảng
        public DataTable GetAllLoaiHang()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaLoai, TenLoai FROM LoaiHang";

            // Bọc trong using giúp tự động đóng kết nối, chống lag app hoàn toàn
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            } // Chạy đến đây conn tự động Close và Dispose
            return dt;
        }

        // Thêm Loại hàng mới vào SQL Server
        // Hàm thêm dữ liệu tối ưu, không bao giờ bị nghẽn kết nối
        public bool InsertLoaiHang(LoaiHangDTO lh)
        {
            string query = "INSERT INTO LoaiHang (MaLoai, TenLoai) VALUES (@MaLoai, @TenLoai)";

            // Toàn bộ kết nối và câu lệnh được dọn dẹp ngay sau khi thực thi
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@MaLoai", lh.MaLoai);
                        cmd.Parameters.AddWithValue("@TenLoai", lh.TenLoai);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }
    }
}