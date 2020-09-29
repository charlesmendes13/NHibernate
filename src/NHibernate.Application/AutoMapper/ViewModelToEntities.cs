using AutoMapper;
using NHibernate.Application.Enum;
using NHibernate.Application.ViewModel;
using NHibernate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.Application.AutoMapper
{
    public class ViewModelToEntities : Profile
    {
        public ViewModelToEntities()
        {
            CreateMap<AlunoViewModel, Aluno>()
                .AfterMap((v, e) => e.Sexo = System.Enum.GetName(typeof(Sexo), v.Sexo));
        }
    }
}
