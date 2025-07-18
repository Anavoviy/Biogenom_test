using Biogenom_test.domain.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom_test.infrastructure.repositories.postgreSql.configurations;

public class IndicatorFormConfiguration : IEntityTypeConfiguration<IndicatorForm>
{
    public void Configure(EntityTypeBuilder<IndicatorForm> builder)
    {
        builder.ToTable("form_indicators");
        builder.HasKey(i => i.IndicatorId);

        builder.Property(i => i.IndicatorId).HasColumnName("indicator_id");
        builder.Property(i => i.FactValue).HasColumnName("fact_value");
        
        builder.Property(i => i.CreatedAt).HasColumnName("created_at").HasDefaultValue(DateTime.UtcNow);
        builder.Property(i => i.UpdatedAt).HasColumnName("updated_at");
        builder.Property(i => i.DeletedAt).HasColumnName("deleted_at");
        
        builder.HasOne(i => i.Indicator)
            .WithMany()
            .HasForeignKey(i => i.IndicatorId);
    }
}
