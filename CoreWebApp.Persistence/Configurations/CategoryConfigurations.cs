using CoreWebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Persistence.Configurations {
    public class CategoryConfigurations : IEntityTypeConfiguration<Category> {
        public void Configure(EntityTypeBuilder<Category> builder) {
            builder.Property(p => p.Id).HasColumnName("CategoryID");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}
