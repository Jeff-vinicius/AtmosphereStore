using Atmosphere.Catalogo.API.Data;
using Atmosphere.Catalogo.API.Data.Repository;
using Atmosphere.Catalogo.API.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Atmosphere.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}