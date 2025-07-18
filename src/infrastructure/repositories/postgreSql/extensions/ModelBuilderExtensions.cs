using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Biogenom_test.infrastructure.repositories.postgreSql.extensions;

public static class ModelBuilderExtensions
{
    public static void ApplyConfiguration(this ModelBuilder builder) => builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}
