using System.Collections.Generic;
using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Interfaces.Repository;
using ProjectVally.Domain.Interfaces.Services;

namespace ProjectVally.Domain.Services
{
    public class ProdutoService: ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
