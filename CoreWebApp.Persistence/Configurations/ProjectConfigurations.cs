using CoreWebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Persistence.Configurations {
    public class ProjectConfigurations : IEntityTypeConfiguration<Project> {
        public void Configure(EntityTypeBuilder<Project> builder) {

            builder.Property(p => p.Id).HasColumnName("ProjectID");
            builder.Property(p => p.Code).IsRequired().HasMaxLength(20);
            builder.Property(p => p.Title).IsRequired().HasMaxLength(150);

            builder.HasOne(p => p.Customer)
                .WithMany(p => p.Projects)
                .HasForeignKey(p => p.CustomerId)
                .IsRequired()
                .HasConstraintName("FK_Customer_Project");

            builder.HasOne(p => p.Contact)
                .WithMany(p => p.Projects)
                .HasForeignKey(p => p.ContactId)
                .HasConstraintName("FK_Contact_Project");
        }
    }
}
