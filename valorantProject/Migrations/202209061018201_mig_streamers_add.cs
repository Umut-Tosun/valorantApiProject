namespace valorantProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_streamers_add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Streamers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        YoutubeUrl = c.String(),
                        TwitchUrl = c.String(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Streamers");
        }
    }
}
