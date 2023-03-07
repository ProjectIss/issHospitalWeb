using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo
{
    public class ReceiptRepo
    {
        private issDB db = new issDB();
        public List<ReceiptDTO> getReceiptDetails()
        {
            try
            {
                List<ReceiptDTO> lstReceipt = db.tblReceipts.Where(x => x.isDeleted == false).Select(x => new ReceiptDTO
                {
                    Id = x.Id,
                    SlNo = x.SlNo,
                    Amount = x.Amount,
                    Age = x.Age,
                    Name = x.Name,
                    Doctor = x.Doctor

                }).ToList();

                return lstReceipt;

            }

            catch (Exception)
            {

                return new List<ReceiptDTO>();
            }

        }
    }
}
