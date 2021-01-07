﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SGCliente.Infrastructure.Data;

namespace SGCliente.Infrastructure.Migrations
{
    [DbContext(typeof(ClienteContext))]
    [Migration("20210107191553_Inicio")]
    partial class Inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.Contato", b =>
                {
                    b.Property<int>("ContatoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(15)");

                    b.HasKey("ContatoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Referencia")
                        .HasColumnType("varchar(300)");

                    b.HasKey("EnderecoId");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.Profissao", b =>
                {
                    b.Property<int>("ProfissaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CBO")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("ProfissaoId");

                    b.ToTable("Profissao");
                });

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.ProfissaoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("ProfissaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProfissaoId");

                    b.ToTable("ProfissaoCliente");
                });

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.Contato", b =>
                {
                    b.HasOne("SGCliente.ApplicationCore.Entity.Cliente", "Cliente")
                        .WithMany("Contato")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.Endereco", b =>
                {
                    b.HasOne("SGCliente.ApplicationCore.Entity.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("SGCliente.ApplicationCore.Entity.Endereco", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.Menu", b =>
                {
                    b.HasOne("SGCliente.ApplicationCore.Entity.Menu", null)
                        .WithMany("SubMenu")
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.ProfissaoCliente", b =>
                {
                    b.HasOne("SGCliente.ApplicationCore.Entity.Cliente", "Cliente")
                        .WithMany("ProfissoesClientes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SGCliente.ApplicationCore.Entity.Profissao", "Profissao")
                        .WithMany("ProfissoesClientes")
                        .HasForeignKey("ProfissaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Profissao");
                });

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.Cliente", b =>
                {
                    b.Navigation("Contato");

                    b.Navigation("Endereco");

                    b.Navigation("ProfissoesClientes");
                });

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.Menu", b =>
                {
                    b.Navigation("SubMenu");
                });

            modelBuilder.Entity("SGCliente.ApplicationCore.Entity.Profissao", b =>
                {
                    b.Navigation("ProfissoesClientes");
                });
#pragma warning restore 612, 618
        }
    }
}
