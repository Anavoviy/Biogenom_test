using Biogenom_test.domain.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom_test.infrastructure.repositories.postgreSql.configurations;

public class DietarySupplementIndicatorConfiguration : IEntityTypeConfiguration<DietarySupplementIndicator>
{
    public void Configure(EntityTypeBuilder<DietarySupplementIndicator> builder)
    {
        builder.ToTable("dietary_supplement_indicators");
        builder.HasKey(i => new { i.DietarySupplementId, i.IndicatorId });
        
        builder.Property(i => i.Value).HasColumnName("value");
        
        builder.Property(i => i.CreatedAt).HasColumnName("created_at").HasDefaultValue(DateTime.UtcNow);
        builder.Property(i => i.UpdatedAt).HasColumnName("updated_at");
        builder.Property(i => i.DeletedAt).HasColumnName("deleted_at");
        
        builder.HasOne(i => i.Indicator)
            .WithMany()
            .HasForeignKey(i => i.IndicatorId);
        builder.HasOne(i => i.DietarySupplement)
            .WithMany(i => i.Indicators)
            .HasForeignKey(i => i.DietarySupplementId);
    }
}
