using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omu.ValueInjecter;

namespace ConsoleApplication1
{
    public class ValueInjecterTest
    {
        public void Run()
        {
            A a = new A();
            a.Id = 1;
            a.Name = "a";
            a.AA = "AA";
            B b = new B();

            b.InjectFrom(a).InjectFrom<Reverse>(a);
        }
    }

    class A
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AA { get; set; }
    }

    class B
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BB { get; set; }
    }

    class Reverse : ConventionInjection
    {
        protected override bool Match(ConventionInfo c)
        {
            return c.SourceProp.Name == "AA" && c.TargetProp.Name == "BB";
        }
    }
}
