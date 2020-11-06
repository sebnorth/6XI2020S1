using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dlug = 80;
            int janek = 50; // stawka dzienna Janka
            int karol = 40; // stawka dzienna Karola
            int splata = 0;
            int dzien = 0;

            do
            {
                dzien++;
                splata += (int)(0.2 * janek + 0.2 * karol);

                Console.WriteLine("dzień nr: {0}, spłata łączna do tego dnia: {1}", 
                    dzien, splata);

            } while (splata < dlug);

            Console.ReadKey();
        }
    }
}
