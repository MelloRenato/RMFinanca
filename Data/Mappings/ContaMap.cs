using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMFinanca.Models;

namespace RMFinanca.Data.Mappings
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("Conta");
            
            // Chave Primária
            builder.HasKey(x=>x.Id);

            // Identity
            builder.Property(x=>x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Banco)
                .IsRequired()
                .HasColumnName("Banco")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Agencia)
                .HasColumnName("Agencia")
                .HasColumnType("VARCHAR")
                .HasMaxLength(10);

            builder.Property(x => x.ContaCorrente)
                .HasColumnName("ContaCorrente")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);

            // Índices
            builder.HasIndex(x => x.Banco, "IX_Conta_Banco")
                .IsUnique();
            //builder.HasIndex(x => new { x.Agencia, x.ContaCorrente }, "IX_Conta_Banco")
            //    .IsUnique();

        }
    }
}
