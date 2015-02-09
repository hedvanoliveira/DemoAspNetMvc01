namespace DemoAspNetMvc01.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addConfigMap1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Title", c => c.String(nullable: false, maxLength: 250, unicode: false));
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false, maxLength: 250, unicode: false));
            AlterColumn("dbo.Posts", "Description", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Posts", "Description", c => c.String());
            AlterColumn("dbo.Posts", "Title", c => c.String());
            AlterColumn("dbo.Categories", "Title", c => c.String());
        }
    }
}
