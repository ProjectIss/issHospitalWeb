using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo
{
   public class presRepo
    {
        private issDB db = new issDB();
        public int savePrescription(Models.TblPrescription tblPrescription)
        {
            try
            {
                int A = 1;
                tblPrescription.ENo = 1;
                db.tblPrescriptions.Add(tblPrescription);
                db.SaveChanges();
                return A;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
