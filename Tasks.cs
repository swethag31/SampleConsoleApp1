using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class Tasks
    {
        public async Task Main()
        {
            Task t = Task.Run(async ()=>
            {
                Console.WriteLine("Task Started");
                await TaskMethod();
                Console.WriteLine("Await over");
            });
            t.Wait();
            Console.WriteLine("Other process");

        }

        public async Task TaskMethod()
        {
            Console.WriteLine("task2 started");
            await Task.Delay(5000);
            Console.WriteLine("Task2 Completed");
        }
    }
}
