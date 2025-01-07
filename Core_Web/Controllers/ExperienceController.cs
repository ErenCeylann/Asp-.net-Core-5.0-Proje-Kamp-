using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Core_Web.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ExperienceController : Controller
    {
        ExperincesManager experincesManager = new ExperincesManager(new EfExperinceDal());
        public IActionResult Index()
        {
            
            var values = experincesManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experince experince)
        {
            experincesManager.TAdd(experince);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value=experincesManager.TGetById(id);
            experincesManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            
            var value = experincesManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditExperience(Experince experince)
        {
            experincesManager.TUpdate(experince);
            return RedirectToAction("Index");
        }
    }
}
