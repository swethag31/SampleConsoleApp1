using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public class EnClass
    {
        public int enVar { get; set; }

        //public int ReturnEnVar
        //{
        //    set
        //    {
        //        enVar=value;
        //    }
        //    get{
        //        return enVar;
        //    }
        //}

        
    }

    public class EnClass2
    {
        private int enVar2;

        public int ReturnEnVar2
        {
            private get
            {
                return enVar2;
            }
            set
            {
                enVar2= value;
            }
        }

        public int GetMethod()
        {
            return ReturnEnVar2;
        }
    }
    internal class Encapsulation
    {
        public void EnMain()
        {
            EnClass enObj = new EnClass();
            enObj.enVar = 22;
            Console.WriteLine(enObj.enVar);
            EnClass2 enObj2 = new EnClass2();
            enObj2.ReturnEnVar2 = 33;
            Console.WriteLine(enObj2.GetMethod());



        }
    }
}
