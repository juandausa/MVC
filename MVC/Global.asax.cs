using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using log4net;
using MVC.Windsor;
using System;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC
{
    public class MvcApplication : System.Web.HttpApplication, IDisposable
    {
        protected IWindsorContainer Container { get; set; }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfigureContainer();
        }

        public override void Dispose()
        {
            if (Container != null)
            {
                Container.Dispose();
            }

            Container = null;
            base.Dispose();
        }

        private void ConfigureContainer()
        {
            Container = new WindsorContainer();
            Container.Install(FromAssembly.This());
            Container.Kernel.Resolver.AddSubResolver(new CollectionResolver(Container.Kernel, true));
            DependencyResolver.SetResolver(new WindsorDependencyResolver(Container));
            Log.Log4net.ServiceInstaller.Install(Container);
            ILog logger = LogManager.GetLogger(this.GetType());
            logger.Debug("Application started.");
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(Container));
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new WindsorAPIControllerFactory(Container));
        }
    }
}
