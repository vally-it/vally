using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using ProjectVally.Domain.Entities;
using ProjectVally.Infra.Data.EntityConfig;

namespace ProjectVally.Infra.Data.Contexto
{
    public class ProjetoModeloContext : DbContext
    {

        public ProjetoModeloContext()
            : base("ProjectVallyDB")
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public IDbSet<User> Users { get; set; }
        public IDbSet<Account> Accounts { get; set; }
        public IDbSet<AccountKind> AccountKinds { get; set; }
        public IDbSet<Entry> Entries { get; set; }
        public IDbSet<EntryKind> EntryKinds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(250));

            modelBuilder.Configurations.Add(new AccountConfiguration());
            modelBuilder.Configurations.Add(new AccountKindConfiguration());
            modelBuilder.Configurations.Add(new EntryConfiguration());
            modelBuilder.Configurations.Add(new EntryKindConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegisterDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("RegisterDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("RegisterDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }

}
