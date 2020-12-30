using AcademiaFit.Data;
using AcademiaFit.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaFit.Controllers
{
    public class PlanoController : Controller
    {
        private readonly ContextoDB _contexto;
        public PlanoController(ContextoDB contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            List<Plano> planos = _contexto.Planos.ToList();

            return View(planos);
        }
    }
}
