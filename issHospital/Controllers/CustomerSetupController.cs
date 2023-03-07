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
    public class CustomerSetupController : Controller
    {
        public CustomerSetup ObjModel = new CustomerSetup();

        // GET: CustomerSetup
        public ActionResult Index()
        {
            List<CustomerSetupDTO> objCustomer = ObjModel.getCustomerSetupDetails();
            return View(objCustomer);
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
        public ActionResult Create([Bind(Include ="id,Code,OB,Ccode,CName,Cphone,Cother,FName,Discount,CPadd,isDeleted,deletedBy,deletedOn,updatedBy,UpdatedOn")] TblCustomerSetup customer)
        {
            try
            {
                // TODO: Add insert logic here
                customer.deletedBy = 12;
                customer.deletedOn = DateTime.UtcNow;
                customer.updatedBy = 12;
                customer.UpdatedOn = DateTime.Now;
                int res = ObjModel.saveCustomerSetup(customer);
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
