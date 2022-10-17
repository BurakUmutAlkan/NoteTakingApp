namespace NoteTakingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiedTimeAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notes", "ModifiedTime", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notes", "ModifiedTime");
        }
    }
}
