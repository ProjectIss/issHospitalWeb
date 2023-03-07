using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace issHospital_Repo
{
    public class CategoryRepo
    {
        private issDB db = new issDB();
        public List<CategoryDTO> getCategoryDetails()
        {
            try
            {
                List<CategoryDTO> lstCategory = db.tblcategories.Where(x => x.isDeleted == false).Select(x => new CategoryDTO
                {
                    Id=x.Id,
                    ENo=x.ENo,


                }).ToList();

                return lstCategory;
            }
            catch (Exception ex)
            {

                return new List<CategoryDTO>();
            }
        }
    }
}
