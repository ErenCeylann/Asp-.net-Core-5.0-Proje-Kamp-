using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Web.ViewComponents.Porfolio
{
    public class SlideList:ViewComponent
    {
        PortfolioManager manager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values=manager.GetList();
            return View(values);
        }
    }
}
