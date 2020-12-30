using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaFit.Models
{
    public class Cliente
    {
        [Key()]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(20)]
        public DateTime DataAniversario { get; set; }

        [StringLength(20)]
        public DateTime DataInscricao { get; set; }

        [ForeignKey("Plano")] 
        public int PlanoId { get; set; }
        public virtual Plano Plano { get; set; }
    }
}
