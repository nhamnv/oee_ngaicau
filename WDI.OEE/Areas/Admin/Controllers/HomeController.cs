using Microsoft.AspNetCore.Mvc;

namespace WDI.OEE.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
