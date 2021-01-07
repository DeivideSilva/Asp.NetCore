using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCliente.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCliente.Infrastructure.EntityConfig
{
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
               builder.HasMany(m => m.SubMenu)
               .WithOne()
               .HasForeignKey(m => m.MenuId);
        }
    }
}
