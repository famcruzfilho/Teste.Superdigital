using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Superdigital.Domain.Models;

namespace Teste.Superdigital.Infraestructure.Data.Mappings
{
    public class ContaCorrenteMap : IEntityTypeConfiguration<ContaCorrente>
    {
        public void Configure(EntityTypeBuilder<ContaCorrente> builder)
        {
            builder.ToTable("ContasCorrentes");

            builder.HasKey(x => x.ContaCorrenteId);

            builder.Property(x => x.Numero)
                .IsRequired();

            builder.Property(x => x.Titular)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(x => x.Criacao)
                .IsRequired();

            builder.Property(x => x.Saldo)
                .IsRequired();
        }
    }
}