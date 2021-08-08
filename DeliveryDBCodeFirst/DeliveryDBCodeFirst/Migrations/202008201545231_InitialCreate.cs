namespace DeliveryDBCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Couriers",
                c => new
                    {
                        CourierID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        AvailabilityRights = c.Boolean(nullable: false),
                        RightsСategory = c.String(),
                    })
                .PrimaryKey(t => t.CourierID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Couriers");
        }
    }
}
