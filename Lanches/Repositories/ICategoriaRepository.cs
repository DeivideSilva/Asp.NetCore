using Lanches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lanches.Repositories
{
   public interface ICategoriaRepository 
    {
        IEnumerable<Categoria>Categorias { get; }
    }
}
