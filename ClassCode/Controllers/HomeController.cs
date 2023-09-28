using Microsoft.AspNetCore.Mvc;

namespace ClassCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
