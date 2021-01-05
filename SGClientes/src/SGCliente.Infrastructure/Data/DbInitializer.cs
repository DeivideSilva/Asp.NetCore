using SGCliente.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCliente.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {
            if(context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Fulano de Tal",
                    CPF = "19325294036"
                },

                new Cliente
                {
                    Nome = "Ciclano da Silva",
                    CPF = "40455470022"
                }
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "1199999999",
                    Email = "contato@teste.com",
                    Cliente = clientes[0]

                },

                new Contato
                {
                    Nome = "Contato 2",
                    Telefone ="1155544466",
                    Email = "contato2@teste.com",
                    Cliente = clientes[1]
                },

            };

            context.AddRange(contatos);
            context.SaveChanges();

        }
    }
}
