namespace Excell_On_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
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
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Avatar = c.String(),
                        FullName = c.String(),
                        Gender = c.Int(nullable: false),
                        CitizenID = c.String(),
                        Birthday = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
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
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.TransactionHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractID = c.Int(nullable: false),
                        CreatedAt = c.String(),
                        UpdateAt = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contracts", t => t.ContractID, cascadeDelete: true)
                .Index(t => t.ContractID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.TransactionHistories", "ContractID", "dbo.Contracts");
            DropForeignKey("dbo.Contracts", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "AccountID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Specification_Employee", "SpecificationID", "dbo.Specifications");
            DropForeignKey("dbo.Specification_Employee", "AccountID", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderDetails", "SpecificationID", "dbo.Specifications");
            DropForeignKey("dbo.OrderDetails", "ServiceID", "dbo.Services");
            DropForeignKey("dbo.OrderDetails_Employee", "OrderDetailsID", "dbo.OrderDetails");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails_Employee", "AccountID", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.TransactionHistories", new[] { "ContractID" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.Specification_Employee", new[] { "AccountID" });
            DropIndex("dbo.Specification_Employee", new[] { "SpecificationID" });
            DropIndex("dbo.OrderDetails", new[] { "SpecificationID" });
            DropIndex("dbo.OrderDetails", new[] { "ServiceID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.OrderDetails_Employee", new[] { "OrderDetailsID" });
            DropIndex("dbo.OrderDetails_Employee", new[] { "AccountID" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Orders", new[] { "AccountID" });
            DropIndex("dbo.Contracts", new[] { "OrderID" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.TransactionHistories");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.Specification_Employee");
            DropTable("dbo.Specifications");
            DropTable("dbo.Services");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.OrderDetails_Employee");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Orders");
            DropTable("dbo.Contracts");
        }
    }
}
