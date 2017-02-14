using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Interfaces.Repository;
using ProjectVally.Domain.Interfaces.Services;

namespace ProjectVally.Domain.Services
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
