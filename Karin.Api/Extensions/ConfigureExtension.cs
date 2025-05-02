namespace Karin.Api.Extensions
{
    public static class ConfigureExtension
    {
        public static WebApplication ConfigureExtensions(this WebApplication app)
        {
            app.UseRequestLocalization();

            app.UseHttpsRedirection();

            app.UseRouting();

            if (app.Environment.IsDevelopment())
            {
                app.UseGenSwagger();
            }

            app.UseAuthorization();

            app.MapControllers();

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