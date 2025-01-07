using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Web.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DefaultController : Controller
    {
        AnnouncementManager _AnnouncementManager = new AnnouncementManager(new EfAnnouncementDal());
        [Authorize]
        
        public IActionResult Index()
        {
            var values = _AnnouncementManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            var value = _AnnouncementManager.TGetById(id);
            return View(value);
        }
    }
}
