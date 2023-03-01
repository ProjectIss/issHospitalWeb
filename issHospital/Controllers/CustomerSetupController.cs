using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace issHospital.Controllers
{
    public class CustomerSetupController : Controller
    {
        // GET: CustomerSetup
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerSetup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerSetup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerSetup/Create
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

        // GET: CustomerSetup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerSetup/Edit/5
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

        // GET: CustomerSetup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerSetup/Delete/5
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
