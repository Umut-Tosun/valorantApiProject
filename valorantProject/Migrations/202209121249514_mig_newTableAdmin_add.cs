namespace valorantProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_newTableAdmin_add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
