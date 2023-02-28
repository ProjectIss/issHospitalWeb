using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace issHospital_Repo.Models
{
    public class TblMenuSetup
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string PhoneNo { get; set; }
        public string address { get; set; }
        public bool isDeleted { get; set; } = false;
        public int deletedBy { get; set; }
        public DateTime deletedOn { get; set; } 
        public int updatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
