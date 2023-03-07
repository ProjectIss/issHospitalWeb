using issHospital_Repo;


using issHospital_Utility.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Business
{ 
      public class itemRepo
  {
      private itemRepo objRepo = new itemRepo();

      public List<SupplierDTO> getOpDetails()
    {
        List<SupplierDTO> lstItemSetup = objRepo.getOpDetails();

       return lstItemSetup;
    }
 }
}




