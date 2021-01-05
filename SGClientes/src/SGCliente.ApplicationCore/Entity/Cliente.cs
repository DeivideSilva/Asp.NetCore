using System;
using System.Collections.Generic;
using System.Text;

namespace SGCliente.ApplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public ICollection<Contato> Contato { get; set; }
    }
}
