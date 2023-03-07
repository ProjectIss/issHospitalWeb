using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using issHospital_Repo.Models;
using issHospital_Business;
using issHospital_Utility.DTOs;

namespace issHospital.Controllers
{
    public class DeptController : Controller
    {
        private Dept objDept = new Dept();
        // GET: Dept
        public ActionResult Index()
        {
            List<DeptDTO> objdept = objDept.getDeptDetails();
            return View(objdept);
        }

        // GET: Dept/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dept/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dept/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,isDeleted,deletedBy,deletedOn,updatedBy,UpdatedOn,Department,Description")] TblDept tblDept)
        {
            try
            {
                // TODO: Add insert logic here
                tblDept.deletedBy = 23;
                tblDept.deletedOn = DateTime.UtcNow;
                tblDept.updatedBy = 23;
                tblDept.UpdatedOn = DateTime.Now;
                int nReturn = objDept.SaveDepartment(tblDept);
                if (nReturn==1)
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

        // GET: Dept/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dept/Edit/5
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

        // GET: Dept/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dept/Delete/5
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
