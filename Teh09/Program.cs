using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh09
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int number = -1;
            while (number != 0)
            {
                Console.Write("Anna Luku  ");
                number = int.Parse(Console.ReadLine());
                total = total + number;
            }
            Console.WriteLine("Lukujen summa on " + total);
        }
    }
}
