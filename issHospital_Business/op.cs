using issHospital_Repo;

using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Business
{
    public class op
    {
        private opRepo objRepo = new opRepo();

        public List<opDTO> getOpDetails()
        {
            List<opDTO> lstOP = objRepo.getOPDetails();
            return lstOP;
        }
    }
}
