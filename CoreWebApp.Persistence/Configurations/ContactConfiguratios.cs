using CoreWebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreWebApp.Persistence.Configurations {
    public class ContactConfiguratios : IEntityTypeConfiguration<Contact> {

        public void Configure(EntityTypeBuilder<Contact> builder) {
            builder.Property(p => p.Id).HasColumnName("ContactID");
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(250);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Contacts)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired()
                .HasConstraintName("FK_Customer_Contact");

        }
    }
}
