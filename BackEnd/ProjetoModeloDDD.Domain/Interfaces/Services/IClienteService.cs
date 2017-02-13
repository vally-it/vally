using System.Collections.Generic;
using ProjectVally.Domain.Entities;

namespace ProjectVally.Domain.Interfaces.Services
{
    public interface IClienteService: IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
