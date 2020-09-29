using FluentNHibernate.Mapping;
using NHibernate.Domain.Entities;

namespace NHibernate.Infrastructure.Mapping
{
    class AlunoMap : ClassMap<Aluno>
    {
        public AlunoMap()
        {
            Table("Alunos");

            Id(x => x.Id);
            Map(x => x.Nome);
            Map(x => x.Email);
            Map(x => x.Curso);
            Map(x => x.Sexo);            
        }
    }
}
