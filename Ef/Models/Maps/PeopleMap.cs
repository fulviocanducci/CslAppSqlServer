using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ef.Models.Maps;

public class PeopleMap : IEntityTypeConfiguration<People>
{
    public void Configure(EntityTypeBuilder<People> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).HasColumnName("Id").UseIdentityColumn();
        builder.Property(c => c.Name).HasColumnName("Name").IsRequired().HasMaxLength(100);
        builder.Property(c => c.CreatedAt).HasColumnName("CreatedAt").IsRequired();
    }
}