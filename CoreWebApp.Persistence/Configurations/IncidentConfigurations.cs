using CoreWebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Persistence.Configurations {
    public class IncidentConfigurations : IEntityTypeConfiguration<Incident> {
        public void Configure(EntityTypeBuilder<Incident> builder) {
            builder.Property(p => p.Id).HasColumnName("IncidentID");
            builder.Property(p => p.Title).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Description).HasColumnType("ntext");

            builder.HasOne(p => p.Category)
                .WithMany(p => p.Incidents)
                .HasForeignKey(p => p.CategoryId)
                .HasConstraintName("FK_Incident_Category")
                .IsRequired();

            builder.HasOne(p => p.Customer)
                .WithMany(p => p.Incidents)
                .HasForeignKey(p => p.CustomerId)
                .HasConstraintName("FK_Incident_Customer")
                .IsRequired();

            builder.HasOne(p => p.Project)
                .WithMany(p => p.Incidents)
                .HasForeignKey(p => p.ProjectId)
                .HasConstraintName("FK_Incident_Project")
                .IsRequired();

            builder.HasOne(p => p.Contact)
                .WithMany(p => p.Incidents)
                .HasForeignKey(p => p.ContactId)
                .HasForeignKey("FK_Incident_Contact")
                .IsRequired();

        }
    }
}
