using EFEntityTypeConfigurationBlogPost.Entities;

namespace EFEntityTypeConfigurationBlogPost.Configuration
{
    public class UserEntityTypeConfiguration:BaseEntityTypeConfiguration<User>
    {
        public UserEntityTypeConfiguration()
        {
            HasMany(user => user.Products)
                .WithMany()
                .Map(map =>
                {
                    map.ToTable("UserFavouriteProducts");
                    map.MapLeftKey("UserId");
                    map.MapRightKey("ProductId");
                });
        }
    }
}
