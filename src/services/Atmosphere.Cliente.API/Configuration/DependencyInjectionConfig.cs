using Atmosphere.Clientes.API.Data.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace Atmosphere.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ClientesContext>();
        }
    }
}
