namespace issHospital_Repo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m6 : DbMigration
    {
        public override void Up()
        {
           // RenameTable(name: "dbo.CustomerSetups", newName: "TblCustomerSetups");
            AddColumn("dbo.TblPrescriptions", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblPrescriptions", "deletedBy", c => c.Int(nullable: false));
            AddColumn("dbo.TblPrescriptions", "deletedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.TblPrescriptions", "updatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.TblPrescriptions", "UpdatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblPrescriptions", "UpdatedOn");
            DropColumn("dbo.TblPrescriptions", "updatedBy");
            DropColumn("dbo.TblPrescriptions", "deletedOn");
            DropColumn("dbo.TblPrescriptions", "deletedBy");
            DropColumn("dbo.TblPrescriptions", "isDeleted");
           // RenameTable(name: "dbo.TblCustomerSetups", newName: "CustomerSetups");
        }
    }
}
