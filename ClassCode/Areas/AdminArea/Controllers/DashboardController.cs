using Microsoft.AspNetCore.Mvc;

namespace ClassCode.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]

    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
