using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Usuarios
{
    public class ValidaCampoViewModel
    {
        public IEnumerable<string>Erros { get; private set; }

        public ValidaCampoViewModel(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
