using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (++i <= 10)
            {
                Console.WriteLine("Aktualna wartość i wynosi: {0}", i);
                // i += 1;
            }

            Console.WriteLine();
            
            i = 0;

            while (i++ <= 10)
            {
                Console.WriteLine("Aktualna wartość i wynosi: {0}", i);
                // i += 1;
            }

            Console.ReadKey();
        }
    }
}
