using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo
{
    public class DeptRepo
    {
        private issDB db = new issDB();
        public List<DeptDTO> getDeptDetails()
        {
            try
            {
                List<DeptDTO> lstDept = db.tblDepts.Where(x => x.isDeleted == false).Select(x => new DeptDTO
                {
                    Id = x.Id,
                    Description = x.Description,
                    Department = x.Department

                }).ToList();

                return lstDept;

            }

            catch (Exception Ex)
            {

                return new List<DeptDTO>();
            }

        }
        public List<DeptDTO> getDeptDetailsBYId(int Id)
        {
            try
            {
                List<DeptDTO> lstDept = db.tblDepts.Where(x => x.isDeleted == false && x.Id == Id).Select(x => new DeptDTO
                {
                    Id = x.Id,
                    Description = x.Description,
                    Department = x.Department

                }).ToList();

                return lstDept;

            }

            catch (Exception Ex)
            {

                return new List<DeptDTO>();
            }

        }

        public int SaveDept(Models.TblDept tbldept)
        {
            int a = 1;
            db.tblDepts.Add(tbldept);
            db.SaveChanges();
            return a;
        }
    }
}
