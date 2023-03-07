using issHospital_Repo;

using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issHospital_Repo.Models;

namespace issHospital_Business
{
   public class MenuSetup
   {
        private MenuSetupRepo objRepo = new issHospital_Repo.MenuSetupRepo();

        public List<MenuSetupDTO> getMenuSetupDetails()
        {
            List<MenuSetupDTO> lstMenuSetup = objRepo.getMenuSetupDetails();

            return lstMenuSetup;
        }
        public int saveMenuSetup(TblMenuSetup tblMenu)
        {
           int respanse= objRepo.saveMenuSetup(tblMenu);
            return (respanse);
        }
   }
}
