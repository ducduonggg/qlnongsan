using System;
using System.Data;
using Microsoft.Data.SqlClient; // Khai báo dùng thư viện mới vừa cài xong
using QLNongSan.DTO;

namespace QLNongSan.DAL
{
    public class SanPhamDAL
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNongSan;Integrated Security=True";

        // Hàm lấy toàn bộ sản phẩm để load lên GridView
        public DataTable GetAllSanPham()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaSP as [Mã sản phẩm], TenSP as [Tên sản phẩm], LoaiHang as [Loại hàng], SoLuongTon as [Số lượng tồn], GiaBan as [Giá bán] FROM SanPham";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        // Hàm thêm sản phẩm vào SQL
        public bool InsertSanPham(SanPhamDTO sp)
        {
            string query = "INSERT INTO SanPham (MaSP, TenSP, LoaiHang, SoLuongTon, GiaBan) VALUES (@MaSP, @TenSP, @LoaiHang, @SoLuong, @GiaBan)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                    cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                    cmd.Parameters.AddWithValue("@LoaiHang", sp.LoaiHang);
                    cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuongTon);
                    cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Trả về true nếu thêm thành công dòng dữ liệu
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}