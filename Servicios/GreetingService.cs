using Interfaces.Servicios;

namespace Servicios
{
    public class GreetingService : IGreetingService
    {
        public string CreateGreeting(string name)
        {
            return string.Format("Hello {0}", name);
        }
    }
}
