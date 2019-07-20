using Castle.Windsor;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC.Windsor
{
    public class WindsorControllerFactory : DefaultControllerFactory
    {
        private readonly IWindsorContainer _Container;

        public WindsorControllerFactory(IWindsorContainer container)
        {
            _Container = container;
        }

        public override void ReleaseController(IController controller)
        {
            _Container.Release(controller);
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                throw new HttpException(404, string.Format("The controller for path '{0}' could not be found.", requestContext.HttpContext.Request.Path));
            }

            Controller controller = (Controller)_Container.Resolve(controllerType);

            // new code
            if (controller != null)
            {
                // Don't worry about this yet. This will help us inject dependencies into our action filters later
                controller.ActionInvoker = _Container.Resolve<IActionInvoker>();
            }

            return controller;
        }
    }
}