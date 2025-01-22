using Microsoft.AspNetCore.Mvc;

namespace Web_AdForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}