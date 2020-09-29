using System.Configuration;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Domain.Entities;
using NHibernate.Tool.hbm2ddl;

namespace NHibernate.Infrastructure.Data.Factory
{
    public class SessionFactory
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

        public static ISession OpenSession()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(connectionString)
                        .ShowSql())
                            .Mappings(m => 
                                    m.FluentMappings.AddFromAssemblyOf<Aluno>()
                                )
                                .ExposeConfiguration(cfg => 
                                    new SchemaExport(cfg).Create(false, false))
                                .BuildSessionFactory();

            return sessionFactory.OpenSession();          
        }
    }
}
