using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using LibraryAPI.ApplicationContexts;
using LibraryAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using LibraryAPI;
using AutoMapper;
using LibraryAPI.Stories;
using System.Reflection;

class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
         
        builder.Services.AddHttpClient();
        builder.Services.AddControllers();
        builder.Services.AddMvc();
        builder.Services.AddSingleton(typeof(DbLibraryContext))
           .AddSingleton(typeof(IRepository<DbLibraryContext>), typeof(LibraryRepository<DbLibraryContext>))
           .AddDbContextPool<DbLibraryContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("PostgresSQL")));
        
        builder.Services.AddSingleton(typeof(DbUserContext))
           .AddSingleton(typeof(IRepository<DbUserContext>), typeof(UserRepository<DbUserContext>))
           .AddDbContextPool<DbUserContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MsSQL")));

        builder.Services.AddSingleton(typeof(DbAnalyticsSettings))
           .AddSingleton(typeof(IMongoRepository), typeof(MongoRepository));

        builder.Services.Configure<DbAnalyticsSettings>(
            builder.Configuration.GetSection("MongoDbSettings"));

        builder.Services
            .AddAutoMapper(typeof(BaseMapperProfile))
            .AddAutoMapper(typeof(StoryAppMappingProfile));


        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "LibraryAPI", Version = "v1" });
        });
        builder.Services.AddMediator();

        var app = builder.Build();

        app.UseExceptionHandler("/error");

        app.UseHttpsRedirection();

        app.UseSwagger();

        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("../swagger/v1/swagger.json", "LibraryAPI");
            c.RoutePrefix = string.Empty;
        });

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.Run();
    }

}
