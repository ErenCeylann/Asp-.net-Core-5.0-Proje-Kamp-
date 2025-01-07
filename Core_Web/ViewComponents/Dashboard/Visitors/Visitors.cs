using Microsoft.AspNetCore.Mvc;

namespace Core_Web.ViewComponents.Dashboard.Visitors
{
    public class Visitors:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
