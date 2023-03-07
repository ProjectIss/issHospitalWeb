using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Utility.DTOs
{
   public class DoctorsDTo
    {
        public int Id { get; set; }
        public int doctorId { get; set; }
        public int ENo { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string FName { get; set; }
    }
}
