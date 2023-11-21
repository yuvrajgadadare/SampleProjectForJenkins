using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjectForJenkins
{
    internal class Program
    {
        public void Addition()
        {
            int x, y, z;
            int a = 10, b = 20, c;
            c = a + b;
            Console.WriteLine("Addition=" + c);
        }
        static void Main()
        {
            Program p = new Program ();
            p.Addition();
            Console.ReadLine();
        }
    }
}
