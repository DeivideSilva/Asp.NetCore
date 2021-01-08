using SGCliente.ApplicationCore.Entity;
using SGCliente.ApplicationCore.Interfaces.Repository;
using SGCliente.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCliente.Infrastructure.Repository
{
    public class ContatoRepository : EFRepository<Contato>, IContatoRepository
    {
        public ContatoRepository(ClienteContext dbcontext) : base(dbcontext)
        {

        }
    }
}