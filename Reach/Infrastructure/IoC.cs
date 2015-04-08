using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.Windsor;

namespace Reach.Infrastructure
{
    public static class IoC
    {
        static readonly object lockObj = new object();

        static IWindsorContainer container = new WindsorContainer();
        public static IWindsorContainer Container
        {
            get
            {
                return container;
            }
            set
            {
                lock (lockObj)
                {
                    container = value;
                }
            }
        }

        public static T Resolve<T>()
        {
            return container.Resolve<T>();
        }

        public static object Resolve(Type t)
        {
            return container.Resolve(t);
        }
    }
}