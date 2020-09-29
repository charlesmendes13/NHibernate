using NHibernate.Application.Interfaces;
using NHibernate.Domain.Interfaces.Services;
using NHibernate.Domain.Entities;

namespace NHibernate.Application.Services
{
    public class AlunoAppService : AppServiceBase<Aluno>, IAlunoAppService
    {
        private readonly IAlunoService _alunoService;

        public AlunoAppService(IAlunoService alunoService)
            : base(alunoService)
        {
            _alunoService = alunoService;
        }
    }
}
