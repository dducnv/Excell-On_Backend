namespace Excell_On_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfktransHs : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.TransactionHistories", "ContractID");
            AddForeignKey("dbo.TransactionHistories", "ContractID", "dbo.Contracts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionHistories", "ContractID", "dbo.Contracts");
            DropIndex("dbo.TransactionHistories", new[] { "ContractID" });
        }
    }
}
