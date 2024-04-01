using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMFinanca.Models;

namespace RMFinanca.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            
            // Chave Primária
            builder.HasKey(x=>x.Id);

            // Identity
            builder.Property(x=>x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Email)
                .HasColumnName("Email")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.CPF)
                .IsRequired()
                .HasColumnName("CPF")
                .HasColumnType("VARCHAR")
                .IsFixedLength(true)
                .HasMaxLength(11);

            builder.Property(x => x.DDD)
                .HasColumnName("DDD")
                .HasColumnType("TINYINT")
                .IsFixedLength(true)
                .HasMaxLength(2);

            builder.Property(x => x.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("INT")
                .HasMaxLength(100);

            builder.Property(x => x.Endereco)
                .HasColumnName("Endereco")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(150);

            builder.Property(x => x.Numero)
                .HasColumnName("Numero")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);

            builder.Property(x => x.Bairro)
                .HasColumnName("Bairro")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Complemento)
                .HasColumnName("Complemento")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.UF)
                .HasColumnName("UF")
                .HasColumnType("VARCHAR")
                .IsFixedLength(true)
                .HasMaxLength(2);

            builder.Property(x => x.CEP)
                .HasColumnName("CEP")
                .HasColumnType("VARCHAR")
                .IsFixedLength(true)
                .HasMaxLength(8);

            // Índices
            builder.HasIndex(x => x.Nome, "IX_Cliente_Nome")
                .IsUnique();

            builder.HasIndex(x => x.CPF, "IX_Cliente_CPF")
                .IsUnique();

        }
    }
}
