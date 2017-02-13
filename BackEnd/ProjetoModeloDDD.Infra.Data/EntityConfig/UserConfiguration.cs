using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(u => u.UserId);

            Property(u => u.Name)
                .IsRequired();

            Property(u => u.Cpf)
                .IsRequired()
                .HasMaxLength(15);

            Property(u => u.Password)
                .IsRequired();

        }
    }
}
