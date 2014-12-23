namespace EFEntityTypeConfigurationBlogPost.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtendUserEntityConfigurationWithMap : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserProducts", newName: "UserFavouriteProducts");
            RenameColumn(table: "dbo.UserFavouriteProducts", name: "User_Id", newName: "UserId");
            RenameColumn(table: "dbo.UserFavouriteProducts", name: "Product_Id", newName: "ProductId");
            RenameIndex(table: "dbo.UserFavouriteProducts", name: "IX_User_Id", newName: "IX_UserId");
            RenameIndex(table: "dbo.UserFavouriteProducts", name: "IX_Product_Id", newName: "IX_ProductId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserFavouriteProducts", name: "IX_ProductId", newName: "IX_Product_Id");
            RenameIndex(table: "dbo.UserFavouriteProducts", name: "IX_UserId", newName: "IX_User_Id");
            RenameColumn(table: "dbo.UserFavouriteProducts", name: "ProductId", newName: "Product_Id");
            RenameColumn(table: "dbo.UserFavouriteProducts", name: "UserId", newName: "User_Id");
            RenameTable(name: "dbo.UserFavouriteProducts", newName: "UserProducts");
        }
    }
}
