using Interfaces.Servicios;
using log4net;
using System.Web.Http;

namespace MVC.Controllers.API
{
    public class HelloController : ApiController
    {
        public IGreetingService GreetingSevice { get; set; }
        public ILog Log { get; set; }

        public HelloController()
        { }

        public HelloController(IGreetingService greetingService, ILog log) : this()
        {
            this.GreetingSevice = greetingService;
            this.Log = log;
        }

        // GET: api/Hello
        public string Get()
        {
            Log.Debug("Hello visitor");
            return this.GreetingSevice.CreateGreeting("Visitor");
        }
    }
}
