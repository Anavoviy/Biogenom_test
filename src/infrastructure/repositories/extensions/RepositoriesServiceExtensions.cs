using Biogenom_test.domain.models;
using Biogenom_test.infrastructure.repositories.interfaces;
using Biogenom_test.infrastructure.repositories.postgreSql.repositories;

namespace Biogenom_test.infrastructure.repositories.extensions;

public static class RepositoriesServiceExtensions
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IRepository<IndicatorForm>, IndicatorFormRepository>();
        services.AddScoped<IRepository<DietarySupplement>, DietarySupplementRepository>();
    }
}
