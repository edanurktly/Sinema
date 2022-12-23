using Microsoft.EntityFrameworkCore;
using Sinema.Entities.Entities.Abstract;
using Sinema.Entities.Entities.Concrete;
using System.Reflection;

namespace Sinema.DAL.Context
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Gosterim> Gosterimler { get; set; }
        public DbSet<Hafta> Haftalar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Salon> Salonalar { get; set; }
        public DbSet<Seans> Seansalar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=Sinema;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            UpdateSoftDeleteStatus();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void UpdateSoftDeleteStatus()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {

                    case EntityState.Added:
                        entry.CurrentValues["Status"] = Status.Active;
                        entry.CurrentValues["CreateDate"] = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.CurrentValues["Status"] = Status.Update;
                        entry.CurrentValues["UpdateDate"] = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["Status"] = Status.Delete;
                        entry.CurrentValues["UpdateDate"] = DateTime.Now;
                        break;

                }

            }

        }
    }
}
