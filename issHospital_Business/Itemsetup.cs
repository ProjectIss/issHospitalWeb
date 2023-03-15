using issHospital_Repo;
using issHospital_Repo.Models;

using issHospital_Utility.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Business
{
    public class itemSetup
    {
        private ItemRepo objRepo = new ItemRepo();

        public List<ItemSetupDTO> getItemsetupDetails()
        {
            List<ItemSetupDTO> lstItemSetup = objRepo.getItemSetupDetails();

            return lstItemSetup;
        }
        public int SaveItemSetup(TblItemSetup itemSetup)
        {
            int Respance = objRepo.SaveItemSetup(itemSetup);
            return Respance;
        }
    }
}




