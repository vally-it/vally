using System.Collections.Generic;
using ProjectVally.Domain.Entities;

namespace ProjectVally.Domain.Interfaces.Repository
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
