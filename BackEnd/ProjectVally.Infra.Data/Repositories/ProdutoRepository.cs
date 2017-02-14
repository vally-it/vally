using System.Collections.Generic;
using System.Linq;
using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Interfaces.Repository;

namespace ProjectVally.Infra.Data.Repositories
{
    public class ProdutoRepository: RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
