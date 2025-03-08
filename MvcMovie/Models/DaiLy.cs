namespace MvcMovie.Models
{
    public class DaiLy
    {
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }
        public string MaHTPP { get; set; }  // Khóa ngoại liên kết với HeThongPhanPhoi

        public DaiLy()
        {
            MaDaiLy = string.Empty;
            TenDaiLy = string.Empty;
            DiaChi = string.Empty;
            NguoiDaiDien = string.Empty;
            DienThoai = string.Empty;
            MaHTPP = string.Empty;
        }

        // Liên kết với HeThongPhanPhoi
        public HeThongPhanPhoi? HeThongPhanPhoi { get; set; }
    }
}
