using System.Collections.Generic;

namespace EFEntityTypeConfigurationBlogPost.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}