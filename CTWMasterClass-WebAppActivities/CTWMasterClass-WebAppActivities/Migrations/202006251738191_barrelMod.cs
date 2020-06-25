namespace CTWMasterClass_WebAppActivities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class barrelMod : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Barrels", "Weight", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Barrels", "Weight");
        }
    }
}
