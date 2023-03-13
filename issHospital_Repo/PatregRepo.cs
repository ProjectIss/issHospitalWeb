using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo
{
    public class PatregRepo
    {
        private issDB db = new issDB();
        public List<PatregDTO> getPatregDetails()
        {
            try
            {
                List<PatregDTO> lstPatreg = db.tblPatReg.Where(x => x.isDeleted == false).Select(x => new PatregDTO
                {
                    Id = x.Id,
                    UHID = x.UHID,
                    Age = x.Age,
                    Name = x.Name,
                    FatherName = x.FatherName,
                    Add = x.Add

                }).ToList();

                return lstPatreg;

            }

            catch (Exception ex)
            {

                return new List<PatregDTO>();
            }

        }

        public int SavePatreg(Models.TblPatreg patreg)

        {
            int a = 1;
            db.tblPatReg.Add(patreg);
            db.SaveChanges();
            return a;

        }

    }
}
