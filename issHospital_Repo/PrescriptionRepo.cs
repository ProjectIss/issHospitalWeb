using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo
{
       public class PrescriptionRepo
    {
        private issDB db = new issDB();
        public List<PrescriptionDTO> getprescriptionsDetails()
        {
            try
            {
                List<PrescriptionDTO> lstPrescription = db.tblPrescriptions.Where(x => x.isDeleted == false).Select(x => new PrescriptionDTO
                {
                    Id = x.Id,
                    ENo= x.ENo,
                    billno = x.billno,
                    age = x.age,


                }).ToList();

                return lstPrescription;
            }
            catch (Exception)
            {

                return new List<PrescriptionDTO>();
            }

        }
    }
}
