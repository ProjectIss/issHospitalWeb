namespace issHospital_Repo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tbldoctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        doctorId = c.Int(nullable: false),
                        ENo = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Name = c.String(),
                        FName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Phone = c.String(),
                        Phone1 = c.String(),
                        Email = c.String(),
                        Dept = c.String(),
                        Marital = c.String(),
                        HighSchl = c.String(),
                        HighSchlLoc = c.String(),
                        HighSec = c.String(),
                        HighSecLoc = c.String(),
                        Ug = c.String(),
                        UgLoc = c.String(),
                        PG = c.String(),
                        PGLoc = c.String(),
                        Specialist = c.String(),
                        SpecLoc = c.String(),
                        Degree = c.String(),
                        DegreeLoc = c.String(),
                        HName1 = c.String(),
                        H1Loc = c.String(),
                        Year1 = c.String(),
                        Skill1 = c.String(),
                        HName2 = c.String(),
                        H2Loc = c.String(),
                        Year2 = c.String(),
                        Skill2 = c.String(),
                        HName3 = c.String(),
                        H3Loc = c.String(),
                        Year3 = c.String(),
                        Skill3 = c.String(),
                        DOB = c.DateTime(nullable: false),
                        userName = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        deletedBy = c.Int(nullable: false),
                        deletedOn = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TblPrescriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ENo = c.Int(nullable: false),
                        billno = c.Int(nullable: false),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblPrescriptions");
            DropTable("dbo.Tbldoctors");
        }
    }
}
