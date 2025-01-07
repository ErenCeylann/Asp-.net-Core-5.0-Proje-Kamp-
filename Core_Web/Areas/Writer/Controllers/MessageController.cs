using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Web.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager messageManager = new WriterMessageManager(new EfWriterMessageDal());
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p = user.Email;
            var messagelist=messageManager.GetListReceiverMessage(p);
            return View(messagelist);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p = user.Email;
            var messagelist = messageManager.GetListSenderMessage(p);
            return View(messagelist);
        }

        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            var value = messageManager.TGetById(id);
            return View(value);
        }
        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task <IActionResult> SendMessage(WriterMessage p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = user.Email;
            p.Sender = mail;
            p.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.SenderName = user.Name + " " + user.SurName;
            Context c = new Context();
            var usernamesurname=c.Users.Where(x=>x.Email == p.Receiver).Select(x => x.Name +" "+ x.SurName).FirstOrDefault(); 
            p.ReceiverName = usernamesurname;
            messageManager.TAdd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
