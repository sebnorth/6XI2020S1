using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 + 2 + .. + 10 za pomocą pętli for

            int naszaSuma = 0;

            for (int i = 1; i < 11; i++)
            {
                naszaSuma = naszaSuma + i;
            }

            Console.WriteLine(naszaSuma);

            Console.ReadKey();
        }
    }
}
