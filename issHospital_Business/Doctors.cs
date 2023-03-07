using issHospital_Repo;
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

        public List<DoctorsDTO> getDoctorDetails()
        {
            List<DoctorsDTO> lstDoctor = objRepo.getDoctorsDetails();

            return lstDoctor;
        }

    }
}

    

