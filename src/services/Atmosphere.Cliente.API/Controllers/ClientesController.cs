using Atmosphere.Clientes.API.Application.Commands;
using Atmosphere.Core.Mediator;
using Atmosphere.WebAPI.Core.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Atmosphere.Clientes.API.Controllers
{
    public class ClientesController : MainController
    {
        private readonly IMediatorHandler _mediatorHandler;

        public ClientesController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var resultado = await _mediatorHandler.EnviarComando(
                new RegistrarClienteCommand(Guid.NewGuid(), "Jeff", "jeff@jeff.com", "44185106807"));

            return CustomResponse(resultado);
        }
    }
}
