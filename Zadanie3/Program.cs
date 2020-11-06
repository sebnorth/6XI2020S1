using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 + 2 + .. + n za pomocą pętli for

            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            int naszaSuma = 0;

            for (int i = 1; i <= n; i++)
            {
                naszaSuma = naszaSuma + i;
            }

            Console.WriteLine(naszaSuma);

            Console.ReadKey();
        }
    }
}
