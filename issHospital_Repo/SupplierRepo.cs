using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo
{
    class SupplierRepo
    {
        private issDB db = new issDB();

        public List<SupplierDTO> getSupplierDetails()

        {
            try
            {
                List<SupplierDTO> lstSupplier = db.tblsupplier.Where(x => x.isDeleted == false).Select
                    (x => new SupplierDTO
                    {
                        Ccode=x.Ccode,
                        CName=x.CName,
                        Code=x.Code,
                        Cphone=x.Cphone,
                        Id=x.Id,
                        OB=x.OB
                    }
            ).ToList();

                return lstSupplier;
            }
            catch (Exception ex)
            {
                //Create Error log
                throw;
            }

        }
    }
}
