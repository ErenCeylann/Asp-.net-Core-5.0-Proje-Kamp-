using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Web.ViewComponents.Dashboard.FeatureStatistics
{
    public class FeatureStatistics:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v4 = c.Skills.Count();
            ViewBag.v5 = c.Messages.Where(x => x.Status == true).Count();
            ViewBag.v6 = c.Messages.Where(x => x.Status == false).Count();
            ViewBag.v7 = c.Experinces.Count();
            return View();
        }
    }
}
