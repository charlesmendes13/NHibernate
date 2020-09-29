using SimpleInjector;
using NHibernate.Application.Interfaces;
using NHibernate.Application.Services;
using NHibernate.Domain.Interfaces.Repository;
using NHibernate.Domain.Interfaces.Services;
using NHibernate.Domain.Services;
using NHibernate.Infrastructure.Data.Repository;

namespace NHibernate.Infrastructure.IoC
{
    public class InjectorDependency
    {
        public static Container RegisterDependencies()
        {
            var container = new Container();
            container.Options.ResolveUnregisteredConcreteTypes = true;

            // Application

            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            container.Register<IAlunoAppService, AlunoAppService>();

            // Domain

            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<IAlunoService, AlunoService>();

            // Infrastructure

            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.Register<IAlunoRepository, AlunoRepository>();

            return container;
        }
    }
}
