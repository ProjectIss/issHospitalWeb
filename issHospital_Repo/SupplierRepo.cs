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
                List<SupplierDTO> lstSupplier = db.Suppliers.Where(x => x.isDeleted == false).Select(x => new SupplierDTO

            }) Tolist();

            catch (Exception)
            {

                throw;
            }

        }
    }
}
