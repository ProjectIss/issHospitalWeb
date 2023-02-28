using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo.Models
{
    public class users
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool isActive { get; set; } = false;
        public string  Role { get; set; }
        public bool isDelete { get; set; } = false;
        public int deletedBy { get; set; }
        public DateTime? deletedOn { get; set; }
        public int updatedBy { get; set; }
        public DateTime? updatedOn { get; set; }
    }
}
