using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.Windsor;
using System.Reflection;
using Castle.MicroKernel.Registration;

namespace Reach
{
    public class WindsorControllerFactory : DefaultControllerFactory
    {
        readonly IWindsorContainer container;

        public WindsorControllerFactory(IWindsorContainer container)
        {
            this.container = container;
            var controllerTypes =
              from t in Assembly.GetExecutingAssembly().GetTypes()
              where typeof(IController).IsAssignableFrom(t)
              select t;
            foreach (var t in controllerTypes)
            {
                container.Register(Component.For(t).LifeStyle.Transient);
            }

        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                return null;
            }

            return (IController)container.Resolve(controllerType);
        }
    }
}