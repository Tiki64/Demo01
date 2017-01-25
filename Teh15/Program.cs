using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku > ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number - 2; i++)
            {
                Random rand = new Random();
                int luku = rand.Next(0, 101);
            }
        }
    }
}
