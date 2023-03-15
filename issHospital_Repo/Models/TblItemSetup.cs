using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace issHospital_Repo.Models
{
    public class TblItemSetup
    {
        public int deletedBy;
        public DateTime deletedOn;
        public int updatedBy;
        public DateTime updatedOn;

        public int Id { get; set; }
        public int Reorder { get; set; }
        public int Tax { get; set; }
        public int price { get; set; }
        public string Menu { get; set; }
        public string Commcode { get; set; }
        public bool isDeleted { get; set; }


    }
}