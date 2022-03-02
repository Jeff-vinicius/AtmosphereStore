using Atmosphere.Bff.Compras.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;

namespace Atmosphere.Bff.Compras.Services
{
    public interface ICatalagoService
    {

    }

    public class CatalagoService : Service, ICatalagoService
    {
        private readonly HttpClient _httpClient;

        public CatalagoService(HttpClient httpClient, IOptions<AppServicesSettings> settings)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(settings.Value.CatalogoUrl);
        }
    }
}
