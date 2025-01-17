﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Web.Controllers
{
    public class AboutController : Controller
    {
        IAboutManager aboutManager = new IAboutManager(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkımda Güncelle";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Güncelle";
            var values = aboutManager.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index");
        }
    }
}
