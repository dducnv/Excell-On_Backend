namespace Excell_On_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfulltable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        PriceTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.String(),
                        EndDate = c.String(),
                        CreatedAt = c.String(),
                        UpdateAt = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountID = c.String(maxLength: 128),
                        StartDate = c.String(),
                        EndDate = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.String(),
                        UpdateAt = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AccountID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.OrderDetails_Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountID = c.String(maxLength: 128),
                        OrderDetailsID = c.Int(nullable: false),
                        CreatedAt = c.String(),
                        UpdateAt = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AccountID)
                .ForeignKey("dbo.OrderDetails", t => t.OrderDetailsID, cascadeDelete: true)
                .Index(t => t.AccountID)
                .Index(t => t.OrderDetailsID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        ServiceID = c.Int(nullable: false),
                        SpecificationID = c.Int(nullable: false),
                        Qty = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedAt = c.String(),
                        UpdateAt = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceID, cascadeDelete: true)
                .ForeignKey("dbo.Specifications", t => t.SpecificationID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ServiceID)
                .Index(t => t.SpecificationID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.String(),
                        Description = c.String(),
                        CreatedAt = c.String(),
                        UpdateAt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Specifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        CreatedAt = c.String(),
                        UpdateAt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Specification_Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SpecificationID = c.Int(nullable: false),
                        AccountID = c.String(maxLength: 128),
                        CreatedAt = c.String(),
                        UpdateAt = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AccountID)
                .ForeignKey("dbo.Specifications", t => t.SpecificationID, cascadeDelete: true)
                .Index(t => t.SpecificationID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.TransactionHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractID = c.Int(nullable: false),
                        CreatedAt = c.String(),
                        UpdateAt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "Avatar", c => c.String());
            AddColumn("dbo.AspNetUsers", "Gender", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "CitizenID", c => c.String());
            AddColumn("dbo.AspNetUsers", "Birthday", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contracts", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "AccountID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Specification_Employee", "SpecificationID", "dbo.Specifications");
            DropForeignKey("dbo.Specification_Employee", "AccountID", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderDetails", "SpecificationID", "dbo.Specifications");
            DropForeignKey("dbo.OrderDetails", "ServiceID", "dbo.Services");
            DropForeignKey("dbo.OrderDetails_Employee", "OrderDetailsID", "dbo.OrderDetails");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails_Employee", "AccountID", "dbo.AspNetUsers");
            DropIndex("dbo.Specification_Employee", new[] { "AccountID" });
            DropIndex("dbo.Specification_Employee", new[] { "SpecificationID" });
            DropIndex("dbo.OrderDetails", new[] { "SpecificationID" });
            DropIndex("dbo.OrderDetails", new[] { "ServiceID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.OrderDetails_Employee", new[] { "OrderDetailsID" });
            DropIndex("dbo.OrderDetails_Employee", new[] { "AccountID" });
            DropIndex("dbo.Orders", new[] { "AccountID" });
            DropIndex("dbo.Contracts", new[] { "OrderID" });
            DropColumn("dbo.AspNetUsers", "Birthday");
            DropColumn("dbo.AspNetUsers", "CitizenID");
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "Avatar");
            DropTable("dbo.TransactionHistories");
            DropTable("dbo.Specification_Employee");
            DropTable("dbo.Specifications");
            DropTable("dbo.Services");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.OrderDetails_Employee");
            DropTable("dbo.Orders");
            DropTable("dbo.Contracts");
        }
    }
}
