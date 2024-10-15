using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmBasicThread
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i <= 5; i++)
            {
                // Get the current thread object
                Thread currentThread = Thread.CurrentThread;

                // Output the name of the thread and loop count
                Console.WriteLine("Name of Thread: " + currentThread.Name + " Process = " + i);

                // Sleep for 1.5 seconds (1500 ms)
                Thread.Sleep(1500);
            }
        }
    }
}

