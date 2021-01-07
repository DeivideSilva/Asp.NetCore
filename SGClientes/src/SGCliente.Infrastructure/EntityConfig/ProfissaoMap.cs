using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCliente.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCliente.Infrastructure.EntityConfig
{
    public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder.Property(p => p.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

           builder.Property(p => p.Descricao)
                .HasColumnType("varchar(500)")
                .IsRequired();
        }
    }
}
