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
                      List<SupplierDTO> lstSupplier = db.tblsupplier.Where(x => x.isDeleted == false).Select(x => new SupplierDTO
                      {
                           Id=x.Id,
                           Code=x.Code,
                           OB=x.OB,
                           CName = x.CName,
                           Cphone = x.Cphone,

                      }).ToList();

                  return lstSupplier;

                   }

                  catch (Exception)
               {
                  return new List<SupplierDTO>();
            
            }

        }

        private void Tolist()
        {
            throw new NotImplementedException();
        }
    }
}
