using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Web.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperincesManager experincesManager = new ExperincesManager(new EfExperinceDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experincesManager.GetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experince p)
        {
            experincesManager.TAdd(p);
            var value = JsonConvert.SerializeObject(p);
            return Json(value);
        }

        public IActionResult GetById(int ExperinceId)
        {
            var v=experincesManager.TGetById(ExperinceId);
            var values=JsonConvert.SerializeObject(v);
            return Json(values);
        }

        public IActionResult ExperienceDelete(int id)
        {
            var v = experincesManager.TGetById(id);
            experincesManager.TDelete(v);
            return NoContent();
        }
        [HttpGet]
        public IActionResult ExperienceUpdate(int ExperinceId)
        {
            var v = experincesManager.TGetById(ExperinceId);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }
        [HttpPost]
        public IActionResult ExperienceUpdate(Experince experince)
        {
          experincesManager.TUpdate(experince);
            var values = JsonConvert.SerializeObject(experince);
            return Json(values);
        }
    }
}
