using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Infra.CrossCutting.ConfigurationExtensions
{
    public static class SwaggerExtensions
    {
        public static void ConfigurarSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(t =>
            {
                t.SwaggerDoc("v1", new OpenApiInfo { Title = "Api Cartão Virtual", Version = "v1" });
            });
        }
    }
}
