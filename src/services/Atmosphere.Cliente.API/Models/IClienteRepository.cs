using Atmosphere.Core.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Atmosphere.Clientes.API.Models
{
    public interface IClienteRepository : IRepository<Client>
    {
        void Adicionar(Client cliente);

        Task<IEnumerable<Client>> ObterTodos();
        Task<Client> ObterPorCpf(string cpf);
    }
}
