using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class Tuples
    {
        public void Main()
        {
            var tuple1 = ("hi", 1, 7.7);
            Console.WriteLine(tuple1.Item1);

            var tuple2 = (name: "Swetha", id: 1, age: 21);
            Console.WriteLine(tuple2.name);
            var (a, b, c) = tuple2;
            Console.WriteLine(b);

            string text = "Anu,1,20";
            var tuple3 = TupleMethod(text);
            Console.WriteLine(tuple3.name);
            Console.WriteLine(tuple3.Item2);
        }

        static (string name, int id, int age) TupleMethod(string text)
        {
            string[] parts = text.Split(',');
            string a = parts[0];
            int b = int.Parse(parts[1]);
            int c = int.Parse(parts[2]);
            return (a, b, c);
        }
    }
}
