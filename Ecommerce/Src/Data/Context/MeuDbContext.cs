using Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options) 
        { 
        }
        
        public DbSet<Produto> Produtos { get; set; }

    }
}
