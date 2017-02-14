using ProjectVally.Application.Interface;
using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Interfaces.Services;

namespace ProjectVally.Application
{
    public class AccountAppService: AppServiceBase<Account>, IAccountAppService
    {
        private readonly IAccountService _accountService;

        public AccountAppService(IAccountService accountService):base(accountService)
        {
            _accountService = accountService;
        }
    }
}
