using System.Collections.Generic;
using ProjectVally.Domain.Entities;

namespace ProjectVally.Domain.Interfaces.Services
{
    public interface IProdutoService: IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
