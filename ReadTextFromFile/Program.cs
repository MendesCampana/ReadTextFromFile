using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReadTextFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            TestParcer Parcer = new TestParcer();
            Parcer.ParceFile(@"d:\test.txt");
            Parcer.SaveParceResult("Result");        
          
            Console.ReadKey();
        }
    }
}
