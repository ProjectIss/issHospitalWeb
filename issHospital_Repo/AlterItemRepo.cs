using issHospital_Utility.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace issHospital_Repo
{
    public class AlterItemRepo
    {
        private issDB db = new issDB();
        public List<AlterItemDTO> getAlterItemDetails()
        {
            try
            {
                List<AlterItemDTO> lstAlterItem = db.tblAlterItems.Where(x => x.isDeleted == false).Select(x => new AlterItemDTO
                {
                    Id = x.Id,
                    ItemName =x.ItemName,
                    isDeleted = x.isDeleted,
                    deletedBy = x.deletedBy,
                    deletedOn = x.deletedOn,
                    updatedBy = x.updatedBy

                }).ToList();

                return lstAlterItem;

            }

            catch (Exception Ex)
            {

                return new List<AlterItemDTO>();
            }

        }

        public int SaveAlterItem(Models.TblAlterItem Alter)
        {
            try
            {

                int a = 1;
                db.tblAlterItems.Add(Alter);
                db.SaveChanges();
                return a;


            }
            catch (Exception ex)
            {

                throw;
            }

        }


    }
}
