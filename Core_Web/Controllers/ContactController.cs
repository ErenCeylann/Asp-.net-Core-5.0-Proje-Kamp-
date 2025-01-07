using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Web.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.GetList();
            return View(values);
        }

        public IActionResult MessageDelete(int id)
        {
            var value = messageManager.TGetById(id);
            messageManager.TDelete(value);
            return RedirectToAction("Index");
        }

        public IActionResult ContactDetails(int id)
        {
            var value = messageManager.TGetById(id);
            return View(value);
            
        }
    }
}
