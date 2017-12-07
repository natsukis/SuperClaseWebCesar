namespace BaseDato1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "News_Id", "dbo.News");
            DropIndex("dbo.Users", new[] { "News_Id" });
            AddColumn("dbo.News", "Usuario_Id", c => c.Int());
            CreateIndex("dbo.News", "Usuario_Id");
            AddForeignKey("dbo.News", "Usuario_Id", "dbo.Users", "Id");
            DropColumn("dbo.Users", "News_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "News_Id", c => c.Int());
            DropForeignKey("dbo.News", "Usuario_Id", "dbo.Users");
            DropIndex("dbo.News", new[] { "Usuario_Id" });
            DropColumn("dbo.News", "Usuario_Id");
            CreateIndex("dbo.Users", "News_Id");
            AddForeignKey("dbo.Users", "News_Id", "dbo.News", "Id");
        }
    }
}
