namespace Excell_On_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Specifications", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Specifications", "Name", c => c.Int(nullable: false));
        }
    }
}
