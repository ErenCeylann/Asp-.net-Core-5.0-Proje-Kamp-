using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Web.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager PortfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            
            var values=PortfolioManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio(int id)
        {
            
            var values = PortfolioManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult AddPortfolio(Porfolio porfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(porfolio);
            if (result.IsValid)
            {
                PortfolioManager.TAdd(porfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
   
        public IActionResult DeletePortfolio(int id)
        {
            var value=PortfolioManager.TGetById(id);
            PortfolioManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values=PortfolioManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Porfolio porfolio)
        {
            PortfolioManager.TUpdate(porfolio);
            return RedirectToAction("Index");
        }
    }
}
