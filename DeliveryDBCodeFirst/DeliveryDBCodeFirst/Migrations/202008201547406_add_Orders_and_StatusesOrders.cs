namespace DeliveryDBCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Orders_and_StatusesOrders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        AddressTo = c.String(nullable: false),
                        DescriptionOfCargo = c.String(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                        CourierID_CourierID = c.Int(nullable: false),
                        StatusID_OrderStatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Couriers", t => t.CourierID_CourierID, cascadeDelete: true)
                .ForeignKey("dbo.OrderStatuses", t => t.StatusID_OrderStatusID, cascadeDelete: true)
                .Index(t => t.CourierID_CourierID)
                .Index(t => t.StatusID_OrderStatusID);
            
            CreateTable(
                "dbo.OrderStatuses",
                c => new
                    {
                        OrderStatusID = c.Int(nullable: false, identity: true),
                        OrderStatusName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.OrderStatusID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "StatusID_OrderStatusID", "dbo.OrderStatuses");
            DropForeignKey("dbo.Orders", "CourierID_CourierID", "dbo.Couriers");
            DropIndex("dbo.Orders", new[] { "StatusID_OrderStatusID" });
            DropIndex("dbo.Orders", new[] { "CourierID_CourierID" });
            DropTable("dbo.OrderStatuses");
            DropTable("dbo.Orders");
        }
    }
}
