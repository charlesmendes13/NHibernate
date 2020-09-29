using NHibernate.Domain.Interfaces.Services;
using NHibernate.Domain.Interfaces.Repository;
using System.Collections.Generic;

namespace NHibernate.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }        

        public IEnumerable<T> Get()
        {
            return _repository.Get();
        }

        public T GetById(object id)
        {
            return _repository.GetById(id);
        }

        public void Insert(T entidade)
        {
            _repository.Insert(entidade);
        }

        public void Update(T entidade)
        {
            _repository.Update(entidade);
        }

        public void Delete(T entidade)
        {
            _repository.Delete(entidade);
        }        

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
