namespace BaseDato1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.News", "Usuario_Id", "dbo.Users");
            AddColumn("dbo.News", "User_Id", c => c.Int());
            AddColumn("dbo.News", "CreatedUser_Id", c => c.Int(nullable: false));
            AddColumn("dbo.News", "UpdatedUser_Id", c => c.Int());
            CreateIndex("dbo.News", "User_Id");
            CreateIndex("dbo.News", "CreatedUser_Id");
            CreateIndex("dbo.News", "UpdatedUser_Id");
            AddForeignKey("dbo.News", "CreatedUser_Id", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.News", "UpdatedUser_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.News", "User_Id", "dbo.Users", "Id");
            DropColumn("dbo.News", "CreatedUser");
            DropColumn("dbo.News", "UpdatedUser");
        }
        
        public override void Down()
        {
            AddColumn("dbo.News", "UpdatedUser", c => c.String());
            AddColumn("dbo.News", "CreatedUser", c => c.String(nullable: false));
            DropForeignKey("dbo.News", "User_Id", "dbo.Users");
            DropForeignKey("dbo.News", "UpdatedUser_Id", "dbo.Users");
            DropForeignKey("dbo.News", "CreatedUser_Id", "dbo.Users");
            DropIndex("dbo.News", new[] { "UpdatedUser_Id" });
            DropIndex("dbo.News", new[] { "CreatedUser_Id" });
            DropIndex("dbo.News", new[] { "User_Id" });
            DropColumn("dbo.News", "UpdatedUser_Id");
            DropColumn("dbo.News", "CreatedUser_Id");
            DropColumn("dbo.News", "User_Id");
            AddForeignKey("dbo.News", "Usuario_Id", "dbo.Users", "Id");
        }
    }
}
