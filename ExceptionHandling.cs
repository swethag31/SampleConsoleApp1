using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class ExceptionHandling
    {
        public void Do()
        {
            int[] arr4 = { 1, 0, 3 };
            try
            {
                
                Console.WriteLine(arr4[3]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Array index starts from 0");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Exception is done");
            }

            try
            {
                if (arr4[0] != 0)
                {
                    throw new ArithmeticException("first element is not 0");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                int zeroDivisible = 10 / arr4[1];
            }
            catch(Exception e)
            {
                Console.WriteLine("Zero Divisible Error");
                Console.WriteLine($"Error message is {e}");
                
            }

            
            

            }
    }
}
