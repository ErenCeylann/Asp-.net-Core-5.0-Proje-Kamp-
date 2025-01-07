using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Web.Controllers
{
    public class DashboardController : Controller
    {
        
        public IActionResult Index()
        {
            ViewBag.v1 = "Admin Sayfası";
            ViewBag.v2 = "Admin";
            ViewBag.v3 = "Admin Sayfası";
            return View();
        }
    }
}
