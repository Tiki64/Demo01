using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh01
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Gimme numbero 1-3 >");
            luku = int.Parse(Console.ReadLine());

            if (luku == 1)
            {
                Console.WriteLine("Yksi");
            }
            else if (luku == 2)
            {
                Console.WriteLine("Kaksi");
            }
            else if (luku == 3)
            {
                Console.WriteLine("Kolme");
            }
            else
            {
                Console.WriteLine("Joku muu luku: ");
            }
            Console.ReadLine();
        }
    }
}
