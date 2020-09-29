using NHibernate.Application.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.Application.ViewModel
{
    public class AlunoViewModel
    {
        public int? Id { get; set; }

        [Required]
        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome válido")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Curso válido")]
        [Display(Name = "Curso")]
        public string Curso { get; set; }

        [Required]
        [Display(Name = "Sexo")]
        public Sexo Sexo { get; set; }
    }
}
