﻿using MobileShopOnline.Models;
using System.Linq;
using System.Web.Mvc;

namespace MobileShopOnline.Controllers
{
    public class NewsCategoryController : Controller
    {
        MobileShopOnlineEntities db = new MobileShopOnlineEntities();
        // GET: NewsCategory
        public ActionResult Index()
        {
            var newsList = db.News.ToList();
            return View(newsList);
        }

        public ActionResult News(int id)
        {
            var news = db.News.FirstOrDefault(n => n.NewsID == id);
            ViewBag.IndexOfDot = news.NewsContent.IndexOf(".");
            return View(news);
        }
    }
}