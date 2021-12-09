using Atmosphere.Clientes.API.Models;
using Atmosphere.Core.Messages;
using FluentValidation.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atmosphere.Clientes.API.Application.Commands
{
    public class ClienteCommandHandler : CommandHandler,
        IRequestHandler<RegistrarClienteCommand, ValidationResult>
    {
        public async Task<ValidationResult> Handle(RegistrarClienteCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var cliente = new Client(message.Id, message.Nome, message.Email, message.Cpf);

            //Validacoes de negocio

            //Persistir no banco 

            return message.ValidationResult;
        }
    }
}
