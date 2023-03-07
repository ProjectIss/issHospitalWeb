using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo
{
    public class MenuSetupRepo
    {
        private issDB db = new issDB();
        public List<MenuSetupDTO> getMenuSetupDetails()
        {
            try
            {
                List<MenuSetupDTO> lstMenuSetup = db.MenuSetups.Where(x => x.isDeleted == false).Select(x => new MenuSetupDTO
                {
                    Id = x.Id,
                    Code = x.Code,
                    Name = x.Name,
                    EmailID = x.EmailID,
                    PhoneNo = x.PhoneNo,
                    address = x.address

                }).ToList();

                return lstMenuSetup;

            }

            catch (Exception Ex)
            {

                return new List<MenuSetupDTO>();
            }

        }
        public int saveMenuSetup(Models.TblMenuSetup tblmenu)
        {
            try
            {
                int a = 1;
                db.MenuSetups.Add(tblmenu);
                db.SaveChanges();
                return a;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
