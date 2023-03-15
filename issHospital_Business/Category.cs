using issHospital_Repo;
using issHospital_Repo.Models;

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

        public int SaveCategory(TblCategory category)
        {
            int Respance = objRepo.SaveCategory(category);
            return Respance;
        }
    
    }
}

    

