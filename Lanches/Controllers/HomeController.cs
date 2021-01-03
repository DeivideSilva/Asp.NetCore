using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lanches.Models;
using Lanches.Repositories;
using Lanches.ViewModels;

namespace Lanches.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ILancheRepository _lancheRepository;
        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel {

                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };
            return View(homeViewModel);
            
        }

        public ViewResult AccessDenied()
        {
            return View();
        }





    } 
}
