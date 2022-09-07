namespace valorantProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_streamersNewColumn_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Streamers", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Streamers", "Image");
        }
    }
}
