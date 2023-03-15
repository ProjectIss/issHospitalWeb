using System;
using issHospital_Repo;
using issHospital_Repo.Models;
using issHospital_Utility.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace issHospital_Business
{
    public  class Prescription
    {
         PrescriptionRepo objRepo = new PrescriptionRepo();

        public List<PrescriptionDTO> GetPrescriptionBs()
        {
            List<PrescriptionDTO> lstPre = objRepo.getprescriptionsDetails();

            return lstPre;
        }

        public int SavePrescription(TblPrescription tblprescription)
        {

            int Respance = objRepo.SavePrescription(tblprescription);
            return Respance;


        }
    }
}
