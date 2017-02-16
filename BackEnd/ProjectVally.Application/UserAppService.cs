using ProjectVally.Application.Interface;
using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Interfaces.Services;

namespace ProjectVally.Application
{
    public class UserAppService: AppServiceBase<User>, IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService):base(userService)
        {
            _userService = userService;
        }
    }
}
