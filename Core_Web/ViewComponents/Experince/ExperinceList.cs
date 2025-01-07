using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Web.ViewComponents.Experince
{
    public class ExperinceList:ViewComponent
    {
        ExperincesManager experincesManager=new ExperincesManager(new EfExperinceDal());

        public IViewComponentResult Invoke()
        {
            var values = experincesManager.GetList();
            return View(values);
        }
    }
}
