using SGCliente.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCliente.ApplicationCore.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorProfissao(int clienteId);
    }
}
