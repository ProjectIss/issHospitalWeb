using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace issHospital_Repo.Models
{
    public class TblReceipts
    {
        public int Id { get; set; }
        public int SlNo { get; set; }
        public int Amount { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Doctor { get; set; }
        public string Purpose { get; set; }
        public string dept { get; set; }
        public string sex { get; set; }
        public string Type{ get; set; }
        public string UHID { get; set; }
        public string BP { get; set; }
        public string weight { get; set; }
        public string Temp { get; set; }
        public string FName { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public DateTime Billtime { get; set; }
        public bool isDeleted { get; set; } = false;
        public int deletedBy { get; set; }
        public DateTime deletedOn { get; set; }
        public int updatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        //public static int SaveReceipt(object tblReceipt)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
