using System.Configuration;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Infrastructure.Data.Mapping;
using NHibernate.Tool.hbm2ddl;

namespace NHibernate.Infrastructure.Data.Factory
{
    public class SessionFactory
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

        public static ISession OpenSession()
        {
            var sessionFactory = Fluently.Configure()
               .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
                   .Mappings(m =>
                       m.FluentMappings.AddFromAssemblyOf<AlunoMap>()
                   )                   
                   .BuildSessionFactory();

            return sessionFactory.OpenSession();          
        }
    }
}
