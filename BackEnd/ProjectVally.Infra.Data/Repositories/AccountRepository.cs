using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Interfaces.Repository;

namespace ProjectVally.Infra.Data.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
    }
}
