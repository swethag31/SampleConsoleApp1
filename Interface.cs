using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public interface ISample
    {
        void Imethod();
    }
    class Derived3 : ISample
    {
        public void Imethod() 
        {
            Console.WriteLine("Interface method in derived class");
        }
    }
    internal class Interface
    {
        public void Do()
        {
            Derived3 Iobj = new Derived3();
            Iobj.Imethod();
        }
    }
}
