using SGCliente.ApplicationCore.Entity;
using SGCliente.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGCliente.ApplicationCore.Services
{
    public class ProfissaoService : IProfissaoService
    {
        private readonly IProfissaoService _profissaoService;
        public ProfissaoService(IProfissaoService profissaoService)
        {
            _profissaoService = profissaoService;
        }
        public Profissao Adicionar(Profissao entity)
        {
            return _profissaoService.Adicionar(entity);
        }

        public void Atualizar(Profissao entity)
        {
            _profissaoService.Atualizar(entity);
        }

        public IEnumerable<Profissao> Buscar(Expression<Func<Profissao, bool>> predicado)
        {
            return _profissaoService.Buscar(predicado);
        }

        public Profissao ObterPorId(int id)
        {
            return _profissaoService.ObterPorId(id);
        }

        public IEnumerable<Profissao> ObterTodos()
        {
            return _profissaoService.ObterTodos();
        }

        public void Remover(Profissao entity)
        {
            _profissaoService.Remover(entity);
        }
    }
}
