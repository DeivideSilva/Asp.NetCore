using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Usuarios
{
    public class LoginViewModelInPut
    {
        [Required(ErrorMessage="O login é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage="O campo senha é obrigatório")]
        public string Senha { get; set; }
    }
}
