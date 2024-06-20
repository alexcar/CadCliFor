using Microsoft.OpenApi.Models;

namespace Flexbyte.CadCliFor.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSwagger(this IServiceCollection services) 
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen( options =>
            {
                options.SwaggerDoc("V1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Flexbyte CadCliFor API",
                    Description = "Flexbyte CadCliFor API"
                });
            });
        }

        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithExposedHeaders("X-Pagination"));
            });        
        
    }
}
