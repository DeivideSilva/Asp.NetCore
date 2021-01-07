using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCliente.ApplicationCore.Entity;
using System;

namespace SGCliente.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.ClienteId);

            builder.HasMany(c => c.Contato)
                 .WithOne(c => c.Cliente)
                 .HasForeignKey(c => c.ClienteId)
                 .HasPrincipalKey(c => c.ClienteId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Endereco)
                   .WithOne(e => e.Cliente)
                   .HasForeignKey<Endereco>(e => e.ClienteId);


            builder.Property(c => c.CPF)
                 .HasColumnType("varchar(11)")
                 .IsRequired();

            builder.Property(c => c.Nome)
                 .HasColumnType("varchar(100)")
                 .IsRequired();
        }
    }
}
