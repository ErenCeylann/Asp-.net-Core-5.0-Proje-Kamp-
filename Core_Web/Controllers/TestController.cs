using Microsoft.AspNetCore.Mvc;

namespace Core_Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
