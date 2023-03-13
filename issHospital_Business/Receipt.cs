using issHospital_Repo;
using issHospital_Repo.Models;

using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Business
{
    public class Receipt
    {
        private ReceiptRepo objRepo = new ReceiptRepo();

        public List<ReceiptDTO> getReceiptDetails()
        {
            List<ReceiptDTO> lstReceipt = objRepo.getReceiptDetails();

            return lstReceipt;
        }

        public int saveReceipt(TblReceipts Receipt)
        {
            int Respance = objRepo.SaveReceipt(Receipt);
            return Respance;
        }

    }

}