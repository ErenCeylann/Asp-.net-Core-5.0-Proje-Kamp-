using Core_Web.Areas.Writer.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Core_Web.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = user.Name;
            model.Email = user.Email;
            model.SurName = user.SurName;
            model.PictureUrl = user.ImageUrl;
            model.UserName = user.UserName;
            ViewBag.profileımage = user.ImageUrl;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Picture != null)
            {
                //resim ekleme komutu
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Picture.FileName);
                var ımagename = Guid.NewGuid() + extension;
                var savalocation = resource + "/wwwroot/UserImage/" + ımagename;
                var stream = new FileStream(savalocation, FileMode.Create);
                await p.Picture.CopyToAsync(stream);
                values.ImageUrl = ımagename;
            }
            values.Name = p.Name;
            values.SurName = p.SurName;
            values.Email = p.Email;
            values.UserName = p.UserName;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, p.Password);
            var result=await _userManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Default");
            }
            
            return View();
        }
    }
}
