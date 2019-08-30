namespace Servicios.Impl
{
    public class GreetingService : IGreetingService
    {
        public string CreateGreeting(string name)
        {
            return string.Format("Hello {0}", name);
        }
    }
}
