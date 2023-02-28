using issHospital_Business;
using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace issHospital.Controllers
{
    public class OPController : Controller
    {
        private op objBus = new op();
        // GET: OP
        public ActionResult Index()
        
        {
           List<opDTO> resp = objBus.getOpDetails();
            return View(resp);
        }

        // GET: OP/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OP/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OP/Create
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

        // GET: OP/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OP/Edit/5
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

        // GET: OP/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OP/Delete/5
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
