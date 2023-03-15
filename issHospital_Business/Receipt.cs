﻿using issHospital_Repo;

using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issHospital_Repo.Models;

namespace issHospital_Business
{
    public class Receipt
    {
        private ReceiptRepo objRepo = new issHospital_Repo.ReceiptRepo();

        public List<ReceiptDTO> getReceiptDetails()
        {
            List<ReceiptDTO> lstReceipt = objRepo.getReceiptDetails();

            return lstReceipt;
        }

        public int SaveReceipt(TblReceipt Receipt)
        {
            int Respanse = objRepo.SaveReceipt(Receipt);
            return Respanse;
        }

        public int saveReceipt(TblReceipt receipt)
        {
            throw new NotImplementedException();
        }
    }

}