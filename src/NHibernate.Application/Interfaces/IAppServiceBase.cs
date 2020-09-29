using System.Collections.Generic;

namespace NHibernate.Application.Interfaces
{
    public interface IAppServiceBase<T> where T : class
    {
        IEnumerable<T> Get();
        T GetById(object id);
        void Insert(T entidade);
        void Update(T entidade);
        void Delete(T entidade);
        void Dispose();
    }
}
