using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 8; x++)
            {
                if (x > 5)
                    break;
                
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
