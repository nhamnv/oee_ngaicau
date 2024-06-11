using Microsoft.AspNetCore.Mvc;

namespace WDI.OEE.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult LoginForm()
        {
            return View();
        }
    }
}
