using CoreWebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Persistence.Configurations {
    public class IncidentActivityConfiguration : IEntityTypeConfiguration<IncidentActivity> {
        public void Configure(EntityTypeBuilder<IncidentActivity> builder) {
            builder.Property(p => p.Id).HasColumnName("IncidentActivityID");
            builder.Property(p => p.Title).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Body).HasColumnType("ntext");

            builder.HasOne(p => p.SystemUser)
                .WithMany(p => p.IncidentActivities)
                .HasForeignKey(p => p.SystemUserId)
                .HasConstraintName("FK_SystemUser_IncidentActivity");

            builder.HasOne(p => p.Incident)
                .WithMany(p => p.IncidentActivities)
                .HasForeignKey(p => p.IncidentId)
                .HasConstraintName("FK_IncidentActivity_Incident")
                .IsRequired();

            builder.HasOne(p => p.Contact)
                .WithMany(p => p.IncidentActivities)
                .HasForeignKey(p => p.ContactId)
                .HasConstraintName("FK_Contact_IncidentActivity");
        }
    }
}
