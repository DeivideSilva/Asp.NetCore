using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademiaFit.Models
{
    public class Plano
    {
        [Key()]
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public float Valor { get; set; }
    }


}
