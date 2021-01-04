using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        
        [Display(Name ="Data de nascimento")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataAniversario { get; set; }

        
        [Display(Name ="Data de inscrição")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInscricao { get; set; }

        [ForeignKey("Plano")] 
        public int PlanoId { get; set; }
        public virtual Plano Plano { get; set; }
    }
}
