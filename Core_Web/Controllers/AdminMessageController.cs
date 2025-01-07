using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Core_Web.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager messageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            string p = "admin@gmail.com";
            var values = messageManager.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string p = "admin@gmail.com";
            var values = messageManager.GetListSenderMessage(p);
            return View(values);
        }

        public IActionResult AdminMessageDetails(int id)
        {
           
            var values = messageManager.TGetById(id);
            return View(values);
        }

       
        public IActionResult AdminMessageDelete(int id)
        {
            
            var value = messageManager.TGetById(id);
            messageManager.TDelete(value);
            var c = Request.Query["sender"];
            if (c=="sender")
            {
                return RedirectToAction("SenderMessageList");
            }

            else
            {
                return RedirectToAction("ReceiverMessageList");
            }
            
            
            
        }

        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "admin";
            Context c=new Context();
            var username = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.SurName).FirstOrDefault();
            p.ReceiverName = username;
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
           messageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
