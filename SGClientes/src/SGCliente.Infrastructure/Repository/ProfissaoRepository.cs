using SGCliente.ApplicationCore.Entity;
using SGCliente.ApplicationCore.Interfaces.Repository;
using SGCliente.Infrastructure.Data;

namespace SGCliente.Infrastructure.Repository
{
    public class ProfissaoRepository : EFRepository<Profissao>,IProfissaoRepository
    {
        public ProfissaoRepository(ClienteContext dbcontext) : base(dbcontext)
        {

        }
    }
}
