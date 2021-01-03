using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lanches.Models;
using Lanches.Repositories;
using Lanches.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lanches.Controllers
{
    public class LancheController : Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ICategoriaRepository categoriaRepository, ILancheRepository lancheRepository)
        {
            _categoriaRepository = categoriaRepository;
            _lancheRepository = lancheRepository;
        }

        public IActionResult List(string categoria)
        {
            //string _categoria = categoria;
            IEnumerable<Lanche> lanches = null;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoria = "Todos os lanches";
            }
            else
            {
                //if (string.Equals("Normal", _categoria, StringComparison.OrdinalIgnoreCase))
                //{
                //    lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Normal")).OrderBy(l => l.Nome);
                //}
                //else
                //{
                //    lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Natural")).OrderBy(l => l.Nome);
                //}

                /* Codigo otimizado para poder incluir outras categorias*/
                lanches = _lancheRepository.Lanches.Where(p => p.Categoria.CategoriaNome.Equals(categoria)).OrderBy(p => p.Nome);
                categoriaAtual = categoria;
            }

            var lancheListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };
           return View(lancheListViewModel);
        }

        public IActionResult Details(int lancheId)
        {
            var lanche = _lancheRepository.Lanches.FirstOrDefault(l => l.LancheId == l.LancheId);

            if(lanche == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(lanche);
        }

        public IActionResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Lanche> lanches;
            string _categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
            }
            else
            {
                lanches = _lancheRepository.Lanches.Where(l => l.Nome.ToLower().Contains(_searchString.ToLower()));
            }
            return View("~/Views/Lanche/List.cshtml", new LancheListViewModel { Lanches = lanches, CategoriaAtual = "Todos os lanches" });
        }
    }
}
