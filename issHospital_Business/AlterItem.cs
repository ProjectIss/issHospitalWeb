using issHospital_Repo;

using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using issHospital_Repo.Models;

namespace issHospital_Business
{
   public class AlterItem
   {
        private AlterItemRepo objRepo = new issHospital_Repo.AlterItemRepo();

        public List<AlterItemDTO> getAlterItemDetails()
        {
            List<AlterItemDTO> lstAlterItem = objRepo.getAlterItemDetails();

            return lstAlterItem;
        }

        public int saveAlterItem(TblAlterItem Alter)
        {
            int respance = objRepo.SaveAlterItem(Alter);
            return (respance);
        }

    }
}
