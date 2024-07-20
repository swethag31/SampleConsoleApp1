using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    abstract class AbstractClass1
    {
        public abstract string AbsMethod1(string absvar1);

        public  virtual void Method2()
        {
            Console.WriteLine("This is not abstract method");
        }
    }

    class Abs2 : AbstractClass1
    {
        public override string AbsMethod1(string absvar1)
        {
            return absvar1 + ". This is abstract method." ;
        }
    }
    public class Abstraction
    {
        public string Do(string absvar2)
        {
            Abs2 abstractObj = new Abs2();
            abstractObj.Method2();
            return abstractObj.AbsMethod1(absvar2);
        }
    }

  
}
