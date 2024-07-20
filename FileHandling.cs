using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class FileHandling
    {
        public void HandlingMethod()
        {
            string path = @"C:\Users\320262235\OneDrive - Philips\Desktop\text.txt";
            if (File.Exists(path))
            {
                string[] lines = { "hii", "hello", "how are you" };
                File.WriteAllLines(path, lines);
                string[] rLines = File.ReadAllLines(path);
                foreach (string line in rLines)
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine("break");
                string wLine = "Hello \nGood morning";
                File.WriteAllText(path, wLine);
                string txt = File.ReadAllText(path);
                Console.WriteLine(txt);
            }
            //File.Delete(path);
        }
    }
}
