using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Atmosphere.WebAPI.Core.Usuario;

namespace Atmosphere.Bff.Compras.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

        }
    }
}
