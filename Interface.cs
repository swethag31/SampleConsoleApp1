using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public interface ISample
    {
        void Imethod1();
        //void Imethod2();
    }
    class Derived3 : ISample
    {
        public void Imethod1() 
        {
            Console.WriteLine("Interface method in derived class");
        }
    }

    internal class Interface
    {
        public void Do()
        {
            Derived3 Iobj = new Derived3();
            Iobj.Imethod1();
        }
    }
}
