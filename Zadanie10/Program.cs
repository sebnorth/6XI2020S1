using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość boku trójkąta: ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 1; j <= n; j++) // j - numer wiersza
            {
                for (int i = 1; i <= j; i++) // i - która gwiazdka w danym wierszu
                {
                    Console.Write("{0,5} ", j*i);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
