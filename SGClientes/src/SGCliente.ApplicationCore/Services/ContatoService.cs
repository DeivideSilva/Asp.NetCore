using SGCliente.ApplicationCore.Entity;
using SGCliente.ApplicationCore.Interfaces.Repository;
using SGCliente.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGCliente.ApplicationCore.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoService _contatoService;
        public ContatoService(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }
        public Contato Adicionar(Contato entity)
        {
            return _contatoService.Adicionar(entity);
        }

        public void Atualizar(Contato entity)
        {
            _contatoService.Atualizar(entity);
        }

        public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado)
        {
            return _contatoService.Buscar(predicado);
        }

        public Contato ObterPorId(int id)
        {
            return _contatoService.ObterPorId(id);
        }

        public IEnumerable<Contato> ObterTodos()
        {
            return _contatoService.ObterTodos();
        }

        public void Remover(Contato entity)
        {
            _contatoService.Remover(entity);
        }
    }
}
