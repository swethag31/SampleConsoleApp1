using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class Threads
    {
        public void Main()
        {
            Thread t1 = new Thread(Thread1);
            t1.Start("message to thread");
            Console.WriteLine("this is main thread");
            t1.Join();
            Console.WriteLine("Process over");
        }

        public void Thread1(object parameter1)
        {
            Console.WriteLine("Thread is started");
            string text=(string)parameter1;
            Console.WriteLine(text);

        }
    }
}
