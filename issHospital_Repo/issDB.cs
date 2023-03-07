using issHospital_Repo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Repo
{
    public class issDB: DbContext
    {
       

        public issDB()
            : base("name=ISSModel")
        {
        }
        public DbSet<TblMenuSetup> MenuSetups { get; set; }
               
        public DbSet <TblCustomerSetup> CustomerSetups { get; set; }

        public DbSet<ItemSetup> itemSetups { get; set; }
        
        public DbSet<TblCategory> tblcategories { get; set; }

        public DbSet<TblAlterItem> tblAlterItems { get; set; }

        public DbSet<TblDept> tblDepts { get; set; }

        public DbSet<TblOpentry> tblOpentry { get; set; }

        public DbSet<TblReceipt> tblReceipts { get; set; }

        public DbSet<TblPatreg> tblPatReg { get; set; }

        public DbSet<Tblsupplier> tblsupplier { get; set; }

        public DbSet<TblPrescription> tblPrescriptions { get; set; }

        public DbSet<Tbldoctors> tblDoctor { get; set; }
       
    }
}
