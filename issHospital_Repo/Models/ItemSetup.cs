using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace issHospital_Repo.Models
{
    public class ItemSetup
    {
        public int Id { get; set; }
        public int Reorder { get; set; }
        public int Tax { get; set; }
        public int Sprice { get; set; }
        public string Menu { get; set; }
        public string Commcode { get; set; }
        public string Schedule { get; set; }
        //public string Category { get; set; }
        public int categoryId { get; set; }
        public virtual TblCategory category { get; set; }
        public string Generic { get; set; }
        public bool isDeleted { get; set; } = false;
        public int deletedBy { get; set; }
        public DateTime deletedOn { get; set; }
        public int updatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }



    }
}
