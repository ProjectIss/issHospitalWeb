using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Utility.DTOs
{
   public class PatregDTO
    {
        public int Id { get; set; }
        public int UHID { get; set; }
        public int Age { get; set; }

        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Add { get; set; }
    }
}
