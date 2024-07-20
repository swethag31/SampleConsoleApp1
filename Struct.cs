using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public struct StructExample
    {
        public int structVar1;
        public int structVar2;

        public void StructMethod()
        {
            Console.WriteLine($"Struct variables are added {structVar1 + structVar2}");
        }
    }
    internal class Struct
    {
        public void Do()
        {
            StructExample structObj = new StructExample();
            structObj.structVar1 = 10;
            structObj.structVar2 = 20;
            structObj.StructMethod();
            StructExample structObj2 = structObj;
            structObj2.structVar1 = 30;
            structObj2.StructMethod();
        }

    }
}
