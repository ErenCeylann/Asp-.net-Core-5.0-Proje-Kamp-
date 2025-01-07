using Microsoft.AspNetCore.Mvc;

namespace Core_Web.Controllers
{
    public class ErorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error404()
        {
            return View();
        }
    }
}
