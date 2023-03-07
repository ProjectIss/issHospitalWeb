using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using issHospital_Business;
using issHospital_Utility.DTOs;

namespace issHospital.Controllers
{
    public class ReceiptController : Controller
    {
        Receipt objBus = new Receipt();
        // GET: Receipt
        public ActionResult Index()
        {
            List<ReceiptDTO> resp = objBus.getReceiptDetails();
            return View(resp);
        }
    }
}