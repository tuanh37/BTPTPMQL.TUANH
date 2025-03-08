using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View( new BMIModel());
        }

        [HttpPost]
        public IActionResult Index(double weight, double height)
        {
            // Nếu chiều cao nhập vào lớn hơn 10, giả sử là cm, cần đổi sang mét
            if (height > 10)
            {
                height /= 100;
            }

            // Kiểm tra dữ liệu hợp lệ
            if (weight <= 0 || height <= 0)
            {
                ViewBag.Result = "❌ Lỗi: Cân nặng và chiều cao phải lớn hơn 0.";
                return View();
            }

            // Tính BMI
            double bmi = weight / (height * height);

            // Xác định phân loại BMI
            string category;
            if (bmi < 18.5) category = "Gầy";
            else if (bmi < 25) category = "Bình thường";
            else if (bmi < 30) category = "Thừa cân";
            else category = "Béo phì";

            // Gửi kết quả về View
            ViewBag.Result = $"📊 Kết quả BMI: {bmi:F2} - {category}";
            return View();
        }
    }
}