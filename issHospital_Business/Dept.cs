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
    public class Dept
    {
        private DeptRepo objRepo = new issHospital_Repo.DeptRepo();

        public List<DeptDTO> getDeptDetails()
        {
            List<DeptDTO> lstDept = objRepo.getDeptDetails();

            return lstDept;
        }
        public int SaveDepartment(TblDept dept)
        {
            int Respanse = objRepo.SaveDept(dept);
            return Respanse;
        }
    }
}
