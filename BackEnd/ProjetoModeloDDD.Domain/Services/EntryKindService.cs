using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Interfaces.Repository;
using ProjectVally.Domain.Interfaces.Services;

namespace ProjectVally.Domain.Services
{
    public class EntryKindService: ServiceBase<EntryKind>, IEntryKindService
    {
        private readonly IEntryKindRepository _entryKindRepository;

        public EntryKindService(IEntryKindRepository entryKindRepository)
            : base(entryKindRepository)
        {
            _entryKindRepository = entryKindRepository;
        }

    }
}
