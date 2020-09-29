using FluentNHibernate.Mapping;
using NHibernate.Domain.Entities;

namespace NHibernate.Infrastructure.Data.Mapping
{
    public class AlunoMap : ClassMap<Aluno>
    {
        public AlunoMap()
        {
            Table("Alunos");
            Id(x => x.Id).Column("Id").GeneratedBy.Custom("trigger-identity"); ;
            Map(x => x.Nome).Column("Nome"); ;
            Map(x => x.Email).Column("Email"); ;
            Map(x => x.Curso).Column("Curso"); ;
            Map(x => x.Sexo).Column("Sexo"); ;            
        }
    }
}
