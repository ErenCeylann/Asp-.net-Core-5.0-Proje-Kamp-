using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Web.ViewComponents.Dashboard.DashboardStatistics
{
    public class DashboardStatistics:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v4 = c.Porfolios.Count();
            ViewBag.v5 = c.Messages.Count();
            ViewBag.v6 = c.Services.Count();
            return View();
        }
    }
}
