using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo
{
    public class ItemRepo
    {
        private issDB db = new issDB();
        public List<SupplierDTO> getItemSetupDetails()
        {
            try
            {
                List<SupplierDTO> lstItemSetup = db.itemSetups.Where(x => x.isDeleted == false).Select(x => new SupplierDTO
                {
                  Id=x.Id,
                  Reorder=x.Reorder,
                  price=x.Price,
                  Menu=x.Menu,
                  Commcode=x.Commcode,


                }).ToList();
                
                return lstItemSetup;
            }
            catch (Exception )
            {

                return new List<SupplierDTO>();
            }
        }
    }
}
