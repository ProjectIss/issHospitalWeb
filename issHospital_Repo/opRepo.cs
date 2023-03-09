
using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo
{
    public class opRepo
    {
        private issDB db = new issDB();

        public List<opDTO> getOPDetails()
        {
            try
            {// changed by Rabekka tblOpentry 
                List<opDTO> lstOP = db.tblOpentry.Where(x => x.isDeleted == false).Select(x => new opDTO()
                {
                    Id = x.Id,
                    Age = x.Age,
                    Amount = x.Amount,
                    BalAmt = x.BalAmt,
                    OpNo = x.OpNo,
                    PaidAmt = x.PaidAmt
                }).ToList();

                return lstOP;

            }
            catch (Exception)
            {

                return new List<opDTO>();


            }


        }
    }
}
