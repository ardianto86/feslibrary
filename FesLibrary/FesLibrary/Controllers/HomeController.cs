﻿using FesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FesLibrary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Catalogue()
        {
            ViewBag.Message = "Catalogue";

            CatalogueContext context = new CatalogueContext();
            List<CatalogueItem> items = context.CatalogueItems.ToList<CatalogueItem>();
            return View(items);
        }

        public ActionResult Borrow(int id)
        {
            return RedirectToAction("Catalogue");
        }

        public ActionResult Extend(int id)
        {
            return RedirectToAction("Catalogue");
        }

        public ActionResult Return(int id)
        {
            return RedirectToAction("Catalogue");
        }

        [HttpGet]
        public ActionResult AddItem()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult AddItem(FormCollection formCollection)
        {
            CatalogueItem item = new CatalogueItem();
            item.ID = Convert.ToInt64(formCollection["ID"]);
            item.Title = formCollection["Title"];
            item.Authors = formCollection["Authors"];
            item.Status = "available";
            CatalogueContext context = new CatalogueContext();

            int ret = context.AddItem(item);
            return RedirectToAction("Catalogue");
        }
    }
}