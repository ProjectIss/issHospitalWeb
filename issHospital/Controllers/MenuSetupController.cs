using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace issHospital.Controllers
{
    public class MenuSetupController : Controller
    {
        // GET: MenuSetup
        public ActionResult Index()
        {
            return View();
        }

        // GET: MenuSetup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MenuSetup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuSetup/Create
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

        // GET: MenuSetup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MenuSetup/Edit/5
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

        // GET: MenuSetup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenuSetup/Delete/5
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
