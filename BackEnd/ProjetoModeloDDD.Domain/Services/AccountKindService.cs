using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repository;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Domain.Services
{
    public class AccountKindService: ServiceBase<AccountKind>, IAccountKindService
    {
        private readonly IAccountKindRepository _accountKindRepository;

        public AccountKindService(IAccountKindRepository accountKindRepository)
            : base(accountKindRepository)
        {
            _accountKindRepository = accountKindRepository;
        }

    }
}
