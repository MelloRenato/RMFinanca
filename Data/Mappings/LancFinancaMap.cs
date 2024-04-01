using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMFinanca.Models;

namespace RMFinanca.Data.Mappings
{
    public class LancFinancaMap : IEntityTypeConfiguration<LancFinanca>
    {
        public void Configure(EntityTypeBuilder<LancFinanca> builder)
        {
            builder.ToTable("LancFinanca");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.PagarReceber)
                .IsRequired()
                .HasColumnName("PagarReceber")
                .HasColumnType("VARCHAR")
                .HasMaxLength(8);

            builder.Property(x => x.DtEmissao)
                .IsRequired()
                .HasColumnName("DtEmissao")
                .HasColumnType("DATE")
                .HasDefaultValue(DateTime.Now.ToUniversalTime()); // Gerado pelo C#
                // .HasDefaultValueSql("GETDATE()"); Gerado pelo SQLServer

            builder.Property(x => x.DtVencimento)
                .IsRequired()
                .HasColumnName("DtVencimento")
                .HasColumnType("DATE");

            builder.Property(x => x.DtPagto)
                .IsRequired()
                .HasColumnName("DtPagto")
                .HasColumnType("DATE");

            builder.Property(x => x.Valor)
                .IsRequired()
                .HasColumnName("Valor")
                .HasColumnType("DECIMAL(8,2)");

            builder.Property(x => x.Juros)
                .HasColumnName("Juros")
                .HasColumnType("DECIMAL(6,2)");

            builder.Property(x => x.VlPagto)
                .HasColumnName("VlPagto")
                .HasColumnType("DECIMAL(6,2)");

            builder.Property(x => x.Observacao)
                .HasColumnName("Observacao")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(1500);

            // Índices
            builder.HasIndex(x => x.DtVencimento, "IX_LancFinanca_DtVencimento");
            builder.HasIndex(x => x.DtEmissao, "IX_LancFinanca_DtEmissao");
            builder.HasIndex(x => x.DtPagto, "IX_LancFinanca_DtPagto");

            // Relacionamento
            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.LancFinanca)
                .HasConstraintName("FK_LancFinanca_Cliente")
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder.HasOne(x => x.Conta)
                .WithMany(x => x.LancFinanca)
                .HasConstraintName("FK_LancFinanca_Conta")
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
