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
                List<CategoryDTO> lstCategory = db.tblCategory.Where(x => x.isDeleted == false).Select(x => new CategoryDTO
                {
                    Id = x.Id,
                    ENo = x.ENo,


                }).ToList();

                return lstCategory;
            }
            catch (Exception ex)
            {

                return new List<CategoryDTO>();
            }

        }
        public int SaveCategory(Models.TblCategory category)
        {
            int a = 1;
            db.tblCategory.Add(category);
            db.SaveChanges();
            return a;
        }
    }

}