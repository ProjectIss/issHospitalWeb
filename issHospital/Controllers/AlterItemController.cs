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
    public class AlterItemController : Controller
    {
        public AlterItem objModel = new AlterItem();

        // GET: AlterItem
        public ActionResult Index()
        {
            List<AlterItemDTO> objAlter = objModel.getAlterItemDetails();
            return View(objAlter);
        }

        // GET: AlterItem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlterItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlterItem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ItemName,AlterItem,isDeleted,deletedBy,deletedOn,updatedBy,UpdatedOn")] TblAlterItem Alter)
        {
            try
            {
                // TODO: Add insert logic here
                Alter.deletedBy = 12;
                Alter.deletedOn = DateTime.UtcNow;
                Alter.updatedBy = 12;
                Alter.UpdatedOn = DateTime.Now;
                int res = objModel.saveAlterItem(Alter);
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

        // GET: AlterItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlterItem/Edit/5
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

        // GET: AlterItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlterItem/Delete/5
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