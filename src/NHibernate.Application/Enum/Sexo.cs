using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.Application.Enum
{
    public enum Sexo
    {
        [Display(Name = "Masculino")]
        M = 'M',

        [Display(Name = "Feminino")]
        F = 'F'
    }
}
