using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo
{
   public class CustomerSetupRepo
   {
        private issDB db = new issDB();
        public List<CustomerSetupDTO> getCutomerSetupDetails()
        {
            try
            {
                List<CustomerSetupDTO> lstCustomerSetup = db.CustomerSetups.Where(x => x.isDeleted == false).Select(x => new CustomerSetupDTO
                {
                    Id = x.Id,
                    Code = x.Code,
                    OB = x.OB,
                    Ccode = x.Ccode,
                    CName = x.CName,
                    Cphone = x.Cphone

                }).ToList();

                return lstCustomerSetup;

            }
             
            catch(Exception Ex)
            {

                return new List<CustomerSetupDTO>();
            }
            
        }

        public int SaveCustomerSetup(Models.TblCustomerSetup customer)
        {
            try
            {

                int a = 1;
                db.CustomerSetups.Add(customer);
                db.SaveChanges();
                return a;


            }
            catch (Exception ex)
            {
                
                throw;
            }
                    
        }            
   }
}
