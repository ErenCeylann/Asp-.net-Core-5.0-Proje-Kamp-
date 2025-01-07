using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Core_Web.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class WriterDashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public WriterDashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        Context c = new Context();
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = user.Name + " " + user.SurName;

            //hava durumu api
            string ip = "01f843ee7801f3ab6113984b2a715978";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=ni%C4%9Fde&mode=xml&appid=" + ip;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //istatistikler
            ViewBag.v1 = c.WriterMessages.Where(x => x.Receiver == user.Email).Count();
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.Users.Count();
            ViewBag.v4 = c.Skills.Count();
            return View();
        }
    }
}

//https://api.openweathermap.org/data/2.5/weather?q=ni%C4%9Fde&appid=01f843ee7801f3ab6113984b2a715978&mode=xml