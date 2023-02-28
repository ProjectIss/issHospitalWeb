namespace issHospital_Repo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ManuSertups", newName: "MenuSetups");
            CreateTable(
                "dbo.TblDepts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Qty = c.Int(nullable: false),
                        ItemName = c.String(),
                        Barcode = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        deletedBy = c.Int(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TblReceipts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SlNo = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Name = c.String(),
                        Doctor = c.String(),
                        Purpose = c.String(),
                        dept = c.String(),
                        sex = c.String(),
                        Type = c.String(),
                        RegNo = c.String(),
                        BP = c.String(),
                        weight = c.String(),
                        Temp = c.String(),
                        FName = c.String(),
                        UserName = c.String(),
                        Date = c.DateTime(nullable: false),
                        Billtime = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        deletedBy = c.Int(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TblReceptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OpNo = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        RegNo = c.Int(nullable: false),
                        Hei = c.Int(nullable: false),
                        Wei = c.Int(nullable: false),
                        BMI = c.Int(nullable: false),
                        wd = c.Int(nullable: false),
                        hd = c.Int(nullable: false),
                        wdr = c.Int(nullable: false),
                        ar = c.Int(nullable: false),
                        ae = c.Int(nullable: false),
                        sitsys = c.Int(nullable: false),
                        sitdia = c.Int(nullable: false),
                        supsys = c.Int(nullable: false),
                        supdia = c.Int(nullable: false),
                        fah = c.Int(nullable: false),
                        cel = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        BalAmt = c.Int(nullable: false),
                        PaidAmt = c.Int(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        deletedBy = c.Int(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TblRegs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegNo = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        RegN = c.Int(nullable: false),
                        Name = c.String(),
                        FatherName = c.String(),
                        Add = c.String(),
                        Phone = c.String(),
                        sex = c.String(),
                        Doctor = c.String(),
                        type = c.String(),
                        Nation = c.String(),
                        PassPort = c.String(),
                        visa = c.String(),
                        pathName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        deletedBy = c.Int(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tblsuppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        OB = c.Int(nullable: false),
                        Ccode = c.String(),
                        CName = c.String(),
                        Cphone = c.String(),
                        Cother = c.String(),
                        TngstNo = c.String(),
                        CST = c.String(),
                        DlNO = c.String(),
                        CPadd = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        deletedBy = c.Int(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tblsuppliers");
            DropTable("dbo.TblRegs");
            DropTable("dbo.TblReceptions");
            DropTable("dbo.TblReceipts");
            DropTable("dbo.TblDepts");
            RenameTable(name: "dbo.MenuSetups", newName: "ManuSertups");
        }
    }
}
