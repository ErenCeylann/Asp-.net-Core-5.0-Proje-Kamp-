using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Web.ViewComponents.Dashboard.PortfolioStatistics
{
    public class PortfolioStatistics:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var values = c.Porfolios.OrderByDescending(x => x.PortfolioId).Take(5).ToList();
            return View(values);
        }
    }
}
