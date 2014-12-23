using System.Data.Entity.ModelConfiguration;

namespace EFEntityTypeConfigurationBlogPost.Configuration
{
    public abstract class BaseEntityTypeConfiguration<T>:EntityTypeConfiguration<T> where T : class
    {
    }
}
