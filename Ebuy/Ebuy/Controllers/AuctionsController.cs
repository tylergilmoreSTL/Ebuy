using Ebuy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebuy.Controllers
{
    public class AuctionsController : Controller
    {
        //
        // GET: /Auctions/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Auctions/Details/5

        public ActionResult Details(Guid id)
        {
            var auction = new Auction()
            {
                Id = new Guid("c952c4e8-dd73-4a95-93e5-d6fa5afcea83"),
                Title = "Brand New Widget 2.0",
                Description = "This is a brand new widget, version 2.0!",
                StartPrice = 1.00m,
                CurrentPrice = 12.50m,
                StartTime = DateTime.Parse("5-5-2015 1:23 AM"),
                EndTime = DateTime.Parse("5-7-2015 12:41 PM")
            };
            return View(auction);
        }

        //
        // GET: /Auctions/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Auctions/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Auctions/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Auctions/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Auctions/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Auctions/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
