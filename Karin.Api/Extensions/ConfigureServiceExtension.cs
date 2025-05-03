using System.Globalization;
using Karin.Application.Interfaces;
using Karin.Application.Services;
using Karin.Domain;
using Karin.Domain.Entities;
using Karin.Infrastructure;
using Karin.Infrastructure.Repositories;
using Microsoft.AspNetCore.Localization;
using Microsoft.OpenApi.Models;
using MongoDB.Driver;

namespace Karin.Api.Extensions
{
    public static class ConfigureServiceExtension
    {
        public static IServiceCollection ConfigureServiceExtensions(this IServiceCollection services)
        {
            services.AddServices();

            services.AddControllers();

            services.AddGenSwagger();

            services.AddConfigLocalization();

            services.AddInfrastructure(services.BuildServiceProvider().GetRequiredService<IConfiguration>());

            return services;
        }

        private static void AddGenSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "My API",
                    Version = "v1",
                    Description = "API Documentation"
                });
            });
        }

        private static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IComicService, ComicService>();
        }

        private static void AddConfigLocalization(this IServiceCollection services)
        {
            services.AddLocalization(options => options.ResourcesPath = "Resources");

            var supportedCultures = new[] { new CultureInfo("en"), new CultureInfo("vi") };
            services.Configure<RequestLocalizationOptions>(opts =>
            {
                opts.DefaultRequestCulture = new RequestCulture("vi");
                opts.SupportedCultures = supportedCultures;
                opts.SupportedUICultures = supportedCultures;
            });
        }

        private static void AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            var settings = config.GetSection("MongoDbSettings").Get<MongoDbSettings>()!;
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            services.AddSingleton(database);
            services.AddScoped<IRepository<Comic>, ComicRepository>();
        }
    }
}