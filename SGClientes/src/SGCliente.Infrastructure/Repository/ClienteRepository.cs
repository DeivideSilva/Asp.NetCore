using SGCliente.ApplicationCore.Entity;
using SGCliente.ApplicationCore.Interfaces.Repository;
using SGCliente.Infrastructure.Data;
using System.Linq;

namespace SGCliente.Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>,IClienteRepository
    {
        public ClienteRepository(ClienteContext dbcontext): base(dbcontext)
        {

        }
        public Cliente ObterPorProfissao(int clienteId)
        {
           return Buscar(c => c.ProfissoesClientes.Any(c => c.ClienteId == clienteId)).FirstOrDefault();
        }
    }
}
