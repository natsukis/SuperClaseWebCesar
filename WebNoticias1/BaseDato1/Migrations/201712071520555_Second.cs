namespace BaseDato1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 200),
                        Description = c.String(nullable: false, maxLength: 2000),
                        CreatedUser = c.String(nullable: false),
                        UpdatedUser = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        News_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.News", t => t.News_Id)
                .Index(t => t.News_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "News_Id", "dbo.News");
            DropIndex("dbo.Users", new[] { "News_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.News");
        }
    }
}
