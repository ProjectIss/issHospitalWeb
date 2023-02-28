namespace issHospital_Repo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M4 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TblReceptions", newName: "TblOpentries");
            RenameTable(name: "dbo.TblRegs", newName: "TblPatregs");
            CreateTable(
                "dbo.TblMenuSetups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Name = c.String(),
                        EmailID = c.String(),
                        PhoneNo = c.String(),
                        address = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        deletedBy = c.Int(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TblDepts", "Department", c => c.Int(nullable: false));
            AddColumn("dbo.TblDepts", "Description", c => c.String());
            AddColumn("dbo.TblReceipts", "UHID", c => c.String());
            AddColumn("dbo.TblOpentries", "UHID", c => c.Int(nullable: false));
            AddColumn("dbo.TblPatregs", "UHID", c => c.Int(nullable: false));
            DropColumn("dbo.TblDepts", "Qty");
            DropColumn("dbo.TblDepts", "ItemName");
            DropColumn("dbo.TblDepts", "Barcode");
            DropColumn("dbo.TblReceipts", "RegNo");
            DropColumn("dbo.TblOpentries", "RegNo");
            DropColumn("dbo.TblPatregs", "RegNo");
            DropColumn("dbo.TblPatregs", "RegN");
            DropColumn("dbo.TblPatregs", "Doctor");
            DropTable("dbo.MenuSetups");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MenuSetups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Ccode = c.String(),
                        CName = c.String(),
                        CPadd = c.String(),
                        Fname = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        deletedBy = c.Int(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TblPatregs", "Doctor", c => c.String());
            AddColumn("dbo.TblPatregs", "RegN", c => c.Int(nullable: false));
            AddColumn("dbo.TblPatregs", "RegNo", c => c.Int(nullable: false));
            AddColumn("dbo.TblOpentries", "RegNo", c => c.Int(nullable: false));
            AddColumn("dbo.TblReceipts", "RegNo", c => c.String());
            AddColumn("dbo.TblDepts", "Barcode", c => c.String());
            AddColumn("dbo.TblDepts", "ItemName", c => c.String());
            AddColumn("dbo.TblDepts", "Qty", c => c.Int(nullable: false));
            DropColumn("dbo.TblPatregs", "UHID");
            DropColumn("dbo.TblOpentries", "UHID");
            DropColumn("dbo.TblReceipts", "UHID");
            DropColumn("dbo.TblDepts", "Description");
            DropColumn("dbo.TblDepts", "Department");
            DropTable("dbo.TblMenuSetups");
            RenameTable(name: "dbo.TblPatregs", newName: "TblRegs");
            RenameTable(name: "dbo.TblOpentries", newName: "TblReceptions");
        }
    }
}
