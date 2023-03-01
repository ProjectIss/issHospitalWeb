using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace issHospital.Controllers
{
    public class ItemSetupController : Controller
    {
        // GET: ItemSetup
        public ActionResult Index()
        {
           
            return View();
        }

        // GET: ItemSetup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemSetup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemSetup/Create
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

        // GET: ItemSetup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemSetup/Edit/5
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

        // GET: ItemSetup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemSetup/Delete/5
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
