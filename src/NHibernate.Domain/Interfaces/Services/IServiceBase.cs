using System.Collections.Generic;

namespace NHibernate.Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        IEnumerable<T> Get();
        T GetById(object id);
        void Insert(T entidade);
        void Update(T entidade);
        void Delete(T entidade);
        void Dispose();
    }
}
