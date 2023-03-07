using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Utility.DTOs
{
   public class CustomerSetupDTO
    {
        public int Id { get; set; }
        public int Code { get; set; }
        //public int discount { get; set; }
        public int OB { get; set; }
        public string Ccode { get; set; }
        public string CName { get; set; }
        public string Cphone { get; set; }
    }
}
