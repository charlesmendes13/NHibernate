using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Domain.Interfaces.Repository;
using NHibernate.Infrastructure.Data.Factory;

namespace NHibernate.Infrastructure.Data.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {                
        public IEnumerable<T> Get()
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                try
                {
                    return (from c in session.Query<T>() select c).ToList();
                }
                catch (Exception ex)
                {

                    throw;
                }               
            }
        }

        public T GetById(object id)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                return session.Get<T>(id);
            }
        }

        public void Insert(T entidade)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidade);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }

                        throw new Exception("Erro ao inserir: " + ex.Message);
                    }
                }
            }
        }

        public void Update(T entidade)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }

                        throw new Exception("Erro ao Alterar: " + ex.Message);
                    }
                }
            }
        }

        public void Delete(T entidade)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }

                        throw new Exception("Erro ao Excluir: " + ex.Message);
                    }
                }
            }
        }

        #region

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        session.Dispose();
                    }
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
