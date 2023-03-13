using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Utility.DTOs
{
   public class ReceiptDTO
    {
        public int Id { get; set; }
        public int SlNo { get; set; }
        public int Amount { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Doctor { get; set; }
    }
}
