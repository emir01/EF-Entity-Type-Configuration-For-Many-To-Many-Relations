using System.Data.Entity;
using System.Reflection;
using EFEntityTypeConfigurationBlogPost.Configuration;
using EFEntityTypeConfigurationBlogPost.Entities;

namespace EFEntityTypeConfigurationBlogPost.Context
{
    public class AppContext : DbContext
    {
        #region Ctor

        public AppContext()
            : base("EntityTypeConfigConnection")
        {

        }

        #endregion

        #region Sets

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Product { get; set; }

        #endregion
        
        #region Overides

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // add all the found entity type configurations that are in the same
            // assembly as the base abstract generic config.
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(typeof(BaseEntityTypeConfiguration<>)));
        }

        #endregion
    }
}
