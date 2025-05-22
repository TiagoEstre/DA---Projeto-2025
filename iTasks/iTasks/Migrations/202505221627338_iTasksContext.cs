namespace iTasks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iTasksContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExecutionOrder = c.Int(nullable: false),
                        Description = c.String(),
                        EstimatedStartDate = c.DateTime(nullable: false),
                        ExpectedEndDate = c.DateTime(nullable: false),
                        StoryPoints = c.String(),
                        ActualStartDate = c.DateTime(nullable: false),
                        ActualEndDate = c.DateTime(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        Currentstatus = c.String(),
                        IdManeger_Id = c.Int(),
                        IdProgrammer_Id = c.Int(),
                        idTaskType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.IdManeger_Id)
                .ForeignKey("dbo.Users", t => t.IdProgrammer_Id)
                .ForeignKey("dbo.TaskTypes", t => t.idTaskType_Id)
                .Index(t => t.IdManeger_Id)
                .Index(t => t.IdProgrammer_Id)
                .Index(t => t.idTaskType_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Department = c.String(),
                        GenerateUser = c.String(),
                        ExperienceLevel = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        idManeger_Id = c.Int(),
                        Maneger_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.idManeger_Id)
                .ForeignKey("dbo.Users", t => t.Maneger_Id)
                .Index(t => t.idManeger_Id)
                .Index(t => t.Maneger_Id);
            
            CreateTable(
                "dbo.TaskTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Maneger_Id", "dbo.Users");
            DropForeignKey("dbo.Tasks", "idTaskType_Id", "dbo.TaskTypes");
            DropForeignKey("dbo.Tasks", "IdProgrammer_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "idManeger_Id", "dbo.Users");
            DropForeignKey("dbo.Tasks", "IdManeger_Id", "dbo.Users");
            DropIndex("dbo.Users", new[] { "Maneger_Id" });
            DropIndex("dbo.Users", new[] { "idManeger_Id" });
            DropIndex("dbo.Tasks", new[] { "idTaskType_Id" });
            DropIndex("dbo.Tasks", new[] { "IdProgrammer_Id" });
            DropIndex("dbo.Tasks", new[] { "IdManeger_Id" });
            DropTable("dbo.TaskTypes");
            DropTable("dbo.Users");
            DropTable("dbo.Tasks");
        }
    }
}
