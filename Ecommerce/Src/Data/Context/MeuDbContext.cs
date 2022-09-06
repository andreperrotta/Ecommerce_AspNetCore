using Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options) 
        { 
        }
        
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            foreach (var relationalship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) 
                relationalship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }


            base.OnModelCreating(modelBuilder);

        }

    }
}
