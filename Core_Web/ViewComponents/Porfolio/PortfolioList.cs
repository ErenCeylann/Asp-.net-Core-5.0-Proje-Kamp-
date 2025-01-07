using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Web.ViewComponents.Porfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager portfolioManager=new PortfolioManager(new EfPortfolioDal());
        
        public IViewComponentResult Invoke()
        {
            var values=portfolioManager.GetList();
            return View(values);
        }
    }
}
