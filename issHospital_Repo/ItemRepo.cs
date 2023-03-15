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
        public List<ItemSetupDTO> getItemSetupDetails()
        {
            try
            {
                List<ItemSetupDTO> lstItemSetup = db.tblItemSetup.Where(x => x.isDeleted == false).Select(x => new ItemSetupDTO
                {
                  Id=x.Id,
                  Reorder=x.Reorder,
                  price=x.price,
                  Menu=x.Menu,
                  Commcode=x.Commcode,


                }).ToList();
                
                return lstItemSetup;
            }
            catch (Exception ex )
            {

                return new List<ItemSetupDTO>();
            }
        }

        public int SaveItemSetup(Models.TblItemSetup ItemSetup)
        {
            int a = 1;
            db.tblItemSetup.Add(ItemSetup);
            db.SaveChanges();
            return a;
        }
    }
}
