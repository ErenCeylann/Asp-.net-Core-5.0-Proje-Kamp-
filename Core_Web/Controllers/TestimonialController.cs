using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Web.Controllers
{
    
    public class TestimonialController : Controller
    {
        TestimonialManager manager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var value = manager.GetList();
            return View(value);
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value=manager.TGetById(id);
            manager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            var  values=manager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTestimonial(Testimonial p)
        {
             manager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
