using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public class Constructor1
    {
        public Constructor1(string passedMessage)
        {
            Console.WriteLine($"Constructor Executed : {passedMessage}");
        }
        public void ConsMethod(int var1, int var2)
        {
            Console.WriteLine(var1 + var2);
        }
        ~Constructor1(){
            Console.WriteLine("destructor");
        }

    }


    internal class Constructor
    {
        public void Do()
        {
            Console.WriteLine("Main class message.");
            Constructor1 con = new Constructor1("Hello");
            con.ConsMethod(2,3);
            con = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
