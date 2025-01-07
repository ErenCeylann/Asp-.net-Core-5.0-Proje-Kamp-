using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Core_Web.ViewComponents.AdminNavbarMessage
{
    public class AdminNavbarMessageList:ViewComponent
    {
        WriterMessageManager messageManager = new WriterMessageManager(new EfWriterMessageDal());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            string p = "admin@gmail.com";
            var deger = messageManager.GetListReceiverMessage(p).Select(x => x.Sender).FirstOrDefault();
            var ımage = c.Users.Where(x => x.Email == deger).Select(z => z.ImageUrl).FirstOrDefault();
            ViewBag.v1 = ımage;
            var value = messageManager.GetListReceiverMessage(p).OrderByDescending(x=>x.WriterMessageID).Take(3).ToList();
            return View(value);
        }
    }
}
