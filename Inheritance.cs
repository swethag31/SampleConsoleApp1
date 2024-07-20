using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    class Base1
    {
        public string BaseMthod1()
        {
            return "hi hi from parent";
        }
    }

    class Derived : Base1
    {
        public string DerivedMethod1()
        {
            return "Hello Hello from child";
        }
    }
    public class Inheritance
    {
        public string Do()
        {
            Derived inheritanceobj = new Derived();
            string inhertVar1=inheritanceobj.BaseMthod1();
            string inheritVar2= inheritanceobj.DerivedMethod1();
            return inheritVar2;
        }
    }
}
