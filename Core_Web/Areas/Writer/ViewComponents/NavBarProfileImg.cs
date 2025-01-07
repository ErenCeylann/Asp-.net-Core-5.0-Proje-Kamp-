using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Web.Areas.Writer.ViewComponents
{
    public class NavBarProfileImg:ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public NavBarProfileImg(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = user.ImageUrl;
            return View(user);
        }
    }
}
