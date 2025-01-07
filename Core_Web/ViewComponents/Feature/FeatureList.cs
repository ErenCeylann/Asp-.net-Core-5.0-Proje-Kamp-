using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Web.ViewCompenents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager FeatureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values=FeatureManager.GetList();
            return View(values);
        }
    }
}
