using Microsoft.EntityFrameworkCore;
using RMFinanca.Data.Mappings;
using RMFinanca.Models;

namespace RMFinanca.Data
{
    public class FinancaDataContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<LancFinanca> LancFinancas { get; set; }

        public FinancaDataContext() { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlServer("Server=localhost,1433,Database=RMFinanca;User ID=sa;Password=1q2w3e4r@#$; TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ContaMap());
            modelBuilder.ApplyConfiguration(new LancFinancaMap());
        }

    }
}