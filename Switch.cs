using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public class Switch
    {
        public string Do(char switchVar1)
        {
            
            switch (switchVar1)
            {
                case 'a':
                    return "Apple";
                    break;
                case 'b':
                    return "Ball";
                    break;
                case 'c':
                    return "Cat"; 
                    break;
                case 'd':
                    return "Dog";
                    break;
                case 'e':
                    return "Elephant";
                    break;
                case 'f':
                    return "Frog";
                    break;
                case 'g':
                    return "Goat"; 
                    break;
                case 'h':
                    return "Hen";
                    break;
                default:
                    return "alphabet not between a to h";
                    break;
            }
        }
    }
}
