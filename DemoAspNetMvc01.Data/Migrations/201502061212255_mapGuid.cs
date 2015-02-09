namespace DemoAspNetMvc01.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mapGuid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "category_Id", "dbo.Categories");
            DropForeignKey("dbo.Posts", "user_Id", "dbo.Users");
            DropPrimaryKey("dbo.Categories");
            DropPrimaryKey("dbo.Posts");
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Categories", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Posts", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Users", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Categories", "Id");
            AddPrimaryKey("dbo.Posts", "Id");
            AddPrimaryKey("dbo.Users", "Id");
            AddForeignKey("dbo.Posts", "category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Posts", "user_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "user_Id", "dbo.Users");
            DropForeignKey("dbo.Posts", "category_Id", "dbo.Categories");
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Posts");
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Users", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Posts", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Categories", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Users", "Id");
            AddPrimaryKey("dbo.Posts", "Id");
            AddPrimaryKey("dbo.Categories", "Id");
            AddForeignKey("dbo.Posts", "user_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Posts", "category_Id", "dbo.Categories", "Id");
        }
    }
}
