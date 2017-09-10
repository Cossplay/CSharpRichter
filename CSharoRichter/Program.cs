using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRichter
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 254;
            byte b2 = 254;
            byte res = ((byte)(b + b2));
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
