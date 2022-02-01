using Atmosphere.WebAPI.Core.Controllers;
using Microsoft.AspNetCore.Authorization;

namespace Atmosphere.Carrinho.API.Controllers
{
    [Authorize]
    public class CarrinhoController : MainController
    {
    }
}
