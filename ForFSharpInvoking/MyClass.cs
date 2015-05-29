using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForFSharpInvoking
{
    public interface IMyInterface
    {
        void MyFunction();
        int MyProperty { get; set; }
    }

    public class MyClass
    {
        public void MyFunction(IMyInterface myObj)
        {
            //
        }      
    }
}
