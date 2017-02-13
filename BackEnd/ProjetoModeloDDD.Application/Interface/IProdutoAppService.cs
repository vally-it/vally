using System.Collections.Generic;
using ProjectVally.Domain.Entities;

namespace ProjectVally.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
