namespace DemoAspNetMvc01.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIntFkPostGuid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "category_Id", "dbo.Categories");
            DropForeignKey("dbo.Posts", "user_Id", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "category_Id" });
            DropIndex("dbo.Posts", new[] { "user_Id" });
            DropColumn("dbo.Posts", "CategoryId");
            DropColumn("dbo.Posts", "UserId");
            RenameColumn(table: "dbo.Posts", name: "category_Id", newName: "CategoryId");
            RenameColumn(table: "dbo.Posts", name: "user_Id", newName: "UserId");
            AlterColumn("dbo.Posts", "CategoryId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Posts", "UserId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Posts", "CategoryId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Posts", "UserId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Posts", "CategoryId");
            CreateIndex("dbo.Posts", "UserId");
            AddForeignKey("dbo.Posts", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Posts", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "UserId", "dbo.Users");
            DropForeignKey("dbo.Posts", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "UserId" });
            DropIndex("dbo.Posts", new[] { "CategoryId" });
            AlterColumn("dbo.Posts", "UserId", c => c.Guid());
            AlterColumn("dbo.Posts", "CategoryId", c => c.Guid());
            AlterColumn("dbo.Posts", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "CategoryId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Posts", name: "UserId", newName: "user_Id");
            RenameColumn(table: "dbo.Posts", name: "CategoryId", newName: "category_Id");
            AddColumn("dbo.Posts", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Posts", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "user_Id");
            CreateIndex("dbo.Posts", "category_Id");
            AddForeignKey("dbo.Posts", "user_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Posts", "category_Id", "dbo.Categories", "Id");
        }
    }
}
