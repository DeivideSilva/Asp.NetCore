using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademiaFit.Models
{
    public class Cliente
    {
        [Key()]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo nome é obrigatório!")]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage ="Campo e-mail é obrigatório!")]
        public string Email { get; set; }

        
        [Display(Name ="Data de nascimento")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage ="Campo data de nascimento é obrigatório!")]
        public DateTime DataAniversario { get; set; }

        
        [Display(Name ="Data de inscrição")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage ="Campo data de inscrição é obrigatório!")]
        public DateTime DataInscricao { get; set; }

        [ForeignKey("Plano")] 
        [Display(Name ="Plano")]
        public int PlanoId { get; set; }
        public virtual Plano Plano { get; set; }
    }
}
