using issHospital_Repo;
using issHospital_Repo.Models;

using issHospital_Utility.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Business
{
    public class Doctors
    {

        private DoctorsRepo objRepo = new DoctorsRepo();

        public List<DoctorDTO> getDoctorDetails()
        {
            List<DoctorDTO> lstDoctor = objRepo.getDoctorsDetails();

            return lstDoctor;
        }
        public int SaveDoctors(Tbldoctors Doctor)
        {
            int Respance = objRepo.SaveDoctors(Doctor);
            return Respance;
        }

    }
}

    

