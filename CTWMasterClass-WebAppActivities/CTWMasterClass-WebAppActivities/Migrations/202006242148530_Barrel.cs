namespace CTWMasterClass_WebAppActivities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Barrel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Barrels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Radius = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        ConstructionMaterial = c.String(),
                        Contents = c.String(),
                        CurrentLocation = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Barrels");
        }
    }
}
