using System.Collections.Generic;
using NHibernate.Application.Interfaces;
using NHibernate.Domain.Interfaces.Services;

namespace NHibernate.Application.Services
{
    public class AppServiceBase<T> : IAppServiceBase<T> where T : class
    {
        private readonly IServiceBase<T> _service;

        public AppServiceBase(IServiceBase<T> service)
        {
            _service = service;
        }  

        public IEnumerable<T> Get()
        {
            return _service.Get();
        }

        public T GetById(object id)
        {
            return _service.GetById(id);
        }

        public void Insert(T entidade)
        {
            _service.Insert(entidade);
        }

        public void Update(T entidade)
        {
            _service.Update(entidade);
        }

        public void Delete(T entidade)
        {
            _service.Delete(entidade);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}
