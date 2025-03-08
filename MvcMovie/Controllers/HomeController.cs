using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string FullName, string Address)
        {
            string strOutput = "Xin chào " + FullName + " đến từ " + Address;
            ViewBag.Message = strOutput;
            return View();
        }
    }
}
