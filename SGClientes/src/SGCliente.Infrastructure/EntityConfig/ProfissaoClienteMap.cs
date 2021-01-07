using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCliente.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCliente.Infrastructure.EntityConfig
{
    public class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
    {
        public void Configure(EntityTypeBuilder<ProfissaoCliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Cliente)
                .WithMany(c => c.ProfissoesClientes)
                .HasForeignKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Profissao)
                .WithMany(p => p.ProfissoesClientes)
                .HasForeignKey(p => p.ProfissaoId);
        }
    }
}
