namespace Karin.Api.Extensions
{
    public static class ConfigureExtension
    {
        public static WebApplication ConfigureExtensions(this WebApplication app)
        {
            if (app.Environment.IsDevelopment()) app.UseGenSwagger();

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.UseRequestLocalization();

            return app;
        }

        public static IApplicationBuilder UseGenSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                options.RoutePrefix = string.Empty;
            });
            return app;
        }
    }
}