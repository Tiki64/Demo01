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
            int number;
            Console.Write("Anna numero >");
            string line = Console.ReadLine();
            bool result = int.TryParse(line, out number);
            if (result == true)
            {
                switch (number)
                {
                    case 1: Console.WriteLine("Yksi"); break;
                    case 2: Console.WriteLine("Kaksi"); break;
                    case 3: Console.WriteLine("Kolme"); break;
                    default: Console.WriteLine("Joku muu luku"); break;
                }
                Console.ReadLine();
            }
        }
    }
}
