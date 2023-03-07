using issHospital_Business;
using issHospital_Repo.Models;
using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace issHospital.Controllers
{
    public class PrescriptionController : Controller
    {
        private Prescription objBusiness = new Prescription();
        // GET: Prescription
        public ActionResult Index()
        {
            return View();
        }

        // GET: Prescription/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Prescription/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prescription/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "billno,age")] TblPrescription prescriptionDTO)
        {
            try
            {

                //  prescriptionDTO.isDeleted = DateTime.Now;

               int res= objBusiness.savePrescription(prescriptionDTO);
                if (res==1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(prescriptionDTO);
                }
                // TODO: Add insert logic here

                
            }
            catch
            {
                return View();
            }
        }

        // GET: Prescription/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prescription/Edit/5
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

        // GET: Prescription/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prescription/Delete/5
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
