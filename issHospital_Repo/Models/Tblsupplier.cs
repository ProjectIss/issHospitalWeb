using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace issHospital_Repo.Models
{
    public class Tblsupplier
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public int OB { get; set; }
        public string Ccode { get; set; }
        public string CName { get; set; }
        public string Cphone { get; set; }
        public string Cother { get; set; }
        public string TngstNo { get; set; }
        public string CST { get; set; }
        public string DlNO { get; set; }
        public string CPadd { get; set; }
        public bool isDeleted { get; set; } = false;
        public int deletedBy { get; set; }
        public DateTime deletedOn { get; set; }
        public int updatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }




    }
}
