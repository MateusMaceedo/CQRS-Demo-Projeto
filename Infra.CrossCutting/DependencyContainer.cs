using Domain.Repositories;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCutting
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

            services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("DatabaseCartaoVirtual"));

            services.AddScoped<DataContext, DataContext>();

            services.AddTransient<ICartaoVirtualRepository, CartaoVirtualRepository>();
        }
    }
}
