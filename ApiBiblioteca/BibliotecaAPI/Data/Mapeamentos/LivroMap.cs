<<<<<<< HEAD
﻿using BibliotecaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaAPI.Data.Mapeamentos
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.NomeLivro).HasMaxLength(50).IsRequired();

            builder.Property(t => t.Autor).HasMaxLength(50).IsRequired(false);

            builder.Property(t => t.AnoPublicacao).IsRequired();

            builder.ToTable(nameof(Livro));
        }
    }
}
=======
﻿using BibliotecaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaAPI.Data.Mapeamentos
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.NomeLivro).HasMaxLength(50).IsRequired();

            builder.Property(t => t.Autor).HasMaxLength(50).IsRequired(false);

            builder.Property(t => t.AnoPublicacao).IsRequired();

            builder.ToTable(nameof(Livro));
        }
    }
}
>>>>>>> f7666eaedf2183c2669ec62684fad74deecefea8
