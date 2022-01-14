using Atmosphere.Clientes.API.Application.Commands;
using Atmosphere.Clientes.API.Application.Events;
using Atmosphere.Clientes.API.Data.Mapping;
using Atmosphere.Clientes.API.Data.Repository;
using Atmosphere.Clientes.API.Models;
using Atmosphere.Core.Mediator;
using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Atmosphere.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();

            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();
        }
    }
}
