using Castle.Windsor;

namespace Log.Log4net
{
    public class ServiceInstaller
    {
        public static void Install(IWindsorContainer container)
        {
            container.Kernel.Resolver.AddSubResolver(new LoggerSubDependencyResolver());
        }
    }
}
