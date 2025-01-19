using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
