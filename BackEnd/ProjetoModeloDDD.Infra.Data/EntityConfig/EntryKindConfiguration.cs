using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class EntryKindConfiguration : EntityTypeConfiguration<EntryKind>
    {
        public EntryKindConfiguration()
        {
            HasKey(e => e.EntryKindId);

            Property(e => e.Description)
                .IsRequired();

            HasRequired(e => e.Owner)
                .WithMany()
                .HasForeignKey(e => e.OwnerId);

        }
    }
}
