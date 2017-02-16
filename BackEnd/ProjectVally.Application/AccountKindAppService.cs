
using ProjectVally.Application.Interface;
using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Interfaces.Services;

namespace ProjectVally.Application
{
    public class AccountKindAppService: AppServiceBase<AccountKind>, IAccountKindAppService
    {
        private readonly IAccountKindService _accountKindService;

        public AccountKindAppService(IAccountKindService accountKindService):base(accountKindService)
        {
            _accountKindService = accountKindService;
        }
    }
}
