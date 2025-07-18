using Biogenom_test.domain.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom_test.infrastructure.repositories.postgreSql.configurations;

public class DietarySupplementConfiguration : IEntityTypeConfiguration<DietarySupplement>
{
    public void Configure(EntityTypeBuilder<DietarySupplement> builder)
    {
        builder.ToTable("dietary_supplements");
        builder.HasKey(i => i.Id);
        
        builder.Property(i => i.Id).HasColumnName("id");
        builder.Property(i => i.Name).HasColumnName("name").HasMaxLength(255);
        builder.Property(i => i.ImageUrl).HasColumnName("image_url");
        
        builder.Property(i => i.CreatedAt).HasColumnName("created_at").HasDefaultValue(DateTime.UtcNow);
        builder.Property(i => i.UpdatedAt).HasColumnName("updated_at");
        builder.Property(i => i.DeletedAt).HasColumnName("deleted_at");
    }
}
