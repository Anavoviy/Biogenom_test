using Biogenom_test.domain.logics.extensions;
using Biogenom_test.infrastructure.repositories.extensions;
using Biogenom_test.infrastructure.repositories.postgreSql.extensions;
using DotNetEnv;

namespace Biogenom_test;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //Если запуск через docker, то можно убрать обработку блока else
        //Все переменные нужно окружения прописать в docker-compose.yaml
        if (builder.Environment.IsDevelopment())
            Env.Load("dev.env");
        else
            Env.Load("prod.env"); 
        
        // Add services to the container.
        builder.Services.AddPostgreSqlDbContext();
        builder.Services.AddRepositories();
        builder.Services.AddServices();

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
