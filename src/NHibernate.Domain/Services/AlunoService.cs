using NHibernate.Domain.Interfaces.Services;
using NHibernate.Domain.Interfaces.Repository;
using NHibernate.Domain.Entities;

namespace NHibernate.Domain.Services
{
    public class AlunoService : ServiceBase<Aluno>, IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
            : base(alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
    }
}
