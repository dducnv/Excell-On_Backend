namespace Excell_On_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "Image");
        }
    }
}
