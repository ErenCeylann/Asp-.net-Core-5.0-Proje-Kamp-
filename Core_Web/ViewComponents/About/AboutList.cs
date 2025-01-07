using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace Core_Web.ViewComponents.About
{
    public class AboutList: ViewComponent
    {
        IAboutManager aboutManager = new IAboutManager(new EfAboutDal());
        public IViewComponentResult Invoke() 
        {
            var values = aboutManager.GetList();
            return View(values); 
        }
    }
}
