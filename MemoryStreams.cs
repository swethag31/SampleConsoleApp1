using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class MemoryStreams
    {
        public void MSMethod()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                string txt = "hello";
                byte[] buffer = Encoding.UTF8.GetBytes(txt);
                ms.Write(buffer,0,buffer.Length);
                ms.Position = 0;

                byte[] readBuffer = new byte[ms.Length];
                ms.Read(readBuffer, 0, readBuffer.Length);
                string text2=Encoding.UTF8.GetString(readBuffer);
                Console.WriteLine(text2);
            }
        }
    }
}
