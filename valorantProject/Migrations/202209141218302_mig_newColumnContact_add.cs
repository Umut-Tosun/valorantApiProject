namespace valorantProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_newColumnContact_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "isRead", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "isRead");
        }
    }
}
