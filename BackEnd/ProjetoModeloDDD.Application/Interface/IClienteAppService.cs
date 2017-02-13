using System.Collections.Generic;
using ProjectVally.Domain.Entities;

namespace ProjectVally.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
