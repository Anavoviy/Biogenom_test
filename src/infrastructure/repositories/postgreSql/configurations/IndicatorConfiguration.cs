using Biogenom_test.domain.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom_test.infrastructure.repositories.postgreSql.configurations;

public class IndicatorConfiguration : IEntityTypeConfiguration<Indicator>
{
    public void Configure(EntityTypeBuilder<Indicator> builder)
    {
        builder.ToTable("indicators");
        builder.HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("id");
        builder.Property(i => i.Name).HasColumnName("name").HasMaxLength(255);
        builder.Property(i => i.MinStandart).HasColumnName("min_standart").IsRequired();
        builder.Property(i => i.MaxStandart).HasColumnName("max_standart");

        builder.Property(i => i.CreatedAt).HasColumnName("created_at").HasDefaultValue(DateTime.UtcNow);
        builder.Property(i => i.UpdatedAt).HasColumnName("updated_at");
        builder.Property(i => i.DeletedAt).HasColumnName("deleted_at");
    }
}
