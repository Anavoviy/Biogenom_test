using Biogenom_test.domain.models;
using Biogenom_test.infrastructure.repositories.interfaces;
using Biogenom_test.infrastructure.repositories.postgreSql.context;
using Biogenom_test.infrastructure.repositories.postgreSql.repositories;
using Microsoft.EntityFrameworkCore;

namespace Biogenom_test.infrastructure.repositories.postgreSql.extensions;

public static class PostgreSQLServiceExtension
{
    public static void AddPostgreSqlDbContext(this IServiceCollection services)
    {
        var host = Environment.GetEnvironmentVariable("DB_HOST");
        var port = Environment.GetEnvironmentVariable("DB_PORT");
        var database = Environment.GetEnvironmentVariable("DB_NAME");
        var user = Environment.GetEnvironmentVariable("DB_USER");
        var password = Environment.GetEnvironmentVariable("DB_PASSWORD");
        
        var connectionString = $"Server={host};Port={port};Database={database};Username={user};Password={password}";

        services.AddScoped<DbContext, PostgreSqlContext>(s => new PostgreSqlContext(connectionString));
    }

   
    
}
