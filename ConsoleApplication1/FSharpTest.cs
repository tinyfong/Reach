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
            var myEventClass2 = new File5.MyClassWithEvent();
            myEventClass2.Event += MyHandler2;
            myEventClass2.RaiseEvent("Hello world");


        }

        private void MyHandler2(object sender, Tuple<File5.MyClassWithEvent, string> args)
        {
         
        }

      

       

     
    }
}
