using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using issHospital_Utility.DTOs;
using issHospital_Business;
using issHospital_Repo.Models;

namespace issHospital.Controllers
{
    public class patregController : Controller
    {
        public Patreg ObjModel = new Patreg();

        // GET: Patreg
        public ActionResult Index()
        {
            List<PatregDTO> objPatreg = ObjModel.getPatregDetails();
            return View(objPatreg);
        }

        // GET: Patreg/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Patreg/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patreg/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Age,Name,FName,Add,Phone,Sex,type,Nation,Passport,visa,PathName,DOB,isDeleted,deletedBy,deletedOn,updatedBy,UpdatedOn,UHID")] TblPatreg Patreg)
        {
            try
            {
                // TODO: Add insert logic here
                Patreg.deletedBy = 12;
                Patreg.deletedOn = DateTime.UtcNow;
                Patreg.updatedBy = 12;
                Patreg.UpdatedOn = DateTime.Now;
                int res = ObjModel.savePatreg(Patreg);
                if (res == 1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Patreg/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Patreg/Edit/5
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

        // GET: Patreg/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Patreg/Delete/5
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