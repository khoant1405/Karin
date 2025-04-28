using Karin.Shared.Localization;
using Microsoft.OpenApi.Models;

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

            return services;
        }

        private static IServiceCollection AddGenSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "My API",
                    Version = "v1",
                    Description = "API Documentation"
                    //Contact = new OpenApiContact
                    //{
                    //    Name = "Your Name",
                    //    Email = "your@email.com",
                    //    Url = new Uri("https://yourwebsite.com")
                    //}
                });
            });

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ILocalizationService, LocalizationService>();

            return services;
        }

        public static IServiceCollection AddConfigLocalization(this IServiceCollection services)
        {
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[] { "en-US", "vi-VN" };
                options.SetDefaultCulture("vi-VN")
                    .AddSupportedCultures(supportedCultures)
                    .AddSupportedUICultures(supportedCultures);
            });

            services.AddLocalization();

            return services;
        }
    }
}