using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Web.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialmediamanager = new SocialMediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {
            var value=socialmediamanager.GetList();
            return View(value);
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia p)
        {
            p.Status = true;
            socialmediamanager.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var values = socialmediamanager.TGetById(id);
            socialmediamanager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = socialmediamanager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            socialmediamanager.TUpdate(socialMedia);
            return RedirectToAction("Index");
        }
    }
}
