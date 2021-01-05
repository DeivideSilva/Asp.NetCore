using Microsoft.EntityFrameworkCore;
using SGCliente.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCliente.Infrastructure.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base (options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");

            #region Cliente
            modelBuilder.Entity<Cliente>().Property(c => c.CPF)
                 .HasColumnType("varchar(11)")
                 .IsRequired();

            modelBuilder.Entity<Cliente>().Property(c => c.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            #endregion


            #region Contato
            modelBuilder.Entity<Contato>().Property(c => c.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(c => c.Telefone)
                .HasColumnType("varchar(15)");
            #endregion
        }
    }
}
