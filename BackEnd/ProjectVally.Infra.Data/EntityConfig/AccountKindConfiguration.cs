using System.Data.Entity.ModelConfiguration;
using ProjectVally.Domain.Entities;

namespace ProjectVally.Infra.Data.EntityConfig
{
    public class AccountKindConfiguration : EntityTypeConfiguration<AccountKind>
    {
        public AccountKindConfiguration()
        {
            HasKey(a => a.AccountKindId);

            Property(a => a.Description)
                .IsRequired();
        }
    }
}
