﻿using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        ShopEntities StoreDB = new ShopEntities();
        private List<Item> GetTopSellingItems(int count)
        {
            return StoreDB.Items.OrderByDescending(i => i.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
        public ActionResult Index()
        {
            var items = GetTopSellingItems(10);
            return View(items);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}