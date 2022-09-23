namespace valorantProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2_newColumnMaps_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Maps", "status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Maps", "status");
        }
    }
}
