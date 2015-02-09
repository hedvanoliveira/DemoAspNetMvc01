namespace DemoAspNetMvc01.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addConfigMap2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Posts", "UserId", "dbo.Users");
            AddForeignKey("dbo.Posts", "CategoryId", "dbo.Categories", "Id");
            AddForeignKey("dbo.Posts", "UserId", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "UserId", "dbo.Users");
            DropForeignKey("dbo.Posts", "CategoryId", "dbo.Categories");
            AddForeignKey("dbo.Posts", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Posts", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
