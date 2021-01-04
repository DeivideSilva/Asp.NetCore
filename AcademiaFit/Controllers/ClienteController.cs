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

        [HttpPost]
        public IActionResult Salvar(Cliente Cliente)
        {
            
            _context.Clientes.Add(Cliente);
            _context.SaveChanges();

            return RedirectToAction("Index",Cliente);
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

            return View("Salvar", viewModel);
        }

       
    }
}
