using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
            HasKey(a => a.AccountId);

            Property(a => a.Description)
                .IsRequired();

            Property(a => a.CurrentBalance)
                .IsRequired();

            Property(a => a.RegisterDate)
                .IsRequired();

            HasRequired(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId);

            HasRequired(a => a.AccoundKind)
                .WithMany()
                .HasForeignKey(a => a.AccountKindId);

        }
    }
}
