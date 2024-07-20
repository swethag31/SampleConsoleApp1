using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public static class Extension
    {
        public static string ExArrayMethod(this char[] arr)
        {
            Array.Reverse(arr);
            string str = new string(arr);
            return str;
        }


    }
}
