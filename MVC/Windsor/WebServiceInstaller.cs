using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Reflection;

namespace MVC.Windsor
{
    public class WebServiceInstaller : ServiceInstaller, IWindsorInstaller
    {
        public new void Install(IWindsorContainer container, IConfigurationStore store)
        {
            InstallFromAssembly(container, store, Assembly.GetExecutingAssembly());
        }
    }
}