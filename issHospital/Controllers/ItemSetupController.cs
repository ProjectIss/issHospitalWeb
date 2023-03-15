using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using issHospital_Repo.Models;
using issHospital_Business;

namespace issHospital.Controllers
{
    public class ItemSetupController : Controller
    {

        public itemSetup objModel = new itemSetup();

        // GET: ItemSetup
        public ActionResult Index()
        {
            List<ItemSetupDTO> objItemSetup = objModel.getItemsetupDetails();
            return View(objItemSetup);
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
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Reorder,Tax,Sprice,Menu,Commcode,Schedule,categoryId,Generic,isDeleted,deletedBy,deletedOn,updatedBy,UpdatedOn")] TblItemSetup ItemSetup)

        {
            try
            {
                // TODO: Add insert logic here
                ItemSetup.deletedBy = 23;
                ItemSetup.deletedOn = DateTime.UtcNow;
                ItemSetup.updatedBy = 23;
                ItemSetup.updatedOn = DateTime.Now;
                int nReturn = objModel.SaveItemSetup(ItemSetup);
                if (nReturn == 1)
                    return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }

            return View();

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
