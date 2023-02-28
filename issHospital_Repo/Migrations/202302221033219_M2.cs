namespace issHospital_Repo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerSetups",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        OB = c.Int(nullable: false),
                        Ccode = c.String(),
                        CName = c.String(),
                        Cphone = c.String(),
                        Cother = c.String(),
                        FName = c.String(),
                        Discount = c.String(),
                        CPadd = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        deletedBy = c.Int(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ItemSetups",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Reorder = c.Int(nullable: false),
                        Tax = c.Int(nullable: false),
                        Sprice = c.Int(nullable: false),
                        Menu = c.String(),
                        Commcode = c.String(),
                        Schedule = c.String(),
                        categoryId = c.Int(nullable: false),
                        Generic = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        deletedBy = c.Int(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TblCategories", t => t.categoryId, cascadeDelete: true)
                .Index(t => t.categoryId);
            
            CreateTable(
                "dbo.TblCategories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ENo = c.Int(nullable: false),
                        Category = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        deletedBy = c.Int(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TblAlterItems",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        AlterItem = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        deletedBy = c.Int(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.ManuSertups", "isDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ManuSertups", "deletedBy", c => c.Int(nullable: false));
            AddColumn("dbo.ManuSertups", "deletedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.ManuSertups", "updatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.ManuSertups", "UpdatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemSetups", "categoryId", "dbo.TblCategories");
            DropIndex("dbo.ItemSetups", new[] { "categoryId" });
            DropColumn("dbo.ManuSertups", "UpdatedOn");
            DropColumn("dbo.ManuSertups", "updatedBy");
            DropColumn("dbo.ManuSertups", "deletedOn");
            DropColumn("dbo.ManuSertups", "deletedBy");
            DropColumn("dbo.ManuSertups", "isDeleted");
            DropTable("dbo.TblAlterItems");
            DropTable("dbo.TblCategories");
            DropTable("dbo.ItemSetups");
            DropTable("dbo.CustomerSetups");
        }
    }
}
