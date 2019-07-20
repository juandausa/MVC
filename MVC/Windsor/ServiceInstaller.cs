using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Reflection;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace MVC.Windsor
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly().BasedOn<IController>().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().BasedOn<IHttpController>().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().BasedOn<FilterAttribute>().LifestyleTransient());
        }

        public void InstallFromAssembly(IWindsorContainer container, IConfigurationStore store, Assembly assembly)
        {
            container.Register(Classes.FromAssembly(assembly).BasedOn<IController>().LifestyleTransient());
            container.Register(Classes.FromAssembly(assembly).BasedOn<IHttpController>().LifestyleTransient());
            container.Register(Classes.FromAssembly(assembly).BasedOn<FilterAttribute>().LifestyleTransient());
            container.Register(Component.For<IActionInvoker>().ImplementedBy<WindsorActionInvoker>().DependsOn(Dependency.OnValue("container", container)).LifestyleTransient().IsDefault());
            container.Install(Castle.Windsor.Installer.Configuration.FromAppConfig());
        }
    }
}