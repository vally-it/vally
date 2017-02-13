using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Interfaces.Repository;
using ProjectVally.Domain.Interfaces.Services;

namespace ProjectVally.Domain.Services
{
    public class EntryService: ServiceBase<Entry>, IEntryService
    {
        private readonly IEntryRepository _entryRepository;

        public EntryService(IEntryRepository entryRepository)
            : base(entryRepository)
        {
            _entryRepository = entryRepository;
        }

    }
}
