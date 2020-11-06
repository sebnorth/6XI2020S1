using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {

            // program oblicza sumę: 1 + 2 + 3 + ... + 10
            int i = 1;
            int s = 0;

            while (i <= 10)
            {
                Console.WriteLine("i: {0}, s: {1}", i, s);
                s = s + i;
                i = i + 1;
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
