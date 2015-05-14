using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForFSharpInvoking
{
    public class Class1
    {
        public void MyMethod(int a = 11)
        {
            Console.WriteLine("a = {0}", a);
        }
    }
}
