using System;

namespace QLNongSan.DTO
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LoaiHang { get; set; }
        public int SoLuongTon { get; set; }
        public decimal GiaBan { get; set; }

        // Constructor không tham số
        public SanPhamDTO() { }

        // Constructor đầy đủ tham số
        public SanPhamDTO(string maSP, string tenSP, string loaiHang, int soLuong, decimal giaBan)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.LoaiHang = loaiHang;
            this.SoLuongTon = soLuong;
            this.GiaBan = giaBan;
        }
    }
}