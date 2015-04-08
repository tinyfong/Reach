using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reach.Infrastructure
{
    public class WindsorRegistrar
    {
        public static void RegisterSingleton<TInterface, TImplement>()
            where TImplement : TInterface
            where TInterface : class
        {
            IoC.Container.Register(Component.For<TInterface>().ImplementedBy<TImplement>().LifeStyle.Singleton);
        }

        public static void Register<TInterface, TImplement>()
            where TImplement : TInterface
            where TInterface : class
        {
            IoC.Container.Register(Component.For<TInterface>().ImplementedBy<TImplement>().LifeStyle.PerWebRequest);
        }

        public static void registerAllFromAssemblies(string s)
        {
            IoC.Container.Register(Classes.FromAssemblyNamed(s).Pick().WithService.DefaultInterfaces().LifestylePerWebRequest());
        }
    }
}