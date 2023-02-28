using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace issHospital_Repo.Models
{
    public class TblOpentry
    {
        public int Id { get; set; }
        public int OpNo { get; set; }
        public int Age { get; set; }
        public int UHID { get; set; }
        public int Hei { get; set; }
        public int Wei { get; set; }
        public int BMI { get; set; }
        public int wd { get; set; }
        public int hd { get; set; }
        public int wdr { get; set; }
        public int ar { get; set; }
        public int ae { get; set; }
        public int sitsys { get; set; }
        public int sitdia { get; set; }
        public int supsys{ get; set; }
        public int supdia { get; set; }
        public int fah { get; set; }
        public int cel { get; set; }
        public int Amount { get; set; }
        public int BalAmt{ get; set; }
        public int PaidAmt { get; set; }
        public bool isDeleted { get; set; } = false;
        public int deletedBy { get; set; }
        public DateTime deletedOn { get; set; }
        public int updatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
