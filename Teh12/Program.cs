using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Anna viisi numeroa ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int[] jono = { a, b, c, d, e };
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(jono[i]);
            }
        }
    }
}
