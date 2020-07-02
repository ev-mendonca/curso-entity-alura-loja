using Microsoft.EntityFrameworkCore;
using Data.Entities;
namespace Data
{
    public class Context : DbContext
    {

        public Context(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>().HasKey(x => x.ID);
            modelBuilder.Entity<Produto>().HasMany(x => x.Avaliacoes);

            modelBuilder.Entity<Cliente>().HasKey(x => x.ID);
            modelBuilder.Entity<Cliente>().HasMany(x => x.Avaliacoes);

            modelBuilder.Entity<Avaliacao>().HasKey(x => x.ID);
            modelBuilder.Entity<Avaliacao>().HasOne(x => x.Cliente).WithMany(x => x.Avaliacoes).IsRequired();
            modelBuilder.Entity<Avaliacao>().HasOne(x => x.Produto).WithMany(x => x.Avaliacoes).IsRequired();

        }
    }
}
