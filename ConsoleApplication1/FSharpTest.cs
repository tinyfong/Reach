using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassNamespace;
using Microsoft.FSharp.Core;

namespace ConsoleApplication1
{
    class FSharpTest
    {
        internal void Run()
        {
            var myValue = new MyClass();
            myValue.PrintValue(FSharpOption<int>.None);
            myValue.PrintValue(new FSharpOption<int>(1));

            myValue.PrintValue2(2);
            myValue.PrintValue2();
            myValue.PrintValue2(3, "three");

        }

     
    }
}
