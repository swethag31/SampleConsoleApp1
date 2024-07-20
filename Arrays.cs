using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public class Arrays
    {
        public char[] Do()
        {
            //string[] arr = new string[3];
            //Console.WriteLine($"enter {arr.Length} strings");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Console.ReadLine();
            //}
            //foreach (string i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Char Array");
            char[] arr2 ={'a','b','c','d','e'};
            foreach(char i in arr2)
            {
                Console.Write(i+"-");
            }
            Console.WriteLine();
            
            //Console.WriteLine("Integer Array");
            //int[] arr3 = new int[4];
            //int j= 0;
            //while (j < arr3.Length)
            //{
            //    Console.Write($"{j} - ");
            //    arr3[j] = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //    j++;
            //}
            //Array.Sort(arr3);
            //Console.WriteLine("Sorted Array");
            //foreach(int i in arr3)
            //{
            //    Console.WriteLine(i);
            //}

            return arr2;
        }
    }
}
