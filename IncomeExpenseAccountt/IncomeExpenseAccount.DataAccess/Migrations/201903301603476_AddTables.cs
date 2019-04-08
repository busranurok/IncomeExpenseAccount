namespace IncomeExpenseAccount.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Revenues",
                c => new
                    {
                        RevenueId = c.Int(nullable: false, identity: true),
                        RevenueName = c.String(),
                        CategoryId = c.Int(nullable: false),
                        RevenueDescription = c.String(),
                        RevenueAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RevenueId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CategoryDescription = c.String(),
                        CategoryTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.CategoryTypes", t => t.CategoryTypeId, cascadeDelete: true)
                .Index(t => t.CategoryTypeId);
            
            CreateTable(
                "dbo.CategoryTypes",
                c => new
                    {
                        CategoryTypeId = c.Int(nullable: false, identity: true),
                        CategoryTypeName = c.String(),
                        CategoryTypeDescription = c.String(),
                    })
                .PrimaryKey(t => t.CategoryTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Revenues", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "CategoryTypeId", "dbo.CategoryTypes");
            DropIndex("dbo.Categories", new[] { "CategoryTypeId" });
            DropIndex("dbo.Revenues", new[] { "CategoryId" });
            DropTable("dbo.CategoryTypes");
            DropTable("dbo.Categories");
            DropTable("dbo.Revenues");
        }
    }
}
