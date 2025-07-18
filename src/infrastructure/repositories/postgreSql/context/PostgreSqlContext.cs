using Biogenom_test.infrastructure.repositories.postgreSql.extensions;
using Microsoft.EntityFrameworkCore;

namespace Biogenom_test.infrastructure.repositories.postgreSql.context;

public class PostgreSqlContext : DbContext
{
    private readonly string _connectionString;
    
    public PostgreSqlContext(string connectionString)
    {
        _connectionString = connectionString;
        
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) 
        => options.UseNpgsql(_connectionString);

    protected override void OnModelCreating(ModelBuilder builder) 
        => builder.ApplyConfiguration();
}
