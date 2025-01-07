using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Web.ViewComponents.Dashboard.ProjectList
{
    public class ProjectList:ViewComponent
    {
        Context c=new Context();
        PortfolioManager portfolio=new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
           var values= portfolio.GetList();
            return View(values);
        }
    }
}
