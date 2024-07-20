using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    class Base2
    {
        public virtual string BaseMethod2()
        {
            return "Hi from parent1";
        }
    }

    class Derived1 : Base2
    {
        public override string BaseMethod2()
        {
            return "Hello from override child1 ";
        }
    }

    class Derived2 : Base2
    {
        public override string BaseMethod2()
        {
            return "Override Child class2";
        }
    }

    public class Polymorphism
    {
        public string Do()
        {
            Base2 polymorphismVar1 = new Base2();
            Derived1 polymorphismVar2 = new Derived1();
            Derived2 polymorphismVar3 = new Derived2();
            Console.WriteLine( polymorphismVar1.BaseMethod2());
            Console.WriteLine( polymorphismVar2.BaseMethod2());
            string polymorphismvar4= polymorphismVar3.BaseMethod2();
            return polymorphismvar4;

        }
    }
}
