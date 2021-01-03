using Lanches.Models;
using System.Collections.Generic;

namespace Lanches.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual{ get; set; }
    }
}
