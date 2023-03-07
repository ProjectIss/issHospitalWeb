using issHospital_Repo;

using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Business
{
   public class AlterItem
   {
        private AlterItemRepo objRepo = new AlterItemRepo();

        public List<AlterItemDTO> getAlterItemDetails()
        {
            List<AlterItemDTO> lstAlterItem = objRepo.getAlterItemDetails();

            return lstAlterItem;
        }

    }
}
