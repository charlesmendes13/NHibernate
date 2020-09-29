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
    public class EntitiesToViewModel : Profile
    {
        public EntitiesToViewModel()
        {
            CreateMap<Aluno, AlunoViewModel>();                
        }
    }
}
