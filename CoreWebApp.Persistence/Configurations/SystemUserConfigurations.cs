using CoreWebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Persistence.Configurations {
    public class SystemUserConfigurations : IEntityTypeConfiguration<SystemUser> {
        public void Configure(EntityTypeBuilder<SystemUser> builder) {
            builder.Property(p => p.Id).HasColumnName("SystemUserID");
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(200);

            builder.HasOne(p => p.Position)
                .WithMany(p => p.SystemUsers)
                .HasForeignKey(p => p.PositionId)
                .HasConstraintName("FK_SystemUser_Position")
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Manager)
                .WithMany(p => p.Subordinates)
                .HasForeignKey(p => p.ManagerId)
                .HasConstraintName("FK_Manager_SystemUser")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
