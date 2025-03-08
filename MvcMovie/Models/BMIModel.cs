namespace MvcMovie.Models
{
    public class BMIModel
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI => (Height > 0) ? Weight / (Height * Height) : 0;

        public string Category  // ✅ Thêm thuộc tính này
        {
            get
            {
                if (BMI < 18.5) return "Gầy";
                if (BMI < 24.9) return "Bình thường";
                if (BMI < 29.9) return "Thừa cân";
                return "Béo phì";
            }
        }
    }
}
