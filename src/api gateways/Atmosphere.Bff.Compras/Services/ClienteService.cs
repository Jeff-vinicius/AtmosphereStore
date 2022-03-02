using Atmosphere.Bff.Compras.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;

namespace Atmosphere.Bff.Compras.Services
{
    public interface IClienteService
    {

    }

    public class ClienteService : Service, IClienteService
    {
        private readonly HttpClient _httpClient;

        public ClienteService(HttpClient httpClient, IOptions<AppServicesSettings> settings)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(settings.Value.ClienteUrl);
        }
    }
}
