using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace ConsoleApplication1
{
    public class IoCTest
    {
        IWindsorContainer container = new WindsorContainer();

        public void Run()
        {
            container.Register(Component.For<SomeClass>());
            container.Register(Component.For<IDependency1>().ImplementedBy<D1>());
            container.Register(Component.For<IDependency2>().ImplementedBy<D2>());

            var resolve = container.Resolve<SomeClass>();
            resolve.Run();
        }
    }

    public class SomeClass
    {
        private IDependency1 id1;
        private IDependency2 id2;

        public SomeClass(IDependency1 id1, IDependency2 id2)
        {
            this.id1 = id1;
            this.id2 = id2;
        }

        //public SomeClass()
        //    : this(new D1(), new D2())
        //{

        //}

        public void Run()
        {
            id1.SomeObject = "Hello";
            id2.SomeOtherObject = "World";
        }
    }

    public interface IDependency1
    {
        object SomeObject { get; set; }
    }
    public interface IDependency2
    {
        object SomeOtherObject { get; set; }
    }

    public class D1 : IDependency1
    {
        public object SomeObject
        {
            get;
            set;
        }
    }

    public class D2 : IDependency2
    {
        public object SomeOtherObject
        {
            get;
            set;
        }
    }
}
