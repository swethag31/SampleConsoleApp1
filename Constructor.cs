using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class Constructor
    {
        
        public Constructor(string passedMessage)
        {
            Console.WriteLine( $"Constructor Executed : {passedMessage}");
        }

        public void Do()
        {
            Console.WriteLine("Main class message.");
        }
    }
}
