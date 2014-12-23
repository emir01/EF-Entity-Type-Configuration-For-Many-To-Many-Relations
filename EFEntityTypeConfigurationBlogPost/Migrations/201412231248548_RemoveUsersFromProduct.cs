namespace EFEntityTypeConfigurationBlogPost.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUsersFromProduct : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserProducts", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserProducts", "Product_Id", "dbo.Products");
            DropIndex("dbo.UserProducts", new[] { "User_Id" });
            DropIndex("dbo.UserProducts", new[] { "Product_Id" });
            AddColumn("dbo.Products", "User_Id", c => c.Int());
            CreateIndex("dbo.Products", "User_Id");
            AddForeignKey("dbo.Products", "User_Id", "dbo.Users", "Id");
            DropTable("dbo.UserProducts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserProducts",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Product_Id });
            
            DropForeignKey("dbo.Products", "User_Id", "dbo.Users");
            DropIndex("dbo.Products", new[] { "User_Id" });
            DropColumn("dbo.Products", "User_Id");
            CreateIndex("dbo.UserProducts", "Product_Id");
            CreateIndex("dbo.UserProducts", "User_Id");
            AddForeignKey("dbo.UserProducts", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserProducts", "User_Id", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
