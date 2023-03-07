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
    public class CustomerSetup
    {
        private CustomerSetupRepo objRepo = new issHospital_Repo.CustomerSetupRepo();

        public List<CustomerSetupDTO> getCustomerSetupDetails()
        {
            List<CustomerSetupDTO> lstCustomerSetup = objRepo.getCutomerSetupDetails();

            return lstCustomerSetup;
        }

        public int saveCustomerSetup(TblCustomerSetup customer)
        {
            int respance = objRepo.SaveCustomerSetup(customer);
            return (respance);
        }
    }
}
