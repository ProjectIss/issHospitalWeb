using System;
using issHospital_Repo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issHospital_Repo.Models;


namespace issHospital_Business
{
   public class Supplier
    {
        private SupplierRepo objRepo = new SupplierRepo();
        public object tblSupplier;

        public int saveSupplier(Tblsupplier Supplier)
        {
            int resp = objRepo.savePrescription(tblSupplier);

            return resp;
        }

        public int SaveSupplier(Tblsupplier Supplier)
        {

            int Respance = objRepo.saveSupplier(tblSupplier);
            return Respance;


        }
    }
}
