using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace issHospital_Repo.Models
{
    public class TblPrescription
    {
        public int Id { get; set; }
        public int ENo { get; set; }
        public int billno { get; set; }
        public int age { get; set; }
        public bool isDeleted { get; set; } = false;
        public int deletedBy { get; set; }
        public DateTime deletedOn { get; set; }
        public int updatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }



    }
}
