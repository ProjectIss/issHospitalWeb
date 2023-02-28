using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace issHospital_Repo.Models
{
    public class TblPatreg
    {
        public int Id { get; set; }
        public int UHID { get; set; }
        public int Age { get; set; }

        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Add { get; set; }
        public string Phone { get; set; }
        public string sex { get; set; }
       
        public string type { get; set; }
        public string Nation { get; set; }
        public string PassPort { get; set; }
        public string visa { get; set; }
        public string pathName { get; set; }
        public DateTime DOB { get; set; }
        public bool isDeleted { get; set; } = false;
        public int deletedBy { get; set; }
        public DateTime deletedOn { get; set; }
        public int updatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
