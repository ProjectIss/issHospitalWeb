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
    public class MenuSetupController : Controller
    {
        MenuSetup ObjModel = new MenuSetup();
        
        // GET: MenuSetup
        public ActionResult Index()
        {
            List<MenuSetupDTO> objMenu= ObjModel.getMenuSetupDetails();
            return View(objMenu);
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
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,Name,EmailID,PhoneNo,address,isDeleted,deletedBy,deletedOn,updatedBy,UpdatedOn")] TblMenuSetup MenuMaster)
        {
            try
            {
                // TODO: Add insert logic here
                MenuMaster.deletedBy = 12;
                MenuMaster.deletedOn = DateTime.UtcNow;
                MenuMaster.updatedBy = 12;
                MenuMaster.UpdatedOn = DateTime.Now;
                int res= ObjModel.saveMenuSetup(MenuMaster);
                if (res==1)
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
