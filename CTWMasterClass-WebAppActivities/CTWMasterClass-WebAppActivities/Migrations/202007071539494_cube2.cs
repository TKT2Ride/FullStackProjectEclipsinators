namespace CTWMasterClass_WebAppActivities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cube2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cubes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Side = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                        ConstructionMaterial = c.String(),
                        Contents = c.String(),
                        CurrentLocation = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cubes");
        }
    }
}
