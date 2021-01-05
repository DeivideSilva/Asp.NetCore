using AcademiaFit.Data;
using AcademiaFit.Models;
using AcademiaFit.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AcademiaFit.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ContextoDB _context;
        public ClienteController(ContextoDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Cliente> clientes = _context.Clientes.Include(c => c.Plano).ToList();
            return View(clientes);
        }

        public ActionResult Novo()
        {
            List<Plano> planos = new List<Plano>();
            planos = _context.Planos.ToList();

            PlanoUsuarioViewModel viewModel = new PlanoUsuarioViewModel
            {
                Planos = planos,
                

            };

            ViewBag.Acao = "Novo Usuário";

            return View("Novo", viewModel);
        }

        [HttpPost]
        public IActionResult Salvar(Cliente cliente)
        {
            if(cliente.Id == 0)
            {
                _context.Clientes.Add(cliente);
            }
            else
            {
                var clienteInDb = _context.Clientes.Single(s => s.Id == cliente.Id);

                clienteInDb.Nome = cliente.Nome;
                clienteInDb.Email = cliente.Email;
                clienteInDb.DataAniversario = cliente.DataAniversario;
                clienteInDb.DataInscricao = cliente.DataInscricao;
            }
            
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return RedirectToAction("Index","cliente");
        }

        public IActionResult Edit (int id)
        {
            var cliente = _context.Clientes.Find(id);

            if (cliente == null)
                return NotFound();

            List<Plano> planos = new List<Plano>();
            planos = _context.Planos.ToList();

            var viewModel = new PlanoUsuarioViewModel
            {
                Planos = planos,
                Cliente = cliente
            };

            ViewBag.Acao = "Editar Usuário";

            return View("Novo", viewModel);
        }

       
    }
}
