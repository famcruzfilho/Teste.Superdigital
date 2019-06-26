using Microsoft.EntityFrameworkCore;
using Teste.Superdigital.Domain.Models;
using Teste.Superdigital.Infraestructure.Data.Mappings;

namespace Teste.Superdigital.Infraestructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ContaCorrente> ContasCorrentes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContaCorrenteMap());
        }
    }
}