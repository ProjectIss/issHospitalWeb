using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using issHospital_Utility.DTOs;

namespace issHospital.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            List<CategoryDTO> lstCate = new List<CategoryDTO>();
            lstCate.Add(new CategoryDTO());
            return View(lstCate);
        }
    }
}