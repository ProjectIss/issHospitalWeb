using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Business
{
    public class CategoryRepo
    {

        private CategoryRepo objRepo = new CategoryRepo();

        public List<CategoryDTO> getCategoryDetails()
        { 
          List<CategoryDTO> lstCategory = objRepo.getCategoryDetails();

          return lstCategory;
        }
    
    }
}

    

