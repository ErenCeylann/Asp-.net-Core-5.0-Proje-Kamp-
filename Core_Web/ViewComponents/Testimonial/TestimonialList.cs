using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Web.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager manager=new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = manager.GetList();
            return View(values);
        }
    }
}
