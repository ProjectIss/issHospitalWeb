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
   public class Patreg
    {
        private PatregRepo objRepo = new issHospital_Repo.PatregRepo();

        public List<PatregDTO> getPatregDetails()
        {
            List<PatregDTO> lstPatreg = objRepo.getPatregDetails();

            return lstPatreg;
        }

        public int savePatreg(TblPatreg patreg)
        {
            int respance = objRepo.SavePatreg(patreg);
            return (respance);
        }
    }
}
