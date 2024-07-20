using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public class Method
    {
        public string Method1(int passedArgument)
        {
            return $"passed argument is {passedArgument}";
        }
        public string Do(int methodVar1)
        {
            
            string methodVar2=Method1(methodVar1);
            return methodVar2;

        }
    }
}
