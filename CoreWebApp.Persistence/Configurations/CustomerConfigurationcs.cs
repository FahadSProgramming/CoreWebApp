using CoreWebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Persistence.Configurations {
    public class CustomerConfigurationcs : IEntityTypeConfiguration<Customer> {
        public void Configure(EntityTypeBuilder<Customer> builder) {
            builder.Property(p => p.Id).HasColumnName("CustomerID");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(250);
            builder.Property(p => p.Website).HasMaxLength(200);
        }
    }
}
