using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NHibernate.Infrastructure.IoC;
using NHibernate.Application.AutoMapper;

namespace NHibernate.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // IoC
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(InjectorDependency.RegisterDependencies()));

            // AutoMapper
            AutoMapperConfig.RegisterMappings();
        }
    }
}
