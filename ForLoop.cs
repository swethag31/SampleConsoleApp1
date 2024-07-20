using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public class ForLoop
    {
        public int Do(int loopVar1)
        {
            int loopVar2 = 1;
            for (int i = 1; i <= loopVar1; i++)
            {
                loopVar2 += i;
                
            }
            return loopVar2;
        }
    }
}
