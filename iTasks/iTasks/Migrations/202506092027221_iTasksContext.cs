namespace iTasks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iTasksContext : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "ActualStartDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "ActualStartDate", c => c.DateTime(nullable: false));
        }
    }
}
