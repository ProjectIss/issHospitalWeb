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
    public class ReceiptController : Controller
    {
        public Receipt objModel = new Receipt();

        // GET: Receipt
        public ActionResult Index()
        {
            List<ReceiptDTO> lstReceipt = objModel.getReceiptDetails();
            return View(lstReceipt);
        }

        // GET: Receipt/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Receipt/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Receipt/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SlNo,Amount,Age,Name,Doctor,Purpose,dept,sex,Type,BP,weight,Temp,FName,UserName,Date,Billtime,isDeleted,deletedBy,deletedOn,updatedBy,UpdatedOn,UHID")] TblReceipt Receipt)
        {
            try
            {
                // TODO: Add insert logic here
                Receipt.deletedBy = 23;
                Receipt.deletedOn = DateTime.UtcNow;
                Receipt.updatedBy = 23;
                Receipt.UpdatedOn = DateTime.Now;
                int nReturn = objModel.SaveReceipt(Receipt);
                if (nReturn == 1)
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

        // GET: Receipt/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Receipt/Edit/5
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

        // GET: Receipt/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Receipt/Delete/5
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