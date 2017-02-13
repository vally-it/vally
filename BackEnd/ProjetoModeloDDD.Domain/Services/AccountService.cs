using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Interfaces.Repository;
using ProjectVally.Domain.Interfaces.Services;

namespace ProjectVally.Domain.Services
{
    public class AccountService: ServiceBase<Account>, IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
            : base(accountRepository)
        {
            _accountRepository = accountRepository;
        }

    }
}
