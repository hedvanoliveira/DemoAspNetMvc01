namespace DemoAspNetMvc01.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIntFkPost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Posts", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "UserId");
            DropColumn("dbo.Posts", "CategoryId");
        }
    }
}
