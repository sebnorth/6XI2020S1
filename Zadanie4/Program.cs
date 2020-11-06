using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b");
            int b = int.Parse(Console.ReadLine());

            // int i = a;

            int max, min;

            if (a > b) { max = a; min = b; }
            else { max = b; min = a; }

            if (min % 2 != 0) min++; 

            while (min <= max)
            {
                Console.Write("{0} ", min);
                min += 2;
            }



            //while (min <= max)
            //{
            //    if (min % 2 == 0) Console.Write("{0} ", min);

            //    min += 1;
            //}

            Console.ReadKey();

        }
    }
}
