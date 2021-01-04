using System.Collections.Generic;

namespace AcademiaFit.Models.ViewModels
{
    public class PlanoUsuarioViewModel
    {
        public Cliente Cliente { get; set; }
        public List <Plano> Planos { get; set; }
    }
}
