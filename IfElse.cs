using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace SampleConsoleApp
{
    public  class IfElse
    {
        public string Do(int ifElseVar1)
        {
            if (ifElseVar1 > 0 && ifElseVar1 <= 100)
            {
                return $"{ifElseVar1} is between 1 to 100";
            }
            else
            {
                return $"{ifElseVar1} is not between 1 to 100";
            }
        }
        
    }
}
