using Biogenom_test.domain.logics.implementation;
using Biogenom_test.domain.logics.interfaces;

namespace Biogenom_test.domain.logics.extensions;

public static class ServiceExtensions
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IIndicatorService, IndicatorService>();
        services.AddScoped<IDietarySupplementsService, DietarySupplementsService>();
    }
}
