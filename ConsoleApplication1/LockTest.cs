using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class LockTest
    {
        static readonly object locker = new object();


        static bool done;
        public void Run()
        {
            new Thread(Go).Start();
            Go();
        }

        public static void Go()
        {
            lock (locker)
            {
                if (!done)
                {
                    Console.WriteLine("Done"); done = true;
                }
            }
        }

    }

    class ThreadTest
    {
        static bool done;

        // Note that Go is now an instance method

    }
}
