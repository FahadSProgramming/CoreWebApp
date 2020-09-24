using CoreWebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Persistence.Configurations {
    public class DesignationConfiguration : IEntityTypeConfiguration<Designation> {
        public void Configure(EntityTypeBuilder<Designation> builder) {
            builder.Property(b => b.Id).HasColumnName("DesigntionID");
            builder.Property(b => b.Name).IsRequired().HasMaxLength(50);
            //builder.HasMany(b => b.SystemUsers)
            //            .WithOne(b => b.Position)
            //            .HasForeignKey(b => b.PositionId)
            //            .HasConstraintName("FK_SystemUser_Designation");
        }
    }
}
