using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
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
