using Interfaces.Servicios;
using System.Web.Http;

namespace MVC.Controllers.API
{
    public class HelloController : ApiController
    {
        public IGreetingService GreetingSevice { get; set; }

        public HelloController()
        { }

        public HelloController(IGreetingService greetingService) : this()
        {
            this.GreetingSevice = greetingService;
        }

        // GET: api/Hello
        public string Get()
        {
            return this.GreetingSevice.CreateGreeting("Visitor");
        }
    }
}
