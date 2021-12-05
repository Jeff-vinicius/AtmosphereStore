using Atmosphere.WebApp.MVC.Extensions;
using Atmosphere.WebApp.MVC.Services;
using Atmosphere.WebApp.MVC.Services.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Refit;

namespace Atmosphere.WebApp.MVC.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<HttpClientAutorizationDelegatingHandler>();

            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();

            //services.AddHttpClient<ICatalogoService, CatalogoService>()
            //    .AddHttpMessageHandler<HttpClientAutorizationDelegatingHandler>();

            services.AddHttpClient("Refit", options =>
                {
                    options.BaseAddress = new Uri(configuration.GetSection("CatalogoUrl").Value);
                })
            .AddHttpMessageHandler<HttpClientAutorizationDelegatingHandler>()
            .AddTypedClient(Refit.RestService.For<ICatalogoServiceRefit>);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}
