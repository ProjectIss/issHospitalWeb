using System;
using issHospital_Repo;
using issHospital_Repo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Business
{
    public  class Prescription
    {
        private presRepo objRepo = new presRepo();
        public int savePrescription(TblPrescription tblPrescription)
        {
            int resp=objRepo.savePrescription(tblPrescription);
            return resp;
        }
    }
}
