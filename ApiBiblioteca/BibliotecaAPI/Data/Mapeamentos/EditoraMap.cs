using BibliotecaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BibliotecaAPI.Data.Mapeamentos
{
    public class EditoraMap : IEntityTypeConfiguration<Editora>
    {
        public void Configure(EntityTypeBuilder<Editora> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(t => t.Apresentacao)
               .HasMaxLength(150)
               .IsRequired(false);

            builder.ToTable(nameof(Editora));

        }
    }
}
