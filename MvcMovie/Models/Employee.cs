using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Employee
    {
        // Id của nhân viên (chính)
        [Key]
        public int EmployeeId { get; set; }

        // Mã nhân viên (PersonId có thể là khóa ngoại, tùy thuộc vào cấu trúc cơ sở dữ liệu)
        [Required]
        [StringLength(50)]
        public required string PersonId { get; set; }  // Thêm required modifier để yêu cầu giá trị

        // Họ và tên của nhân viên
        [Required]
        [StringLength(100)]
        public required string FullName { get; set; }  // Thêm required modifier để yêu cầu giá trị

        // Địa chỉ của nhân viên
        [StringLength(200)]
        public string? Address { get; set; }  // Để Address có thể là nullable nếu không cần thiết phải có

        // Tuổi của nhân viên
        [Range(18, 100)]
        public int Age { get; set; }

        // Lương của nhân viên
        [Range(0, double.MaxValue)]
        public decimal Salary { get; set; }
    }
}
