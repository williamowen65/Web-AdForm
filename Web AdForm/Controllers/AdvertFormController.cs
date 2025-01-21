using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_AdForm.Models;

namespace Web_AdForm.Controllers
{
    public class AdvertFormController : Controller
    {
        private readonly ILogger<AdvertFormController> _logger;

        public AdvertFormController(ILogger<AdvertFormController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
