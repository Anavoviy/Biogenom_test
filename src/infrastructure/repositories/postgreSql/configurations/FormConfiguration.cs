using Biogenom_test.domain.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biogenom_test.infrastructure.repositories.postgreSql.configurations;

public class FormConfiguration : IEntityTypeConfiguration<Form>
{
    public void Configure(EntityTypeBuilder<Form> builder)
    {
        builder.ToTable("forms");
        builder.HasKey(i => i.Id);
        
        builder.Property(i => i.Id).HasColumnName("id");
        
        builder.Property(i => i.CreatedAt).HasColumnName("created_at").HasDefaultValue(DateTime.UtcNow);
        builder.Property(i => i.UpdatedAt).HasColumnName("updated_at");
        builder.Property(i => i.DeletedAt).HasColumnName("deleted_at");

        builder.HasMany(i => i.DietarySupplements).WithOne();
        builder.HasMany(i => i.Indicators).WithOne();
    }
}
