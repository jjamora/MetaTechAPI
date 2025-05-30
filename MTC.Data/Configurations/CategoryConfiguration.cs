using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MTC.Core.Models;

namespace MTC.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(s => s.Name).HasMaxLength(150);

            var list = new List<Category>();

            list.Add(new Category
            {
                Id = (new Guid("CE275698-9C28-422E-8C07-8B913E8BB283")).ToString(),
                Name = "Supreme"
            });
            list.Add(new Category
            {
                Id = (new Guid("55596DAA-2DE7-47D0-9372-4860FF3C17A2")).ToString(),
                Name = "Veggie"
            });
            list.Add(new Category
            {
                Id = (new Guid("442C8D99-3B07-4AAF-9B07-A562CA32F0EB")).ToString(),
                Name = "Chicken"
            });
            list.Add(new Category
            {
                Id = (new Guid("101F4FB4-2C6F-4734-9FA1-C1D4BF185DEB")).ToString(),
                Name = "Classic"
            });
            builder.HasData(list);
        }
    }
}
