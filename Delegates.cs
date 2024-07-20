using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public delegate int DelegateMethod(int dVar1, int dVar2);
    public class CallingClass
    {
        public int CallingMethod(int cVar1, int cVar2)
        {
            return cVar1 + cVar2;
        }
    }
    public class Delegates
    {
        public void Main()
        {
            CallingClass cc=new CallingClass();
            DelegateMethod del = new DelegateMethod(cc.CallingMethod);
            Console.WriteLine(del(2, 3));

        }
    }
}
