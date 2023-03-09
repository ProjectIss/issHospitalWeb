using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo
{
    public class DoctorsRepo
    {
        private issDB db = new issDB();
        public List<DoctorDTO> getDoctorsDetails()
       
        {
            try
            {
                List<DoctorDTO> lstDoctor = db.tblDoctor.Where(x => x.isDeleted == false).Select(x => new DoctorDTO
                {
                 doctorId=x.doctorId,
                 ENo=x.ENo,


                }).ToList();

                return lstDoctor;
            }
            catch (Exception)
            {

              
                return new List<DoctorDTO>();
            }
        }
    }
}







        

    

            